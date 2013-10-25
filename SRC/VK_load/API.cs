using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using EpicMorg.Net;

namespace VK_load {
    class VkApi {

        #region VK consts
        private const string RedirectURL = "https://oauth.vk.com/blank.html";
        private const string APIDomain = "http://api.vk.com";
        private const int _appID = 3174839;
        private const string SAuthURL = "https://oauth.vk.com/authorize?client_id={0}&scope=friends,groups,nohttps&redirect_uri=https%3A%2F%2Foauth.vk.com%2Fblank.htmlI&display=page&response_type=token";
        #endregion

        #region Vars
        private readonly string _accessToken;
        private readonly string _sign;
        private readonly MD5 _hasher = MD5.Create();
        readonly Encoding _textEncoding = Encoding.UTF8;
        #endregion

        #region Properties
        public static int AppID { get { return _appID; } }
        public static string AuthURL {
            get {
                return SAuthURL;
            }
        }
        public bool IsLogged { get; private set; }

        public string Sign {
            get { return this._sign; }
        }

        public string AccessToken {
            get { return this._accessToken; }
        }
        #endregion

        #region Constructor
        public VkApi(string redirectUrl) {
            var u = redirectUrl;
            try {
                if (!u.StartsWith(RedirectURL)) {
                    IsLogged = false;
                    return;
                }
                var qu =
                    u.Split("#?".ToCharArray())
                        .Last()
                        .Split("&".ToCharArray())
                        .Select(a => a.Split("=".ToCharArray()))
                        .Where(a => a.Length == 2)
                        .ToDictionary(a => a[0], a => a[1]);
                if (qu.ContainsKey("error")) {
                    IsLogged = false;
                    return;
                }
                this._accessToken = qu["access_token"];
                this._sign = qu["secret"];
                IsLogged = true;
            }
            catch (KeyNotFoundException) {
                IsLogged = false;
            }
        }
        #endregion
        #region public Methods
        public async Task LoadUsers(
            int start,
            int end,
            string downloadDir,
            string[] fields,
            int volumeSize = 1000,
            Action<long> showCount = null,
            Action<long> showTraffic = null,
            Func<bool> cancellationToken = null) {

            bool sCe = showCount != null,
                sTe = showTraffic != null,
                cTe = cancellationToken != null;
            long trafficUsed = 0,
                 usersLoaded = 0;

            //end++;
            var fieldsFormatted = String.Join(",", fields);
            var current = start;

            while (current < end) {
                var users = Enumerable.Range(current, Math.Min(volumeSize, end - current)).ToArray();
                if (cTe && cancellationToken())
                    return;
                var outfile = Path.Combine(downloadDir, String.Format("{0}_{1}.xml", users.First(), users.Length));
                if (!File.Exists(outfile)) {
                    var query = String.Format(
                        "user_ids={0}&fields={1}&v=5.2",
                        string.Join(",", users),
                        fieldsFormatted
                        );
                    var resp = await this.ExecMethodAsync("users.get.xml", query);
                    if (resp == null)
                        continue;
                    File.WriteAllText(outfile, resp);
                    usersLoaded += volumeSize;
                    trafficUsed += this._textEncoding.GetByteCount(resp);
                    if (sTe)
                        showTraffic(trafficUsed);
                    if (sCe)
                        showCount(usersLoaded);
                }
                current += volumeSize;
            }
        }
        #endregion

        #region Engine
        private async Task<string> ExecMethodAsync(string method, string query) {
            try {
                var queryB = new StringBuilder();
                queryB.Insert(0, "/method/");
                queryB.Append(method);
                queryB.Append("?access_token=");
                queryB.Append(this.AccessToken);
                var sign = SignQuery(queryB.ToString() + "&" + query);
                queryB.Insert(0, APIDomain);
                queryB.Append("&sig=");
                queryB.Append(sign);
                return await AWC.DownloadStringAsync(
                    queryB.ToString(),
                    this._textEncoding,
                    null,
                    null,
                    AWC.RequestMethod.POST,
                    query,
                    40000);
            }
            catch (WebException) {
                return null;
            }
        }
        private string SignQuery(string query) {
            return BitConverter.ToString(
                this._hasher.ComputeHash(
                    this.
                    _textEncoding.
                    GetBytes(
                        query +
                        this.Sign
                    )
                )
            ).
            Replace("-", "").
            ToLower();
        }
        #endregion
    }
}
