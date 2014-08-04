using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using VKSharp;
using VKSharp.Core.Enums;
using VKSharp.Data.Api;
using VKSharp.Data.Parameters;

namespace VK_load {
    class Core {
        private const int _appID = 3174839;
        private readonly Encoding _textEncoding = Encoding.UTF8;
        private readonly RawApi _api;
        public static int AppID { get { return _appID; } }
        public bool IsLogged { get { return _api.IsLogged; } }

        public Core(string redirectUrl) {
            _api = new RawApi();
            try { _api.AddToken(VKToken.FromRedirectUrl( redirectUrl )); } catch{ }
        }
        public async Task LoadUsers( int start, int end, int threads,
            string downloadDir, UserFields fields, int volumeSize = 1000,
            Action<long> showCount = null, Action<long> showTraffic = null,
            Func<bool> cancellationToken = null) {

            bool sCe = showCount != null, sTe = showTraffic != null, cTe = cancellationToken != null;
            long trafficUsed = 0, usersLoaded = 0;
            var current = start;
            var semaphore = new SemaphoreSlim( threads );

            Func<int, Task> getChunk = async i =>
            {
                try {
                    var users = Enumerable.Range( i, Math.Min( volumeSize, end - i ) ).Select( a => (uint) a ).ToArray();
                    if ( cTe && cancellationToken() ) return;
                    var outfile = Path.Combine( downloadDir, String.Format( "{0}_{1}.xml", users.First(), users.Length ) );
                    if ( !File.Exists( outfile ) ) {
                        var resp = await _api.UsersGetAsync( fields, NameCase.Nom, users );
                        if ( resp == null ) return;
                        File.WriteAllText( outfile, resp );
                        usersLoaded += volumeSize;
                        trafficUsed += _textEncoding.GetByteCount( resp );
                        if ( sTe ) showTraffic( trafficUsed );
                        if ( sCe ) showCount( usersLoaded );
                    }
                }
                catch {}
                finally {
                    semaphore.Release();
                }
            };

            while (current < end) {
                await semaphore.WaitAsync();
                getChunk( current );
                current += volumeSize;
            }
        }
    }
}
