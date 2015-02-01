using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VKSharp;
using VKSharp.Core.Enums;
using VKSharp.Data.Api;
using VKSharp.Data.Parameters;

namespace VK_load {
    internal class Core {
        private const int _appID = 3174839;
        private readonly Encoding _textEncoding = Encoding.UTF8;
        private readonly RawApi _api;
        public static int AppID => _appID;
        public bool IsLogged => _api.IsLogged;

        public Core( string redirectUrl ) {
            _api = new RawApi();
            try {
                _api.AddToken( VKToken.FromRedirectUrl( redirectUrl ) );
            }
            catch {}
        }

        public async Task LoadUsers(
            int start,
            int end,
            int threads,
            string downloadDir,
            UserFields fields,
            int volumeSize = 1000,
            bool gzip = true,
            Action<long> showCount = null,
            Action<long> showTraffic = null,
            Func<bool> cancellationToken = null ) {

            long trafficUsed = 0, usersLoaded = 0;
            var current = start;

            var semaphore = new SemaphoreSlim( threads );
            int activeThreads=0;

            Func<int, Task> getChunk = async i => {
                try {
                    var users = Enumerable.Range( i, Math.Min( volumeSize, end - i ) ).ToArray();
                    if ( cancellationToken?.Invoke() ?? false ) {
                        return;
                    };
                    var outfile = GetChunkPath( downloadDir, users,gzip );
                    if ( !File.Exists( outfile ) ) {
                        var resp = await _api.Users.Get( fields, NameCase.Nom, users );
                        if ( resp == null ) return;
                        await SaveFile( outfile, resp, gzip );
                        usersLoaded += volumeSize;
                        trafficUsed += _textEncoding.GetByteCount( resp );
                        showTraffic?.Invoke( trafficUsed );
                        showCount?.Invoke( usersLoaded );
                    }
                }
                catch {}
                finally {
                    --activeThreads;
                    semaphore.Release();
                }
            };

            while ( current < end ) {
                if ( cancellationToken?.Invoke() ?? false ) break;
                await semaphore.WaitAsync();
                Console.WriteLine( "Threads: {0}", ++activeThreads );
                var tsk = getChunk( current );
                if (tsk.Status != TaskStatus.RanToCompletion)
                    await Task.Delay( 400 );
                current += volumeSize;
            }
        }

        private async Task SaveFile( string outfile, string resp, bool gzip ) {
            using ( var f = File.OpenWrite( outfile ) ) {
                using ( Stream s = gzip ? (Stream) new GZipStream( f, CompressionMode.Compress ) : f ) {
                    using ( var sw = new StreamWriter(s) ) {
                        await sw.WriteAsync( resp );
                        await sw.FlushAsync();
                    }
                }
            }
        }

        private static string GetChunkPath( string downloadDir, int[] users, bool gzip ) {
            var filename = String.Format( "{0}_{1}.json{2}", users.First(), users.Length, gzip?".gz" :"" );
            downloadDir = Path.Combine( downloadDir, ( users.First() / 1000000 ).ToString() );
            if ( !Directory.Exists( downloadDir ) ) Directory.CreateDirectory( downloadDir );
            return Path.Combine( downloadDir, filename );
        }
    }
}