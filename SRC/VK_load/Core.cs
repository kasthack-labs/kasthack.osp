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

namespace VK_load {
    internal class Core {
        private const int _appID = 3174839;
        private readonly Encoding _textEncoding = Encoding.UTF8;
        private readonly RawApi _api;
        public static int AppID => _appID;
        public bool IsLogged => _api.IsLogged;

        public Core( string redirectUrl=null ) {
            _api = new RawApi();
            try {
                if (!String.IsNullOrWhiteSpace(redirectUrl))
                    _api.AddToken( Token.FromRedirectUrl( redirectUrl ) );
            }
            catch {}
        }

        public async Task LoadUsers(
            LoadOptions options ) {

            long trafficUsed = 0, usersLoaded = 0;
            var current = options.Start;

            var semaphore = new SemaphoreSlim( options.Threads );
            int activeThreads=0;

            Func<int, Task> getChunk = async i => {
                try {
                    var users = Enumerable.Range( i, Math.Min(options.VolumeSize, options.End - i ) ).ToArray();
                    if (options.CancellationToken?.Invoke() ?? false ) {
                        return;
                    };
                    var outfile = GetChunkPath(options.Path, users, options.GZip );
                    if ( !File.Exists( outfile ) ) {
                        var resp = await GetUsers( options, users ).ConfigureAwait(false);
                        if ( resp == null ) return;
                        await SaveFile( outfile, resp, options.GZip ).ConfigureAwait(false);
                        usersLoaded += options.VolumeSize;
                        trafficUsed += _textEncoding.GetByteCount( resp );
                        options.ShowTraffic?.Invoke( trafficUsed );
                        options.ShowCount?.Invoke( usersLoaded );
                    }
                }
                catch {}
                finally {
                    --activeThreads;
                    semaphore.Release();
                }
            };

            while ( current < options.End ) {
                if (options.CancellationToken?.Invoke() ?? false ) break;
                await semaphore.WaitAsync().ConfigureAwait(false);
                Console.WriteLine( "Threads: {0}", ++activeThreads );
                var tsk = getChunk( current );
                if (tsk.Status != TaskStatus.RanToCompletion && options.Delay)
                    await Task.Delay( 400 ).ConfigureAwait(false);
                current += options.VolumeSize;
            }
        }

        private async Task<string> GetUsers( LoadOptions options, int[] users ) {
            if ( options.Execute ) {
                var req = new Request<User[]>() { 
                    MethodName = "execute.mfetch25a",
                    Token = _api.CurrentToken,
                    Parameters = new Dictionary<string, string>()
                };
                req.Parameters.Add( "fields", string.Join( ",", MiscTools.GetUserFields( options.Fields )) );
                var uids = users.Select( ( value, index ) => new { value, index } ).GroupBy( a => a.index / 1000 ).Select( a => a.Select( b => b.value ).ToArray() ).ToArray();
                for ( int i = 0; i < uids.Length; i++ ) req.Parameters.Add( "u" + i, uids[ i ].ToNCStringA() );

                var s = await _api.Executor.ExecRawAsync( req ).ConfigureAwait( false );
                return s;
            }
            else {
                return await _api.Users.Get(options.Fields, NameCase.Nom, users ).ConfigureAwait( false );
            }
        }

        private async Task SaveFile( string outfile, string resp, bool gzip ) {
            using ( var f = File.OpenWrite( outfile ) ) {
                using ( Stream s = gzip ? (Stream) new GZipStream( f, CompressionMode.Compress ) : f ) {
                    using ( var sw = new StreamWriter(s) ) {
                        await sw.WriteAsync( resp ).ConfigureAwait(false);
                        await sw.FlushAsync().ConfigureAwait(false);
                    }
                }
            }
        }

        private static string GetChunkPath( string downloadDir, int[] users, bool gzip ) {
            var filename = $"{users.First()}_{users.Length}.json{( gzip ? ".gz" : "" )}";
            downloadDir = Path.Combine( downloadDir, ( users.First() / 1000000 ).ToString() );
            if ( !Directory.Exists( downloadDir ) ) Directory.CreateDirectory( downloadDir );
            return Path.Combine( downloadDir, filename );
        }
    }

    public class LoadOptions {

        public bool Delay { get; set; } = true;
        public int Start { get; set; } = 1;
        public int End { get; set; } = 350000000;
        public int Threads { get; set; } = 25;
        public int VolumeSize { get; set; } = 1000;
        public bool GZip { get; set; } = true;
        public bool Execute { get; set; } = true;
        public string Path { get; set; }
        public UserFields Fields { get; set; }

        public Action<long> ShowCount { get; set; }
        public Action<long> ShowTraffic { get; set; }
        public Func<bool> CancellationToken { get; set; }// I know about std cancellation tokens
    }
}