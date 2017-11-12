using System;
using System.Linq;
using kasthack.vksharp.DataTypes.Enums;

namespace kasthack.OSP {
    partial class FrmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.grp_auth = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.LinkLabel();
            this.btn_fin_auth = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_token = new System.Windows.Forms.TextBox();
            this.btn_auth = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grp_conf = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_threads = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.chkDelay = new System.Windows.Forms.CheckBox();
            this.nud_volume = new System.Windows.Forms.NumericUpDown();
            this.chkExecute = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkUseCounter = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSourcefile = new System.Windows.Forms.TextBox();
            this.nud_start = new System.Windows.Forms.NumericUpDown();
            this.chkLoadFromFile = new System.Windows.Forms.RadioButton();
            this.nud_end = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_outpath = new System.Windows.Forms.TextBox();
            this.btn_folder = new System.Windows.Forms.Button();
            this.chkGZip = new System.Windows.Forms.CheckBox();
            this.grp_control = new System.Windows.Forms.GroupBox();
            this.btn_kill = new System.Windows.Forms.Button();
            this.lblTotalProfiles = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.progressbar = new System.Windows.Forms.ProgressBar();
            this.lbl_state = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_run = new System.Windows.Forms.Button();
            this.lbl_traf = new System.Windows.Forms.Label();
            this.lbl_profiles_loaded = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstFields = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grp_fileds = new System.Windows.Forms.GroupBox();
            this.ofdSourceFile = new System.Windows.Forms.OpenFileDialog();
            this.chkSubdirs = new System.Windows.Forms.CheckBox();
            this.grp_auth.SuspendLayout();
            this.grp_conf.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_threads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grp_control.SuspendLayout();
            this.grp_fileds.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_auth
            // 
            this.grp_auth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_auth.Controls.Add(this.btn_clear);
            this.grp_auth.Controls.Add(this.btn_fin_auth);
            this.grp_auth.Controls.Add(this.label2);
            this.grp_auth.Controls.Add(this.txt_token);
            this.grp_auth.Controls.Add(this.btn_auth);
            this.grp_auth.Controls.Add(this.label1);
            this.grp_auth.Location = new System.Drawing.Point(6, 5);
            this.grp_auth.Name = "grp_auth";
            this.grp_auth.Size = new System.Drawing.Size(480, 74);
            this.grp_auth.TabIndex = 0;
            this.grp_auth.TabStop = false;
            this.grp_auth.Text = "VK Auth:";
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_clear.AutoSize = true;
            this.btn_clear.Location = new System.Drawing.Point(344, 22);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(36, 13);
            this.btn_clear.TabIndex = 5;
            this.btn_clear.TabStop = true;
            this.btn_clear.Text = "[clear]";
            this.btn_clear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ResetToken);
            // 
            // btn_fin_auth
            // 
            this.btn_fin_auth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fin_auth.Location = new System.Drawing.Point(385, 19);
            this.btn_fin_auth.Name = "btn_fin_auth";
            this.btn_fin_auth.Size = new System.Drawing.Size(89, 39);
            this.btn_fin_auth.TabIndex = 4;
            this.btn_fin_auth.Text = "Step 3. Login\r\n(optional)";
            this.btn_fin_auth.UseVisualStyleBackColor = true;
            this.btn_fin_auth.Click += new System.EventHandler(this.CompleteAuth);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Step2. Paste url from adress bar after auth";
            // 
            // txt_token
            // 
            this.txt_token.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_token.Location = new System.Drawing.Point(102, 38);
            this.txt_token.Name = "txt_token";
            this.txt_token.Size = new System.Drawing.Size(277, 20);
            this.txt_token.TabIndex = 2;
            // 
            // btn_auth
            // 
            this.btn_auth.Location = new System.Drawing.Point(6, 19);
            this.btn_auth.Name = "btn_auth";
            this.btn_auth.Size = new System.Drawing.Size(62, 39);
            this.btn_auth.TabIndex = 0;
            this.btn_auth.Text = "Step  1. Auth";
            this.btn_auth.UseVisualStyleBackColor = true;
            this.btn_auth.Click += new System.EventHandler(this.OpenOAuth);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "→";
            // 
            // grp_conf
            // 
            this.grp_conf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_conf.Controls.Add(this.groupBox3);
            this.grp_conf.Controls.Add(this.groupBox2);
            this.grp_conf.Controls.Add(this.groupBox1);
            this.grp_conf.Enabled = false;
            this.grp_conf.Location = new System.Drawing.Point(7, 85);
            this.grp_conf.Name = "grp_conf";
            this.grp_conf.Size = new System.Drawing.Size(479, 297);
            this.grp_conf.TabIndex = 1;
            this.grp_conf.TabStop = false;
            this.grp_conf.Text = "Step 4. Configure:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.nudDelay);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.nud_threads);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.chkDelay);
            this.groupBox3.Controls.Add(this.nud_volume);
            this.groupBox3.Controls.Add(this.chkExecute);
            this.groupBox3.Location = new System.Drawing.Point(5, 106);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(463, 76);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Requests:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "ms";
            // 
            // nudDelay
            // 
            this.nudDelay.Location = new System.Drawing.Point(153, 40);
            this.nudDelay.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.nudDelay.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudDelay.Name = "nudDelay";
            this.nudDelay.Size = new System.Drawing.Size(120, 20);
            this.nudDelay.TabIndex = 14;
            this.nudDelay.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Threads";
            // 
            // nud_threads
            // 
            this.nud_threads.Location = new System.Drawing.Point(70, 15);
            this.nud_threads.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_threads.Name = "nud_threads";
            this.nud_threads.Size = new System.Drawing.Size(88, 20);
            this.nud_threads.TabIndex = 2;
            this.nud_threads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Volume size";
            // 
            // chkDelay
            // 
            this.chkDelay.AutoSize = true;
            this.chkDelay.Location = new System.Drawing.Point(12, 41);
            this.chkDelay.Name = "chkDelay";
            this.chkDelay.Size = new System.Drawing.Size(134, 17);
            this.chkDelay.TabIndex = 13;
            this.chkDelay.Text = "Delay betwen requests";
            this.chkDelay.UseVisualStyleBackColor = true;
            this.chkDelay.CheckedChanged += new System.EventHandler(this.chkDelay_CheckedChanged);
            // 
            // nud_volume
            // 
            this.nud_volume.Location = new System.Drawing.Point(232, 14);
            this.nud_volume.Maximum = new decimal(new int[] {
            25000,
            0,
            0,
            0});
            this.nud_volume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_volume.Name = "nud_volume";
            this.nud_volume.Size = new System.Drawing.Size(104, 20);
            this.nud_volume.TabIndex = 9;
            this.nud_volume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkExecute
            // 
            this.chkExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkExecute.AutoSize = true;
            this.chkExecute.Location = new System.Drawing.Point(371, 15);
            this.chkExecute.Name = "chkExecute";
            this.chkExecute.Size = new System.Drawing.Size(86, 17);
            this.chkExecute.TabIndex = 12;
            this.chkExecute.Text = "Use execute";
            this.chkExecute.UseVisualStyleBackColor = true;
            this.chkExecute.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkUseCounter);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtSourcefile);
            this.groupBox2.Controls.Add(this.nud_start);
            this.groupBox2.Controls.Add(this.chkLoadFromFile);
            this.groupBox2.Controls.Add(this.nud_end);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 81);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data:";
            // 
            // chkUseCounter
            // 
            this.chkUseCounter.AutoSize = true;
            this.chkUseCounter.Checked = true;
            this.chkUseCounter.Location = new System.Drawing.Point(9, 19);
            this.chkUseCounter.Name = "chkUseCounter";
            this.chkUseCounter.Size = new System.Drawing.Size(83, 17);
            this.chkUseCounter.TabIndex = 14;
            this.chkUseCounter.TabStop = true;
            this.chkUseCounter.Text = "Use counter";
            this.chkUseCounter.UseVisualStyleBackColor = true;
            this.chkUseCounter.CheckedChanged += new System.EventHandler(this.chkUseCounter_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(126, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Start";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(426, 42);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 20);
            this.button3.TabIndex = 17;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(278, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "End";
            // 
            // txtSourcefile
            // 
            this.txtSourcefile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourcefile.Enabled = false;
            this.txtSourcefile.Location = new System.Drawing.Point(129, 42);
            this.txtSourcefile.Name = "txtSourcefile";
            this.txtSourcefile.Size = new System.Drawing.Size(291, 20);
            this.txtSourcefile.TabIndex = 16;
            // 
            // nud_start
            // 
            this.nud_start.Location = new System.Drawing.Point(184, 17);
            this.nud_start.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_start.Name = "nud_start";
            this.nud_start.Size = new System.Drawing.Size(88, 20);
            this.nud_start.TabIndex = 6;
            this.nud_start.ValueChanged += new System.EventHandler(this.nud_start_ValueChanged);
            // 
            // chkLoadFromFile
            // 
            this.chkLoadFromFile.AutoSize = true;
            this.chkLoadFromFile.Location = new System.Drawing.Point(9, 42);
            this.chkLoadFromFile.Name = "chkLoadFromFile";
            this.chkLoadFromFile.Size = new System.Drawing.Size(104, 17);
            this.chkLoadFromFile.TabIndex = 15;
            this.chkLoadFromFile.TabStop = true;
            this.chkLoadFromFile.Text = "Load ids from file";
            this.chkLoadFromFile.UseVisualStyleBackColor = true;
            // 
            // nud_end
            // 
            this.nud_end.Location = new System.Drawing.Point(346, 16);
            this.nud_end.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nud_end.Name = "nud_end";
            this.nud_end.Size = new System.Drawing.Size(104, 20);
            this.nud_end.TabIndex = 7;
            this.nud_end.ValueChanged += new System.EventHandler(this.nud_end_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.chkSubdirs);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_outpath);
            this.groupBox1.Controls.Add(this.btn_folder);
            this.groupBox1.Controls.Add(this.chkGZip);
            this.groupBox1.Location = new System.Drawing.Point(6, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 109);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Path";
            // 
            // txt_outpath
            // 
            this.txt_outpath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_outpath.Location = new System.Drawing.Point(55, 20);
            this.txt_outpath.Name = "txt_outpath";
            this.txt_outpath.Size = new System.Drawing.Size(365, 20);
            this.txt_outpath.TabIndex = 3;
            this.txt_outpath.TextChanged += new System.EventHandler(this.txt_outpath_TextChanged);
            // 
            // btn_folder
            // 
            this.btn_folder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_folder.Location = new System.Drawing.Point(426, 19);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(24, 20);
            this.btn_folder.TabIndex = 10;
            this.btn_folder.Text = "...";
            this.btn_folder.UseVisualStyleBackColor = true;
            this.btn_folder.Click += new System.EventHandler(this.Browse);
            // 
            // chkGZip
            // 
            this.chkGZip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkGZip.AutoSize = true;
            this.chkGZip.Location = new System.Drawing.Point(370, 60);
            this.chkGZip.Name = "chkGZip";
            this.chkGZip.Size = new System.Drawing.Size(73, 17);
            this.chkGZip.TabIndex = 11;
            this.chkGZip.Text = "GZip data";
            this.chkGZip.UseVisualStyleBackColor = true;
            // 
            // grp_control
            // 
            this.grp_control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_control.Controls.Add(this.btn_kill);
            this.grp_control.Controls.Add(this.lblTotalProfiles);
            this.grp_control.Controls.Add(this.label7);
            this.grp_control.Controls.Add(this.progressbar);
            this.grp_control.Controls.Add(this.lbl_state);
            this.grp_control.Controls.Add(this.label9);
            this.grp_control.Controls.Add(this.btn_run);
            this.grp_control.Controls.Add(this.lbl_traf);
            this.grp_control.Controls.Add(this.lbl_profiles_loaded);
            this.grp_control.Controls.Add(this.label6);
            this.grp_control.Controls.Add(this.label5);
            this.grp_control.Enabled = false;
            this.grp_control.Location = new System.Drawing.Point(6, 388);
            this.grp_control.Name = "grp_control";
            this.grp_control.Size = new System.Drawing.Size(480, 121);
            this.grp_control.TabIndex = 2;
            this.grp_control.TabStop = false;
            this.grp_control.Text = "Control:";
            // 
            // btn_kill
            // 
            this.btn_kill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kill.Location = new System.Drawing.Point(345, 55);
            this.btn_kill.Name = "btn_kill";
            this.btn_kill.Size = new System.Drawing.Size(123, 31);
            this.btn_kill.TabIndex = 14;
            this.btn_kill.Text = "Step 6. About";
            this.btn_kill.UseVisualStyleBackColor = true;
            this.btn_kill.Click += new System.EventHandler(this.AboutBox);
            // 
            // lblTotalProfiles
            // 
            this.lblTotalProfiles.AutoSize = true;
            this.lblTotalProfiles.Location = new System.Drawing.Point(382, 25);
            this.lblTotalProfiles.Name = "lblTotalProfiles";
            this.lblTotalProfiles.Size = new System.Drawing.Size(13, 13);
            this.lblTotalProfiles.TabIndex = 9;
            this.lblTotalProfiles.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total:";
            // 
            // progressbar
            // 
            this.progressbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressbar.ForeColor = System.Drawing.Color.DodgerBlue;
            this.progressbar.Location = new System.Drawing.Point(16, 92);
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(452, 20);
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
            this.btn_run.Click += new System.EventHandler(this.Run);
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
            // lstFields
            // 
            this.lstFields.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFields.FormattingEnabled = true;
            this.lstFields.Location = new System.Drawing.Point(6, 48);
            this.lstFields.Name = "lstFields";
            this.lstFields.Size = new System.Drawing.Size(175, 439);
            this.lstFields.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "None";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.UncheckAllFields);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(106, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CheckAllFields);
            // 
            // grp_fileds
            // 
            this.grp_fileds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_fileds.Controls.Add(this.button1);
            this.grp_fileds.Controls.Add(this.button2);
            this.grp_fileds.Controls.Add(this.lstFields);
            this.grp_fileds.Enabled = false;
            this.grp_fileds.Location = new System.Drawing.Point(492, 5);
            this.grp_fileds.Name = "grp_fileds";
            this.grp_fileds.Size = new System.Drawing.Size(187, 504);
            this.grp_fileds.TabIndex = 13;
            this.grp_fileds.TabStop = false;
            this.grp_fileds.Text = "Fields:";
            // 
            // chkSubdirs
            // 
            this.chkSubdirs.AutoSize = true;
            this.chkSubdirs.Location = new System.Drawing.Point(210, 60);
            this.chkSubdirs.Name = "chkSubdirs";
            this.chkSubdirs.Size = new System.Drawing.Size(125, 17);
            this.chkSubdirs.TabIndex = 19;
            this.chkSubdirs.Text = "Create subdirectories";
            this.chkSubdirs.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 521);
            this.Controls.Add(this.grp_fileds);
            this.Controls.Add(this.grp_control);
            this.Controls.Add(this.grp_conf);
            this.Controls.Add(this.grp_auth);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(702, 513);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OSP by kasthack";
            this.grp_auth.ResumeLayout(false);
            this.grp_auth.PerformLayout();
            this.grp_conf.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_threads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_volume)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_start)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_end)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grp_control.ResumeLayout(false);
            this.grp_control.PerformLayout();
            this.grp_fileds.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UserFields[] _fields = ( (UserFields[]) Enum.GetValues( typeof( UserFields ) ) ).Where( a => a != UserFields.Anything && a != UserFields.Everything ).ToArray();
        private System.Windows.Forms.GroupBox grp_auth;
        private System.Windows.Forms.Button btn_fin_auth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_token;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_auth;
        private System.Windows.Forms.GroupBox grp_conf;
        private System.Windows.Forms.TextBox txt_outpath;
        private System.Windows.Forms.NumericUpDown nud_threads;
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
        private System.Windows.Forms.CheckedListBox lstFields;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.GroupBox grp_fileds;
        private System.Windows.Forms.Button btn_kill;
        private System.Windows.Forms.ProgressBar progressbar;
        private System.Windows.Forms.LinkLabel btn_clear;
        private System.Windows.Forms.CheckBox chkGZip;
        private System.Windows.Forms.CheckBox chkExecute;
        private System.Windows.Forms.CheckBox chkDelay;
        private System.Windows.Forms.Label lblTotalProfiles;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtSourcefile;
        private System.Windows.Forms.RadioButton chkLoadFromFile;
        private System.Windows.Forms.RadioButton chkUseCounter;
        private System.Windows.Forms.OpenFileDialog ofdSourceFile;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudDelay;
        private System.Windows.Forms.CheckBox chkSubdirs;
    }
}

