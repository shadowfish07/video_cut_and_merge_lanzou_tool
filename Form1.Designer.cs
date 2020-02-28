namespace video_accurate_cut_and_merge
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chk_openLog_cut = new System.Windows.Forms.CheckBox();
            this.lbl_cut_num_period = new System.Windows.Forms.Label();
            this.lbl_cut_num_list = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pgb_cut_list = new System.Windows.Forms.ProgressBar();
            this.pgb_cut_period = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cut_extraName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_cut_autoCreateFolder = new System.Windows.Forms.CheckBox();
            this.lbl_statu = new System.Windows.Forms.Label();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btn_cut = new System.Windows.Forms.Button();
            this.lbl_each_period_length = new System.Windows.Forms.Label();
            this.txt_period_length = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_outPath_cut = new System.Windows.Forms.TextBox();
            this.lb_cut = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chk_openlog_merge = new System.Windows.Forms.CheckBox();
            this.txt_extraName_new = new System.Windows.Forms.TextBox();
            this.txt_extraName_old = new System.Windows.Forms.TextBox();
            this.chk_extraName_repair = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pgb_period_merge = new System.Windows.Forms.ProgressBar();
            this.label18 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chk_merge_deleteSource = new System.Windows.Forms.CheckBox();
            this.lbl_statue_2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_outpath_merge = new System.Windows.Forms.TextBox();
            this.btn_merge = new System.Windows.Forms.Button();
            this.btn_merge_autoadd = new System.Windows.Forms.Button();
            this.lb_merge = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_success_cut = new System.Windows.Forms.Label();
            this.lbl_success_merge = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_success_cut);
            this.tabPage1.Controls.Add(this.chk_openLog_cut);
            this.tabPage1.Controls.Add(this.lbl_cut_num_period);
            this.tabPage1.Controls.Add(this.lbl_cut_num_list);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.pgb_cut_list);
            this.tabPage1.Controls.Add(this.pgb_cut_period);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.txt_cut_extraName);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.chk_cut_autoCreateFolder);
            this.tabPage1.Controls.Add(this.lbl_statu);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.btn_cut);
            this.tabPage1.Controls.Add(this.lbl_each_period_length);
            this.tabPage1.Controls.Add(this.txt_period_length);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_outPath_cut);
            this.tabPage1.Controls.Add(this.lb_cut);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 425);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "分割";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chk_openLog_cut
            // 
            this.chk_openLog_cut.AutoSize = true;
            this.chk_openLog_cut.Checked = true;
            this.chk_openLog_cut.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_openLog_cut.Location = new System.Drawing.Point(817, 284);
            this.chk_openLog_cut.Name = "chk_openLog_cut";
            this.chk_openLog_cut.Size = new System.Drawing.Size(110, 19);
            this.chk_openLog_cut.TabIndex = 42;
            this.chk_openLog_cut.Text = "打开log窗口";
            this.chk_openLog_cut.UseVisualStyleBackColor = true;
            this.chk_openLog_cut.Visible = false;
            this.chk_openLog_cut.CheckedChanged += new System.EventHandler(this.chk_openLog_cut_CheckedChanged);
            // 
            // lbl_cut_num_period
            // 
            this.lbl_cut_num_period.Location = new System.Drawing.Point(629, 335);
            this.lbl_cut_num_period.Name = "lbl_cut_num_period";
            this.lbl_cut_num_period.Size = new System.Drawing.Size(64, 15);
            this.lbl_cut_num_period.TabIndex = 41;
            this.lbl_cut_num_period.Text = "0/0";
            this.lbl_cut_num_period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cut_num_list
            // 
            this.lbl_cut_num_list.Location = new System.Drawing.Point(629, 291);
            this.lbl_cut_num_list.Name = "lbl_cut_num_list";
            this.lbl_cut_num_list.Size = new System.Drawing.Size(64, 15);
            this.lbl_cut_num_list.TabIndex = 40;
            this.lbl_cut_num_list.Text = "0/0";
            this.lbl_cut_num_list.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(590, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 39;
            this.label13.Text = "列表";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(590, 335);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 15);
            this.label12.TabIndex = 38;
            this.label12.Text = "分割";
            // 
            // pgb_cut_list
            // 
            this.pgb_cut_list.Location = new System.Drawing.Point(593, 309);
            this.pgb_cut_list.Name = "pgb_cut_list";
            this.pgb_cut_list.Size = new System.Drawing.Size(334, 23);
            this.pgb_cut_list.TabIndex = 37;
            // 
            // pgb_cut_period
            // 
            this.pgb_cut_period.Location = new System.Drawing.Point(593, 352);
            this.pgb_cut_period.Name = "pgb_cut_period";
            this.pgb_cut_period.Size = new System.Drawing.Size(334, 23);
            this.pgb_cut_period.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 7.260504F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(814, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "为空则不进行修改";
            // 
            // txt_cut_extraName
            // 
            this.txt_cut_extraName.Location = new System.Drawing.Point(697, 148);
            this.txt_cut_extraName.Name = "txt_cut_extraName";
            this.txt_cut_extraName.Size = new System.Drawing.Size(230, 25);
            this.txt_cut_extraName.TabIndex = 34;
            this.txt_cut_extraName.Text = "mkv";
            this.txt_cut_extraName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(584, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 33;
            this.label9.Text = "修改后缀名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 7.260504F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(724, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "为空为程序目录,为@为源文件目录";
            // 
            // chk_cut_autoCreateFolder
            // 
            this.chk_cut_autoCreateFolder.AutoSize = true;
            this.chk_cut_autoCreateFolder.Checked = true;
            this.chk_cut_autoCreateFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_cut_autoCreateFolder.Location = new System.Drawing.Point(803, 59);
            this.chk_cut_autoCreateFolder.Name = "chk_cut_autoCreateFolder";
            this.chk_cut_autoCreateFolder.Size = new System.Drawing.Size(131, 19);
            this.chk_cut_autoCreateFolder.TabIndex = 31;
            this.chk_cut_autoCreateFolder.Text = "自动生成文件夹";
            this.chk_cut_autoCreateFolder.UseVisualStyleBackColor = true;
            // 
            // lbl_statu
            // 
            this.lbl_statu.AutoSize = true;
            this.lbl_statu.Location = new System.Drawing.Point(753, 352);
            this.lbl_statu.Name = "lbl_statu";
            this.lbl_statu.Size = new System.Drawing.Size(0, 15);
            this.lbl_statu.TabIndex = 30;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(520, 6);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 21);
            this.button9.TabIndex = 29;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(552, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(26, 21);
            this.button5.TabIndex = 28;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_cut
            // 
            this.btn_cut.Location = new System.Drawing.Point(680, 380);
            this.btn_cut.Name = "btn_cut";
            this.btn_cut.Size = new System.Drawing.Size(178, 34);
            this.btn_cut.TabIndex = 27;
            this.btn_cut.Text = "开始分割";
            this.btn_cut.UseVisualStyleBackColor = true;
            this.btn_cut.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_each_period_length
            // 
            this.lbl_each_period_length.AutoSize = true;
            this.lbl_each_period_length.Location = new System.Drawing.Point(856, 87);
            this.lbl_each_period_length.Name = "lbl_each_period_length";
            this.lbl_each_period_length.Size = new System.Drawing.Size(71, 15);
            this.lbl_each_period_length.TabIndex = 26;
            this.lbl_each_period_length.Text = "00:00:00";
            // 
            // txt_period_length
            // 
            this.txt_period_length.Location = new System.Drawing.Point(697, 84);
            this.txt_period_length.Name = "txt_period_length";
            this.txt_period_length.Size = new System.Drawing.Size(106, 25);
            this.txt_period_length.TabIndex = 25;
            this.txt_period_length.Text = "1000";
            this.txt_period_length.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_period_length.TextChanged += new System.EventHandler(this.txt_period_length_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "每段长度(s)";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(648, 28);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(45, 24);
            this.button7.TabIndex = 23;
            this.button7.Text = "...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(584, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "输出路径";
            // 
            // txt_outPath_cut
            // 
            this.txt_outPath_cut.Location = new System.Drawing.Point(699, 28);
            this.txt_outPath_cut.Name = "txt_outPath_cut";
            this.txt_outPath_cut.Size = new System.Drawing.Size(228, 25);
            this.txt_outPath_cut.TabIndex = 21;
            // 
            // lb_cut
            // 
            this.lb_cut.AllowDrop = true;
            this.lb_cut.FormattingEnabled = true;
            this.lb_cut.ItemHeight = 15;
            this.lb_cut.Location = new System.Drawing.Point(6, 35);
            this.lb_cut.Name = "lb_cut";
            this.lb_cut.Size = new System.Drawing.Size(572, 379);
            this.lb_cut.TabIndex = 1;
            this.lb_cut.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_cut_DragDrop);
            this.lb_cut.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_cut_DragEnter);
            this.lb_cut.DoubleClick += new System.EventHandler(this.lb_cut_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "要分割的视频文件：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.lbl_success_merge);
            this.tabPage2.Controls.Add(this.chk_openlog_merge);
            this.tabPage2.Controls.Add(this.txt_extraName_new);
            this.tabPage2.Controls.Add(this.txt_extraName_old);
            this.tabPage2.Controls.Add(this.chk_extraName_repair);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.pgb_period_merge);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.button11);
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.chk_merge_deleteSource);
            this.tabPage2.Controls.Add(this.lbl_statue_2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txt_outpath_merge);
            this.tabPage2.Controls.Add(this.btn_merge);
            this.tabPage2.Controls.Add(this.btn_merge_autoadd);
            this.tabPage2.Controls.Add(this.lb_merge);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(942, 425);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "合并";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chk_openlog_merge
            // 
            this.chk_openlog_merge.AutoSize = true;
            this.chk_openlog_merge.Checked = true;
            this.chk_openlog_merge.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_openlog_merge.Location = new System.Drawing.Point(799, 264);
            this.chk_openlog_merge.Name = "chk_openlog_merge";
            this.chk_openlog_merge.Size = new System.Drawing.Size(110, 19);
            this.chk_openlog_merge.TabIndex = 53;
            this.chk_openlog_merge.Text = "打开log窗口";
            this.chk_openlog_merge.UseVisualStyleBackColor = true;
            this.chk_openlog_merge.Visible = false;
            // 
            // txt_extraName_new
            // 
            this.txt_extraName_new.Location = new System.Drawing.Point(823, 88);
            this.txt_extraName_new.Name = "txt_extraName_new";
            this.txt_extraName_new.Size = new System.Drawing.Size(111, 25);
            this.txt_extraName_new.TabIndex = 52;
            this.txt_extraName_new.Text = "mkv";
            this.txt_extraName_new.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_extraName_old
            // 
            this.txt_extraName_old.Location = new System.Drawing.Point(622, 88);
            this.txt_extraName_old.Name = "txt_extraName_old";
            this.txt_extraName_old.Size = new System.Drawing.Size(107, 25);
            this.txt_extraName_old.TabIndex = 51;
            this.txt_extraName_old.Text = "exe";
            this.txt_extraName_old.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chk_extraName_repair
            // 
            this.chk_extraName_repair.AutoSize = true;
            this.chk_extraName_repair.Checked = true;
            this.chk_extraName_repair.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_extraName_repair.Location = new System.Drawing.Point(575, 94);
            this.chk_extraName_repair.Name = "chk_extraName_repair";
            this.chk_extraName_repair.Size = new System.Drawing.Size(41, 19);
            this.chk_extraName_repair.TabIndex = 50;
            this.chk_extraName_repair.Text = "将";
            this.chk_extraName_repair.UseVisualStyleBackColor = true;
            this.chk_extraName_repair.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(735, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 15);
            this.label14.TabIndex = 49;
            this.label14.Text = "后缀修复为";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(572, 315);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 45;
            this.label17.Text = "进度";
            // 
            // pgb_period_merge
            // 
            this.pgb_period_merge.Location = new System.Drawing.Point(575, 332);
            this.pgb_period_merge.Maximum = 1000;
            this.pgb_period_merge.Name = "pgb_period_merge";
            this.pgb_period_merge.Size = new System.Drawing.Size(334, 23);
            this.pgb_period_merge.TabIndex = 43;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(735, 332);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 15);
            this.label18.TabIndex = 42;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(433, 49);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(26, 21);
            this.button11.TabIndex = 38;
            this.button11.Text = "👇";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(465, 49);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(26, 21);
            this.button10.TabIndex = 37;
            this.button10.Text = "👆";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(497, 49);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 21);
            this.button6.TabIndex = 36;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(529, 49);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(26, 21);
            this.button8.TabIndex = 35;
            this.button8.Text = "+";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(106, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "从上到下依次序合并";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(106, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "选择一系列文件的任意一个即可";
            // 
            // chk_merge_deleteSource
            // 
            this.chk_merge_deleteSource.AutoSize = true;
            this.chk_merge_deleteSource.Checked = true;
            this.chk_merge_deleteSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_merge_deleteSource.Location = new System.Drawing.Point(793, 54);
            this.chk_merge_deleteSource.Name = "chk_merge_deleteSource";
            this.chk_merge_deleteSource.Size = new System.Drawing.Size(146, 19);
            this.chk_merge_deleteSource.TabIndex = 28;
            this.chk_merge_deleteSource.Text = "合并后删除源文件";
            this.chk_merge_deleteSource.UseVisualStyleBackColor = true;
            // 
            // lbl_statue_2
            // 
            this.lbl_statue_2.AutoSize = true;
            this.lbl_statue_2.Location = new System.Drawing.Point(785, 354);
            this.lbl_statue_2.Name = "lbl_statue_2";
            this.lbl_statue_2.Size = new System.Drawing.Size(0, 15);
            this.lbl_statue_2.TabIndex = 27;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(645, 23);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(45, 24);
            this.button4.TabIndex = 26;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(572, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "输出路径";
            // 
            // txt_outpath_merge
            // 
            this.txt_outpath_merge.Location = new System.Drawing.Point(696, 23);
            this.txt_outpath_merge.Name = "txt_outpath_merge";
            this.txt_outpath_merge.Size = new System.Drawing.Size(238, 25);
            this.txt_outpath_merge.TabIndex = 24;
            // 
            // btn_merge
            // 
            this.btn_merge.Location = new System.Drawing.Point(667, 372);
            this.btn_merge.Name = "btn_merge";
            this.btn_merge.Size = new System.Drawing.Size(165, 31);
            this.btn_merge.TabIndex = 5;
            this.btn_merge.Text = "开始合并";
            this.btn_merge.UseVisualStyleBackColor = true;
            this.btn_merge.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_merge_autoadd
            // 
            this.btn_merge_autoadd.Location = new System.Drawing.Point(6, 14);
            this.btn_merge_autoadd.Name = "btn_merge_autoadd";
            this.btn_merge_autoadd.Size = new System.Drawing.Size(94, 31);
            this.btn_merge_autoadd.TabIndex = 4;
            this.btn_merge_autoadd.Text = "快速导入";
            this.btn_merge_autoadd.UseVisualStyleBackColor = true;
            this.btn_merge_autoadd.Click += new System.EventHandler(this.button2_Click);
            // 
            // lb_merge
            // 
            this.lb_merge.AllowDrop = true;
            this.lb_merge.FormattingEnabled = true;
            this.lb_merge.ItemHeight = 15;
            this.lb_merge.Location = new System.Drawing.Point(6, 73);
            this.lb_merge.Name = "lb_merge";
            this.lb_merge.Size = new System.Drawing.Size(549, 349);
            this.lb_merge.Sorted = true;
            this.lb_merge.TabIndex = 3;
            this.lb_merge.SelectedIndexChanged += new System.EventHandler(this.lb_merge_SelectedIndexChanged);
            this.lb_merge.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb_merge_DragDrop);
            this.lb_merge.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb_merge_DragEnter);
            this.lb_merge.DoubleClick += new System.EventHandler(this.lb_merge_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "要合并的文件：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 0;
            // 
            // lbl_success_cut
            // 
            this.lbl_success_cut.AutoSize = true;
            this.lbl_success_cut.Font = new System.Drawing.Font("宋体", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_success_cut.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_success_cut.Location = new System.Drawing.Point(740, 291);
            this.lbl_success_cut.Name = "lbl_success_cut";
            this.lbl_success_cut.Size = new System.Drawing.Size(79, 15);
            this.lbl_success_cut.TabIndex = 43;
            this.lbl_success_cut.Text = "Success!";
            this.lbl_success_cut.Visible = false;
            // 
            // lbl_success_merge
            // 
            this.lbl_success_merge.AutoSize = true;
            this.lbl_success_merge.Font = new System.Drawing.Font("宋体", 9.07563F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_success_merge.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_success_merge.Location = new System.Drawing.Point(706, 314);
            this.lbl_success_merge.Name = "lbl_success_merge";
            this.lbl_success_merge.Size = new System.Drawing.Size(79, 15);
            this.lbl_success_merge.TabIndex = 54;
            this.lbl_success_merge.Text = "Success!";
            this.lbl_success_merge.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 7.260504F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(731, 7);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(203, 13);
            this.label15.TabIndex = 55;
            this.label15.Text = "为空为程序目录,为@为源文件目录";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 478);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btn_cut;
        private System.Windows.Forms.Label lbl_each_period_length;
        private System.Windows.Forms.TextBox txt_period_length;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_outPath_cut;
        private System.Windows.Forms.ListBox lb_cut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_statu;
        private System.Windows.Forms.Button btn_merge_autoadd;
        private System.Windows.Forms.ListBox lb_merge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_merge;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_outpath_merge;
        private System.Windows.Forms.Label lbl_statue_2;
        private System.Windows.Forms.CheckBox chk_merge_deleteSource;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_cut_autoCreateFolder;
        private System.Windows.Forms.Label lbl_cut_num_period;
        private System.Windows.Forms.Label lbl_cut_num_list;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar pgb_cut_list;
        private System.Windows.Forms.ProgressBar pgb_cut_period;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_cut_extraName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ProgressBar pgb_period_merge;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_extraName_new;
        private System.Windows.Forms.TextBox txt_extraName_old;
        private System.Windows.Forms.CheckBox chk_extraName_repair;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chk_openLog_cut;
        private System.Windows.Forms.CheckBox chk_openlog_merge;
        private System.Windows.Forms.Label lbl_success_cut;
        private System.Windows.Forms.Label lbl_success_merge;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer1;
    }
}

