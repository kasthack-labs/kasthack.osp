/*
*************************************************************************************
Tis file is distributed under MIT license:
*************************************************************************************
The MIT License (MIT)

Copyright © 2013-2014 EpicMorg

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the ''Software''), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED ''AS IS'', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.", @"The MIT License (MIT)
*************************************************************************************
 */

using System;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace VK_load {
    public partial class frm_main : Form {
        private VkApi _api;
        private bool _running;
        private bool _cancel;
        public frm_main() {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e) { Process.Start(String.Format(VkApi.AuthURL, VkApi.AppID)); }

        private void btn_fin_auth_Click(object sender, EventArgs e) {
            this._api = new VkApi(txt_token.Text);
            if (!this._api.IsLogged) {
                MessageBox.Show(@"Bad url! Please try again.", @"Warning!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                lbl_sign.Text = "Not loaded";
                lbl_token.Text = "Not loaded";
            }
            else {
                lbl_sign.Text = this._api.Sign;
                lbl_token.Text = this._api.AccessToken;
            }
            grp_conf.Enabled = grp_control.Enabled = grp_fileds.Enabled = this._api.IsLogged;
        }
        //  private void txt_token_TextChanged(object sender, EventArgs e) {  btn_fin_auth.Enabled = true; } 

        private void btn_folder_Click(object sender, EventArgs e) {
            using (var dialog = new FolderBrowserDialog())
                if (dialog.ShowDialog() == DialogResult.OK)
                    txt_outpath.Text = dialog.SelectedPath;
        }

        private async void btn_run_Click(object sender, EventArgs e) {
            if (!this._running) {
                this._running = true;
                this._cancel = false;
                UpdateInterfaceIsRunnig();
                int start = (int)nud_start.Value,
                    end = (int)nud_end.Value,
                    volume = (int)nud_volume.Value;
                if (end - start + 1 < volume) {
                    MessageBox.Show("Volume must be less than end-start", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    await this._api.LoadUsers(
                        start,
                        end,
                        txt_outpath.Text,
                        lst_fields.CheckedItems.OfType<string>().ToArray(),
                       volume,
                        UpdateProfilesCount,
                        UpdateTraffic,
                        () => this._cancel
                    );
                this._running = false;
                btn_run.Enabled = true;
                UpdateInterfaceIsRunnig();
                MessageBox.Show(@"Download complete!", @"Win!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressbar.Value = 0;
                // btn_kill.Enabled = true;
            }
            else {
                _cancel = true;
                btn_run.Enabled = false;
            }
        }

        private void UpdateProfilesCount(long a) {
            var total = nud_end.Value - nud_start.Value;
            lbl_profiles_loaded.Text = a.ToString(CultureInfo.InvariantCulture);
            progressbar.Value = Math.Min((int)(a * 100 / total), 100);
        }

        private void UpdateTraffic(long a) {
            var postfix = new[] { 'B', 'K', 'M', 'G', 'T' };
            var index = 0;
            while (a > 1024) {
                index++;
                a >>= 10;
            }
            lbl_traf.Text = String.Format("{0} {1}", a.ToString(CultureInfo.InvariantCulture), postfix[index]);

        }

        private void UpdateInterfaceIsRunnig() {
            if (this._running) {
                btn_run.Text = "Step 5. STOP IT!";
                lbl_state.Text = "Running";
                lbl_state.ForeColor = Color.DarkGreen;
                grp_conf.Enabled = grp_fileds.Enabled = grp_auth.Enabled = false;
            }
            else {
                btn_run.Text = "Step 5. RUT IT!";
                lbl_state.Text = "Stand by";
                lbl_state.ForeColor = Color.DarkGoldenrod;
                grp_conf.Enabled = grp_fileds.Enabled = grp_auth.Enabled = true;
            }

        }

        private void button2_Click_1(object sender, EventArgs e) { CheckAll(true); }
        private void button1_Click_1(object sender, EventArgs e) { CheckAll(false); }
        void CheckAll(bool value) {
            for (var i = 0; i < lst_fields.Items.Count; i++) {
                lst_fields.SetItemChecked(i, value);
            }
        }

        private void btn_kill_Click(object sender, EventArgs e) {
            MessageBox.Show(@"Created by KASTHACK" + Environment.NewLine +
                             "GUI Fixes by STAM" + Environment.NewLine +
                             "License: The MIT License (MIT)" + Environment.NewLine +
                             "_______________________________________________________" + Environment.NewLine + 
                             "https://github.com/kasthack/OslikSuslikPaukan", @"Info:", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            MessageBox.Show(@"The MIT License (MIT)" + Environment.NewLine + Environment.NewLine +
                            @"Copyright © 2013-2014 EpicMorg" + Environment.NewLine + Environment.NewLine +
                            @"Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the ''Software'')," +
                            "to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or" +
                            "sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:)" + Environment.NewLine + Environment.NewLine +
                            @"The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.)" + Environment.NewLine + Environment.NewLine +
                            @"THE SOFTWARE IS PROVIDED ''AS IS'', WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY," +
                            "FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER" +
                            "LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS" +
                            "IN THE SOFTWARE.", @"The MIT License (MIT)", MessageBoxButtons.OK, MessageBoxIcon.Information); 
        } 
        private void btn_clear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            txt_token.Text = "";
        }

        private void frm_main_Load(object sender, EventArgs e) {

        }


    }
}
