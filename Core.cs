using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using kasthack.vksharp;
using kasthack.vksharp.DataTypes.Entities;
using kasthack.vksharp.DataTypes.Enums;
using kasthack.vksharp.Implementation;
using kasthack.vksharp.Internal;

namespace kasthack.OSP
{
    internal class Core
    {
        private const int _appID = 3174839;
        private readonly Encoding _textEncoding = Encoding.UTF8;
        private readonly RawApi _api;
        public static int AppID => _appID;
        public bool IsLogged => _api.IsLogged;

        public Core(string redirectUrl = null)
        {
            _api = new RawApi();
            try
            {
                if (!String.IsNullOrWhiteSpace(redirectUrl))
                    _api.AddToken(Token.FromRedirectUrl(redirectUrl));
            }
            catch { }
        }

        public async Task LoadUsers(
            LoadOptions options)
        {

            long trafficUsed = 0, usersLoaded = 0;
            var p = options.UseCounter ? (IIdProvdier)new RangeIdProvider(options.Start, options.End) : new FileIdProvdier(options.SourceFile);
            int activeThreads = 0;
            using (var semaphore = new SemaphoreSlim(options.Threads))
            {

                Func<int[], Task> getChunk = async i =>
                {
                    try
                    {
                        int[] users = i;
                        if (options.CancellationToken?.Invoke() ?? false) return;
                        var outfile = GetChunkPath(options, users);
                        if (!File.Exists(outfile))
                        {
                            var resp = await GetUsers(options, users).ConfigureAwait(false);
                            if (resp == null) return;
                            await SaveFile(outfile, resp, options.GZip).ConfigureAwait(false);
                            usersLoaded += users.Length;
                            trafficUsed += _textEncoding.GetByteCount(resp);
                            options.ShowTraffic?.Invoke(trafficUsed);
                            options.ShowCount?.Invoke(usersLoaded);
                        }
                    }
                    catch { }
                    finally
                    {
                        --activeThreads;
                        semaphore.Release();
                    }
                };

                int[] current;
                while ((current = await p.Get(options.VolumeSize).ConfigureAwait(false)).Any())
                {
                    if (options.CancellationToken?.Invoke() ?? false) break;
                    await semaphore.WaitAsync().ConfigureAwait(false);
                    Console.WriteLine("Threads: {0}", ++activeThreads);
                    var tsk = getChunk(current);
                    if (options.DelayEnabled)
                        await Task.Delay(options.Delay).ConfigureAwait(false);
                }
                for (int i = 0; i < options.Threads; i++) await semaphore.WaitAsync().ConfigureAwait(false);
            }
        }

        private async Task<string> GetUsers(LoadOptions options, int[] users)
        {
            if (options.Execute)
            {
                var req = new Request<User[]>
                {
                    MethodName = "execute.mfetch25a",
                    Token = _api.CurrentToken,
                    Parameters = new Dictionary<string, string>()
                };
                req.Parameters.Add("fields", string.Join(",", MiscTools.GetUserFields(options.Fields)));
                var uids = users.Select((value, index) => new { value, index }).GroupBy(a => a.index / 1000).Select(a => a.Select(b => b.value).ToArray()).ToArray();
                for (int i = 0; i < uids.Length; i++) req.Parameters.Add("u" + i, uids[i].ToNCStringA());

                return await _api.Executor.ExecRawAsync(req).ConfigureAwait(false);
            }
            return await _api.Users.Get(options.Fields, NameCase.Nom, users).ConfigureAwait(false);
        }

        private async Task SaveFile(string outfile, string resp, bool gzip)
        {
            using (var f = File.OpenWrite(outfile))
            {
                using (Stream s = gzip ? (Stream)new GZipStream(f, CompressionMode.Compress) : f)
                {
                    using (var sw = new StreamWriter(s))
                    {
                        await sw.WriteAsync(resp).ConfigureAwait(false);
                        await sw.FlushAsync().ConfigureAwait(false);
                    }
                }
            }
        }

        private static string GetChunkPath(LoadOptions options, int[] users)
        {
            var filename = $"{users.First()}_{users.Length}.json{(options.GZip ? ".gz" : "")}";
            var dir = options.Path;
            if (options.Subdirs)
            {
                dir = Path.Combine(dir, (users.First() / 1000000).ToString());
                if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);
            }
            return Path.Combine(dir, filename);
        }
    }

    public class LoadOptions
    {

        public bool Subdirs { get; set; } = true;
        public bool DelayEnabled { get; set; } = true;
        public int Start { get; set; } = 1;
        public int End { get; set; } = 350000000;
        public string SourceFile { get; set; }
        public bool UseCounter { get; set; } = true;
        public int Threads { get; set; } = 25;
        public int VolumeSize { get; set; } = 1000;
        public int Delay { get; set; } = 400;
        public bool GZip { get; set; } = true;
        public bool Execute { get; set; } = true;
        public string Path { get; set; }
        public UserFields Fields { get; set; }
        public Action<long> ShowCount { get; set; }
        public Action<long> ShowTraffic { get; set; }
        public Func<bool> CancellationToken { get; set; }// I know about std cancellation tokens
    }

    public interface IIdProvdier : IDisposable
    {

        Task<int[]> Get(int count);

    }

    class FileIdProvdier : IIdProvdier
    {

        private FileStream f;
        private StreamReader r;
        private SemaphoreSlim semaphore = new SemaphoreSlim(1);

        public FileIdProvdier(string path)
        {
            f = File.OpenRead(path);
            r = new StreamReader(f);
        }

        public async Task<int[]> Get(int count)
        {
            try
            {
                await semaphore.WaitAsync().ConfigureAwait(false);
                string s = null;
                List<int> ret = new List<int>(count);
                for (int i = 0; i < count && (s = await r.ReadLineAsync().ConfigureAwait(false)) != null; i++)
                {
                    int tmp;
                    if (int.TryParse(s, out tmp))
                    {
                        ret.Add(tmp);
                    } //todo: link parsing, not only integers
                }
                return ret.ToArray();
            }
            catch (Exception)
            {
                return Array.Empty<int>();
            }
            finally
            {
                semaphore.Release();
            }
        }

        public void Dispose()
        {
            r.Dispose();
            f.Dispose();
            semaphore.Dispose();
        }

    }

    class RangeIdProvider : IIdProvdier
    {

        private readonly int _start;
        private readonly int _end;
        private int _current;
        private readonly object locker = new object();

        public RangeIdProvider(int start, int end)
        {
            _start = start;
            _end = end;
            _current = 0;
        }

        public void Dispose() { }

        public async Task<int[]> Get(int count)
        {
            int s;
            int cnt;
            lock (locker)
            {
                s = _start + _current;
                cnt = Math.Min(_end - s + 1, count);
                _current += cnt;
            }
            return Enumerable.Range(s, cnt).ToArray();
        }

    }


}