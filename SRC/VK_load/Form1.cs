using System;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace VK_load {
    public partial class Form1 : Form {
        private VkApi _api;
        private bool _running;
        private bool _cancel;
        public Form1() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click( object sender, EventArgs e ) { Process.Start( String.Format( VkApi.AuthURL, VkApi.AppID ) ); }
        private void button2_Click( object sender, EventArgs e ) {
            this._api = new VkApi( txt_token.Text );
            if ( !this._api.IsLogged )
                MessageBox.Show( @"Bad url" );
            else {
                lbl_sign.Text = this._api.Sign;
                lbl_token.Text = this._api.AccessToken;
            }
            grp_conf.Enabled = grp_control.Enabled = this._api.IsLogged;
        }

        private async void btn_run_Click( object sender, EventArgs e ) {
            if ( !this._running ) {
                this._running = true;
                this._cancel = false;
                UpdBtn();
                await this._api.LoadUsers(
                    (int) nud_start.Value,
                    (int) nud_end.Value,
                    txt_outpath.Text,
                    lst_fields.CheckedItems.OfType<string>().ToArray(),
                    (int) nud_volume.Value,
                    (a) => lbl_profiles_loaded.Text = a.ToString(CultureInfo.InvariantCulture),
                    (a) => lbl_traf.Text = a.ToString(CultureInfo.InvariantCulture),
                    () => this._cancel
                );
                this._running = false;
                btn_run.Enabled = true;
                UpdBtn();
                MessageBox.Show( @"Win", @"Download complete!" );
            }
            else {
                _cancel = true;
                btn_run.Enabled = false;
            }
        }

        private void UpdBtn() {
            btn_run.Text = this._running ? "Stop" : "Run";
            lbl_state.Text = this._running ? "Running" : "Stand by";
        }

        private void button2_Click_1( object sender, EventArgs e ) { CheckAll( true ); }
        private void button1_Click_1( object sender, EventArgs e ) { CheckAll( false ); }
        void CheckAll( bool value ) {
            for ( var i = 0; i < lst_fields.Items.Count; i++ ) {
                lst_fields.SetItemChecked( i, value );
            }
        }

        private void grp_conf_Enter( object sender, EventArgs e ) {

        }

        private void grp_auth_Enter( object sender, EventArgs e ) {

        }
    }
}
