namespace VK_load {
    partial class Form1 {
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
            this.grp_auth = new System.Windows.Forms.GroupBox();
            this.btn_fin_auth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_auth = new System.Windows.Forms.Button();
            this.grp_conf = new System.Windows.Forms.GroupBox();
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
            this.lbl_sign = new System.Windows.Forms.Label();
            this.lbl_token = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_state = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.lbl_traf = new System.Windows.Forms.Label();
            this.lbl_profiles_loaded = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lst_fields = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grp_auth.SuspendLayout();
            this.grp_conf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_threads)).BeginInit();
            this.grp_control.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_auth
            // 
            this.grp_auth.Controls.Add(this.btn_fin_auth);
            this.grp_auth.Controls.Add(this.label2);
            this.grp_auth.Controls.Add(this.txt_token);
            this.grp_auth.Controls.Add(this.label1);
            this.grp_auth.Controls.Add(this.btn_auth);
            this.grp_auth.Location = new System.Drawing.Point(6, 5);
            this.grp_auth.Name = "grp_auth";
            this.grp_auth.Size = new System.Drawing.Size(572, 109);
            this.grp_auth.TabIndex = 0;
            this.grp_auth.TabStop = false;
            this.grp_auth.Text = "Auth";
            this.grp_auth.Enter += new System.EventHandler(this.grp_auth_Enter);
            // 
            // btn_fin_auth
            // 
            this.btn_fin_auth.Location = new System.Drawing.Point(438, 21);
            this.btn_fin_auth.Name = "btn_fin_auth";
            this.btn_fin_auth.Size = new System.Drawing.Size(98, 46);
            this.btn_fin_auth.TabIndex = 4;
            this.btn_fin_auth.Text = "Finish auth";
            this.btn_fin_auth.UseVisualStyleBackColor = true;
            this.btn_fin_auth.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Paste url from adress bar after auth";
            // 
            // txt_token
            // 
            this.txt_token.Location = new System.Drawing.Point(145, 71);
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(391, 22);
            this.txt_token.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(97, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "→";
            // 
            // btn_auth
            // 
            this.btn_auth.Location = new System.Drawing.Point(16, 20);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(75, 73);
            this.btn_auth.TabIndex = 0;
            this.btn_auth.Text = "Auth!";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_conf
            // 
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
            this.grp_conf.Location = new System.Drawing.Point(6, 138);
            this.grp_conf.Name = "grp_conf";
            this.grp_conf.Size = new System.Drawing.Size(572, 113);
            this.grp_conf.TabIndex = 1;
            this.grp_conf.TabStop = false;
            this.grp_conf.Text = "Configure";
            this.grp_conf.Enter += new System.EventHandler(this.grp_conf_Enter);
            // 
            // nud_volume
            // 
            this.nud_volume.Location = new System.Drawing.Point(447, 69);
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
            this.nud_volume.Size = new System.Drawing.Size(89, 22);
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
            this.label12.Location = new System.Drawing.Point(447, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Volume size";
            // 
            // nud_end
            // 
            this.nud_end.Location = new System.Drawing.Point(308, 71);
            this.nud_end.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_end.Name = "nud_end";
            this.nud_end.Size = new System.Drawing.Size(88, 22);
            this.nud_end.TabIndex = 7;
            this.nud_end.Value = new decimal(new int[] {
            228402285,
            0,
            0,
            0});
            // 
            // nud_start
            // 
            this.nud_start.Location = new System.Drawing.Point(308, 29);
            this.nud_start.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_start.Name = "nud_start";
            this.nud_start.Size = new System.Drawing.Size(88, 22);
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
            this.label11.Location = new System.Drawing.Point(240, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "End";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(240, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Start";
            // 
            // txt_outpath
            // 
            this.txt_outpath.Location = new System.Drawing.Point(103, 71);
            this.txt_outpath.Name = "txt_outpath";
            this.txt_outpath.Size = new System.Drawing.Size(123, 22);
            this.txt_outpath.TabIndex = 3;
            // 
            // nud_threads
            // 
            this.nud_threads.Location = new System.Drawing.Point(103, 27);
            this.nud_threads.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_threads.Name = "nud_threads";
            this.nud_threads.Size = new System.Drawing.Size(123, 22);
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
            this.label4.Location = new System.Drawing.Point(10, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Output path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Thread count";
            // 
            // grp_control
            // 
            this.grp_control.Controls.Add(this.lbl_sign);
            this.grp_control.Controls.Add(this.lbl_token);
            this.grp_control.Controls.Add(this.label8);
            this.grp_control.Controls.Add(this.label7);
            this.grp_control.Controls.Add(this.lbl_state);
            this.grp_control.Controls.Add(this.label9);
            this.grp_control.Controls.Add(this.btn_run);
            this.grp_control.Controls.Add(this.lbl_traf);
            this.grp_control.Controls.Add(this.lbl_profiles_loaded);
            this.grp_control.Controls.Add(this.label6);
            this.grp_control.Controls.Add(this.label5);
            this.grp_control.Enabled = false;
            this.grp_control.Location = new System.Drawing.Point(6, 270);
            this.grp_control.Name = "grp_control";
            this.grp_control.Size = new System.Drawing.Size(572, 188);
            this.grp_control.TabIndex = 2;
            this.grp_control.TabStop = false;
            this.grp_control.Text = "Control";
            // 
            // lbl_sign
            // 
            this.lbl_sign.AutoSize = true;
            this.lbl_sign.Location = new System.Drawing.Point(98, 164);
            this.lbl_sign.Name = "lbl_sign";
            this.lbl_sign.Size = new System.Drawing.Size(65, 13);
            this.lbl_sign.TabIndex = 10;
            this.lbl_sign.Text = "Not loaded";
            // 
            // lbl_token
            // 
            this.lbl_token.AutoSize = true;
            this.lbl_token.Location = new System.Drawing.Point(98, 136);
            this.lbl_token.Name = "lbl_token";
            this.lbl_token.Size = new System.Drawing.Size(65, 13);
            this.lbl_token.TabIndex = 9;
            this.lbl_token.Text = "Not loaded";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Sign";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Token";
            // 
            // lbl_state
            // 
            this.lbl_state.AutoSize = true;
            this.lbl_state.Location = new System.Drawing.Point(273, 88);
            this.lbl_state.Name = "lbl_state";
            this.lbl_state.Size = new System.Drawing.Size(52, 13);
            this.lbl_state.TabIndex = 6;
            this.lbl_state.Text = "Stand by";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "State";
            // 
            // btn_run
            // 
            this.btn_run.Location = new System.Drawing.Point(16, 25);
            this.btn_run.Name = "btn_run";
            this.btn_run.Size = new System.Drawing.Size(143, 76);
            this.btn_run.TabIndex = 4;
            this.btn_run.Text = "Run";
            this.btn_run.UseVisualStyleBackColor = true;
            this.btn_run.Click += new System.EventHandler(this.btn_run_Click);
            // 
            // lbl_traf
            // 
            this.lbl_traf.AutoSize = true;
            this.lbl_traf.Location = new System.Drawing.Point(273, 58);
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
            this.label6.Location = new System.Drawing.Point(188, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Traffic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Profiles loaded";
            // 
            // lst_fields
            // 
            this.lst_fields.FormattingEnabled = true;
            this.lst_fields.Items.AddRange(new object[] {
            "about",
            "activity",
            "bdate",
            "books",
            "can_post",
            "can_see_all_posts",
            "can_see_audio",
            "can_write_private_message",
            "city",
            "connections",
            "contacts",
            "counters",
            "country",
            "education",
            "first_name",
            "games",
            "has_mobile",
            "interests",
            "last_name",
            "last_seen",
            "movies",
            "nickname",
            "online",
            "photo_100",
            "photo_200",
            "photo_200_orig",
            "photo_400_orig",
            "photo_50",
            "photo_max",
            "photo_max_orig",
            "rating",
            "relation",
            "relatives",
            "schools",
            "screen_name",
            "sex",
            "status",
            "timezone",
            "tv",
            "uid",
            "universities",
            "verified",
            "wall_comments"});
            this.lst_fields.Location = new System.Drawing.Point(585, 51);
            this.lst_fields.Name = "lst_fields";
            this.lst_fields.Size = new System.Drawing.Size(175, 395);
            this.lst_fields.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(580, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Fields";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "None";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(703, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 470);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lst_fields);
            this.Controls.Add(this.grp_control);
            this.Controls.Add(this.grp_conf);
            this.Controls.Add(this.grp_auth);
            this.Name = "Form1";
            this.Text = "VK.Dump()";
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lbl_sign;
        private System.Windows.Forms.Label lbl_token;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_end;
        private System.Windows.Forms.NumericUpDown nud_start;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nud_volume;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox lst_fields;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

