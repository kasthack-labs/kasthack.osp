namespace VK_load {
    partial class frm_main {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.grp_auth = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.LinkLabel();
            this.btn_fin_auth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_auth = new System.Windows.Forms.Button();
            this.grp_conf = new System.Windows.Forms.GroupBox();
            this.btn_folder = new System.Windows.Forms.Button();
            this.nud_volume = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.nud_end = new System.Windows.Forms.NumericUpDown();
            this.nud_start = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_outpath = new System.Windows.Forms.TextBox();
            this.nud_threads = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grp_control = new System.Windows.Forms.GroupBox();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.lbl_state = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.lbl_traf = new System.Windows.Forms.Label();
            this.lbl_profiles_loaded = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_fields = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grp_fileds = new System.Windows.Forms.GroupBox();
            this.btn_kill = new System.Windows.Forms.Button();
            this.grp_auth.SuspendLayout();
            this.grp_conf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_threads)).BeginInit();
            this.grp_control.SuspendLayout();
            this.grp_fileds.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_auth
            // 
            this.grp_auth.Controls.Add(this.btn_clear);
            this.grp_auth.Controls.Add(this.btn_fin_auth);
            this.grp_auth.Controls.Add(this.label2);
            this.grp_auth.Controls.Add(this.txt_token);
            this.grp_auth.Controls.Add(this.label1);
            this.grp_auth.Controls.Add(this.btn_auth);
            this.grp_auth.Location = new System.Drawing.Point(6, 5);
            this.grp_auth.Name = "grp_auth";
            this.grp_auth.Size = new System.Drawing.Size(478, 74);
            this.grp_auth.TabIndex = 0;
            this.grp_auth.TabStop = false;
            this.grp_auth.Text = "VK Auth:";
            // 
            // btn_clear
            // 
            this.btn_clear.AutoSize = true;
            this.btn_clear.Location = new System.Drawing.Point(368, 22);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(36, 13);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.TabStop = true;
            this.btn_clear.Text = "[clear]";
            this.btn_clear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btn_clear_LinkClicked);
            // 
            // btn_fin_auth
            // 
            this.btn_fin_auth.Location = new System.Drawing.Point(410, 19);
            this.btn_fin_auth.Name = "btn_fin_auth";
            this.btn_fin_auth.Size = new System.Drawing.Size(62, 39);
            this.btn_fin_auth.TabIndex = 4;
            this.btn_fin_auth.Text = "Step 3. Login";
            this.btn_fin_auth.UseVisualStyleBackColor = true;
            this.btn_fin_auth.Click += new System.EventHandler(this.btn_fin_auth_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Step2. Paste url from adress bar after auth";
            // 
            // txt_token
            // 
            this.txt_token.Location = new System.Drawing.Point(128, 38);
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(275, 20);
            this.txt_token.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(78, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "→";
            // 
            // btn_auth
            // 
            this.btn_auth.Location = new System.Drawing.Point(16, 19);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(62, 39);
            this.btn_auth.TabIndex = 0;
            this.btn_auth.Text = "Step  1. Auth";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_conf
            // 
            this.grp_conf.Controls.Add(this.btn_folder);
            this.grp_conf.Controls.Add(this.nud_volume);
            this.grp_conf.Controls.Add(this.label12);
            this.grp_conf.Controls.Add(this.nud_end);
            this.grp_conf.Controls.Add(this.nud_start);
            this.grp_conf.Controls.Add(this.label11);
            this.grp_conf.Controls.Add(this.label10);
            this.grp_conf.Controls.Add(this.txt_outpath);
            this.grp_conf.Controls.Add(this.nud_threads);
            this.grp_conf.Controls.Add(this.label4);
            this.grp_conf.Controls.Add(this.label3);
            this.grp_conf.Enabled = false;
            this.grp_conf.Location = new System.Drawing.Point(7, 85);
            this.grp_conf.Name = "grp_conf";
            this.grp_conf.Size = new System.Drawing.Size(477, 92);
            this.grp_conf.TabIndex = 1;
            this.grp_conf.TabStop = false;
            this.grp_conf.Text = "Step 4. Configure:";
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(188, 53);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(24, 23);
            this.btn_folder.TabIndex = 10;
            this.btn_folder.Text = "...";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.btn_folder_Click);
            // 
            // nud_volume
            // 
            this.nud_volume.Location = new System.Drawing.Point(367, 55);
            this.nud_volume.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nud_volume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_volume.Name = "nud_volume";
            this.nud_volume.Size = new System.Drawing.Size(98, 20);
            this.nud_volume.TabIndex = 9;
            this.nud_volume.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Volume size";
            // 
            // nud_end
            // 
            this.nud_end.Location = new System.Drawing.Point(253, 55);
            this.nud_end.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_end.Name = "nud_end";
            this.nud_end.Size = new System.Drawing.Size(88, 20);
            this.nud_end.TabIndex = 7;
            this.nud_end.Value = new decimal(new int[] {
            228402285,
            0,
            0,
            0});
            // 
            // nud_start
            // 
            this.nud_start.Location = new System.Drawing.Point(253, 27);
            this.nud_start.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_start.Name = "nud_start";
            this.nud_start.Size = new System.Drawing.Size(88, 20);
            this.nud_start.TabIndex = 6;
            this.nud_start.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "End";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(218, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Start";
            // 
            // txt_outpath
            // 
            this.txt_outpath.Location = new System.Drawing.Point(96, 55);
            this.txt_outpath.Name = "txt_outpath";
            this.txt_outpath.Size = new System.Drawing.Size(88, 20);
            this.txt_outpath.TabIndex = 3;
            // 
            // nud_threads
            // 
            this.nud_threads.Location = new System.Drawing.Point(96, 27);
            this.nud_threads.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_threads.Name = "nud_threads";
            this.nud_threads.Size = new System.Drawing.Size(116, 20);
            this.nud_threads.TabIndex = 2;
            this.nud_threads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Output path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(12, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thread count";
            // 
            // grp_control
            // 
            this.grp_control.Controls.Add(this.progressbar);
            this.grp_control.Controls.Add(this.lbl_state);
            this.grp_control.Controls.Add(this.label9);
            this.grp_control.Controls.Add(this.btn_run);
            this.grp_control.Controls.Add(this.lbl_traf);
            this.grp_control.Controls.Add(this.lbl_profiles_loaded);
            this.grp_control.Controls.Add(this.label6);
            this.grp_control.Controls.Add(this.label5);
            this.grp_control.Enabled = false;
            this.grp_control.Location = new System.Drawing.Point(6, 183);
            this.grp_control.Name = "grp_control";
            this.grp_control.Size = new System.Drawing.Size(478, 121);
            this.grp_control.TabIndex = 2;
            this.grp_control.TabStop = false;
            this.grp_control.Text = "Control:";
            // 
            // progressbar
            // 
            this.progressbar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressbar.Location = new System.Drawing.Point(16, 92);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(450, 20);
            this.progressbar.Step = 1;
            this.progressbar.TabIndex = 7;
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(273, 70);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(38, 13);
            this.lbl_state.TabIndex = 6;
            this.lbl_state.Text = "Ready";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "State:";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(16, 25);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(166, 58);
            this.btn_run.TabIndex = 4;
            this.btn_run.Text = "Step 5. RUT IT!";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // lbl_traf
            // 
            this.lbl_traf.AutoSize = true;
            this.lbl_traf.Location = new System.Drawing.Point(273, 47);
            this.lbl_traf.Name = "lbl_traf";
            this.lbl_traf.Size = new System.Drawing.Size(13, 13);
            this.lbl_traf.TabIndex = 3;
            this.lbl_traf.Text = "0";
            // 
            // lbl_profiles_loaded
            // 
            this.lbl_profiles_loaded.AutoSize = true;
            this.lbl_profiles_loaded.Location = new System.Drawing.Point(273, 25);
            this.lbl_profiles_loaded.Name = "lbl_profiles_loaded";
            this.lbl_profiles_loaded.Size = new System.Drawing.Size(13, 13);
            this.lbl_profiles_loaded.TabIndex = 2;
            this.lbl_profiles_loaded.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Traffic:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Profiles loaded:";
            // 
            // lst_fields
            // 
            this.lst_fields.FormattingEnabled = true;
            this.lst_fields.Location = new System.Drawing.Point(6, 48);
            this.lst_fields.Name = "lst_fields";
            this.lst_fields.Size = new System.Drawing.Size(175, 319);
            this.lst_fields.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "None";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // grp_fileds
            // 
            this.grp_fileds.Controls.Add(this.button1);
            this.grp_fileds.Controls.Add(this.button2);
            this.grp_fileds.Controls.Add(this.lst_fields);
            this.grp_fileds.Enabled = false;
            this.grp_fileds.Location = new System.Drawing.Point(490, 5);
            this.grp_fileds.Name = "grp_fileds";
            this.grp_fileds.Size = new System.Drawing.Size(187, 375);
            this.grp_fileds.TabIndex = 13;
            this.grp_fileds.TabStop = false;
            this.grp_fileds.Text = "Fields:";
            // 
            // btn_kill
            // 
            this.btn_kill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kill.Location = new System.Drawing.Point(415, 316);
            this.btn_kill.Name = "btn_kill";
            this.btn_kill.Size = new System.Drawing.Size(69, 64);
            this.btn_kill.TabIndex = 14;
            this.btn_kill.Text = "Step 6. Rel.info";
            this.btn_kill.UseVisualStyleBackColor = true;
            this.btn_kill.Click += new System.EventHandler(this.btn_kill_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 386);
            this.Controls.Add(this.btn_kill);
            this.Controls.Add(this.grp_fileds);
            this.Controls.Add(this.grp_control);
            this.Controls.Add(this.grp_conf);
            this.Controls.Add(this.grp_auth);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(700, 425);
            this.MinimumSize = new System.Drawing.Size(700, 425);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VK.Dump()";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.grp_auth.ResumeLayout(false);
            this.grp_auth.PerformLayout();
            this.grp_conf.ResumeLayout(false);
            this.grp_conf.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_threads)).EndInit();
            this.grp_control.ResumeLayout(false);
            this.grp_control.PerformLayout();
            this.grp_fileds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_auth;
        private System.Windows.Forms.Button btn_fin_auth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.GroupBox grp_conf;
        private System.Windows.Forms.TextBox txt_outpath;
        private System.Windows.Forms.NumericUpDown nud_threads;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grp_control;
        private System.Windows.Forms.Label lbl_state;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_run;
        private System.Windows.Forms.Label lbl_traf;
        private System.Windows.Forms.Label lbl_profiles_loaded;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_end;
        private System.Windows.Forms.NumericUpDown nud_start;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_volume;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox lst_fields;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.GroupBox grp_fileds;
        private System.Windows.Forms.Button btn_kill;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.LinkLabel btn_clear;
    }
}

