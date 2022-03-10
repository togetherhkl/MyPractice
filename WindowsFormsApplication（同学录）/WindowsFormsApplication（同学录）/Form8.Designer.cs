namespace WindowsFormsApplication_同学录_
{
    partial class frmserch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmserch));
            this.pnlserchway = new System.Windows.Forms.Panel();
            this.rdotableserch = new System.Windows.Forms.RadioButton();
            this.rdolistserch = new System.Windows.Forms.RadioButton();
            this.rdoimpotnam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsuer = new System.Windows.Forms.Button();
            this.pnlnameserch = new System.Windows.Forms.Panel();
            this.txtimpotname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnllistserch = new System.Windows.Forms.Panel();
            this.cmblistname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnldata = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.rtxsenword = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.labqq = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labnumber = new System.Windows.Forms.Label();
            this.labnative = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labwrkpalse = new System.Windows.Forms.Label();
            this.txtbirth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnrtrhom = new System.Windows.Forms.Button();
            this.btnretrn = new System.Windows.Forms.Button();
            this.tmrvepcrchnge = new System.Windows.Forms.Timer(this.components);
            this.pnlserchway.SuspendLayout();
            this.pnlnameserch.SuspendLayout();
            this.pnllistserch.SuspendLayout();
            this.pnldata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlserchway
            // 
            this.pnlserchway.BackColor = System.Drawing.Color.Transparent;
            this.pnlserchway.Controls.Add(this.rdotableserch);
            this.pnlserchway.Controls.Add(this.rdolistserch);
            this.pnlserchway.Controls.Add(this.rdoimpotnam);
            this.pnlserchway.Controls.Add(this.label1);
            this.pnlserchway.Location = new System.Drawing.Point(18, 18);
            this.pnlserchway.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlserchway.Name = "pnlserchway";
            this.pnlserchway.Size = new System.Drawing.Size(1248, 63);
            this.pnlserchway.TabIndex = 0;
            // 
            // rdotableserch
            // 
            this.rdotableserch.AutoSize = true;
            this.rdotableserch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdotableserch.ForeColor = System.Drawing.Color.Gold;
            this.rdotableserch.Location = new System.Drawing.Point(609, 14);
            this.rdotableserch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdotableserch.Name = "rdotableserch";
            this.rdotableserch.Size = new System.Drawing.Size(163, 32);
            this.rdotableserch.TabIndex = 3;
            this.rdotableserch.TabStop = true;
            this.rdotableserch.Text = "表框简单查看";
            this.rdotableserch.UseVisualStyleBackColor = true;
            this.rdotableserch.CheckedChanged += new System.EventHandler(this.rdotableserch_CheckedChanged);
            // 
            // rdolistserch
            // 
            this.rdolistserch.AutoSize = true;
            this.rdolistserch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdolistserch.ForeColor = System.Drawing.Color.Gold;
            this.rdolistserch.Location = new System.Drawing.Point(405, 14);
            this.rdolistserch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdolistserch.Name = "rdolistserch";
            this.rdolistserch.Size = new System.Drawing.Size(163, 32);
            this.rdolistserch.TabIndex = 2;
            this.rdolistserch.TabStop = true;
            this.rdolistserch.Text = "下拉列表查询";
            this.rdolistserch.UseVisualStyleBackColor = true;
            this.rdolistserch.CheckedChanged += new System.EventHandler(this.rdolistserch_CheckedChanged);
            // 
            // rdoimpotnam
            // 
            this.rdoimpotnam.AutoSize = true;
            this.rdoimpotnam.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdoimpotnam.ForeColor = System.Drawing.Color.Gold;
            this.rdoimpotnam.Location = new System.Drawing.Point(204, 14);
            this.rdoimpotnam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoimpotnam.Name = "rdoimpotnam";
            this.rdoimpotnam.Size = new System.Drawing.Size(163, 32);
            this.rdoimpotnam.TabIndex = 1;
            this.rdoimpotnam.TabStop = true;
            this.rdoimpotnam.Text = "输入姓名查询";
            this.rdoimpotnam.UseVisualStyleBackColor = true;
            this.rdoimpotnam.CheckedChanged += new System.EventHandler(this.rdoimpotnam_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(4, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择查询方式：";
            // 
            // btnsuer
            // 
            this.btnsuer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsuer.Location = new System.Drawing.Point(340, 106);
            this.btnsuer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsuer.Name = "btnsuer";
            this.btnsuer.Size = new System.Drawing.Size(112, 34);
            this.btnsuer.TabIndex = 4;
            this.btnsuer.Text = "确认";
            this.btnsuer.UseVisualStyleBackColor = false;
            this.btnsuer.Visible = false;
            this.btnsuer.Click += new System.EventHandler(this.btnsuer_Click);
            // 
            // pnlnameserch
            // 
            this.pnlnameserch.BackColor = System.Drawing.Color.Transparent;
            this.pnlnameserch.Controls.Add(this.txtimpotname);
            this.pnlnameserch.Controls.Add(this.label2);
            this.pnlnameserch.Location = new System.Drawing.Point(18, 90);
            this.pnlnameserch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlnameserch.Name = "pnlnameserch";
            this.pnlnameserch.Size = new System.Drawing.Size(297, 62);
            this.pnlnameserch.TabIndex = 1;
            this.pnlnameserch.Visible = false;
            // 
            // txtimpotname
            // 
            this.txtimpotname.Location = new System.Drawing.Point(129, 18);
            this.txtimpotname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtimpotname.Name = "txtimpotname";
            this.txtimpotname.Size = new System.Drawing.Size(162, 28);
            this.txtimpotname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(8, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "请输入姓名：";
            // 
            // pnllistserch
            // 
            this.pnllistserch.BackColor = System.Drawing.Color.Transparent;
            this.pnllistserch.Controls.Add(this.cmblistname);
            this.pnllistserch.Controls.Add(this.label3);
            this.pnllistserch.Location = new System.Drawing.Point(18, 90);
            this.pnllistserch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnllistserch.Name = "pnllistserch";
            this.pnllistserch.Size = new System.Drawing.Size(297, 62);
            this.pnllistserch.TabIndex = 2;
            this.pnllistserch.Visible = false;
            // 
            // cmblistname
            // 
            this.cmblistname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmblistname.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmblistname.FormattingEnabled = true;
            this.cmblistname.Location = new System.Drawing.Point(130, 21);
            this.cmblistname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmblistname.Name = "cmblistname";
            this.cmblistname.Size = new System.Drawing.Size(162, 26);
            this.cmblistname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "请选择姓名：";
            // 
            // pnldata
            // 
            this.pnldata.BackColor = System.Drawing.Color.Transparent;
            this.pnldata.Controls.Add(this.pictureBox1);
            this.pnldata.Controls.Add(this.axWindowsMediaPlayer1);
            this.pnldata.Controls.Add(this.rtxsenword);
            this.pnldata.Controls.Add(this.label11);
            this.pnldata.Controls.Add(this.labqq);
            this.pnldata.Controls.Add(this.label10);
            this.pnldata.Controls.Add(this.label9);
            this.pnldata.Controls.Add(this.labnumber);
            this.pnldata.Controls.Add(this.labnative);
            this.pnldata.Controls.Add(this.label8);
            this.pnldata.Controls.Add(this.labwrkpalse);
            this.pnldata.Controls.Add(this.txtbirth);
            this.pnldata.Controls.Add(this.label7);
            this.pnldata.Controls.Add(this.label6);
            this.pnldata.Controls.Add(this.txtgender);
            this.pnldata.Controls.Add(this.label5);
            this.pnldata.Controls.Add(this.txtname);
            this.pnldata.Controls.Add(this.label4);
            this.pnldata.Location = new System.Drawing.Point(18, 160);
            this.pnldata.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnldata.Name = "pnldata";
            this.pnldata.Size = new System.Drawing.Size(1266, 638);
            this.pnldata.TabIndex = 3;
            this.pnldata.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(405, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(502, 201);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(334, 221);
            this.axWindowsMediaPlayer1.TabIndex = 16;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // rtxsenword
            // 
            this.rtxsenword.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtxsenword.Location = new System.Drawing.Point(129, 360);
            this.rtxsenword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtxsenword.Name = "rtxsenword";
            this.rtxsenword.ReadOnly = true;
            this.rtxsenword.Size = new System.Drawing.Size(493, 271);
            this.rtxsenword.TabIndex = 15;
            this.rtxsenword.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.Info;
            this.label11.Location = new System.Drawing.Point(36, 354);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 31);
            this.label11.TabIndex = 14;
            this.label11.Text = "寄语：";
            // 
            // labqq
            // 
            this.labqq.AutoSize = true;
            this.labqq.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.labqq.ForeColor = System.Drawing.Color.Sienna;
            this.labqq.Location = new System.Drawing.Point(126, 318);
            this.labqq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labqq.Name = "labqq";
            this.labqq.Size = new System.Drawing.Size(88, 28);
            this.labqq.TabIndex = 13;
            this.labqq.Text = "label11";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(42, 308);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 31);
            this.label10.TabIndex = 12;
            this.label10.Text = "QQ：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(33, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 31);
            this.label9.TabIndex = 11;
            this.label9.Text = "电话：";
            // 
            // labnumber
            // 
            this.labnumber.AutoSize = true;
            this.labnumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.labnumber.ForeColor = System.Drawing.Color.OrangeRed;
            this.labnumber.Location = new System.Drawing.Point(128, 276);
            this.labnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labnumber.Name = "labnumber";
            this.labnumber.Size = new System.Drawing.Size(75, 28);
            this.labnumber.TabIndex = 10;
            this.labnumber.Text = "label9";
            // 
            // labnative
            // 
            this.labnative.AutoSize = true;
            this.labnative.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labnative.ForeColor = System.Drawing.Color.Green;
            this.labnative.Location = new System.Drawing.Point(94, 171);
            this.labnative.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labnative.Name = "labnative";
            this.labnative.Size = new System.Drawing.Size(75, 28);
            this.labnative.TabIndex = 9;
            this.labnative.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(2, 158);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 31);
            this.label8.TabIndex = 8;
            this.label8.Text = "籍贯：";
            // 
            // labwrkpalse
            // 
            this.labwrkpalse.AutoSize = true;
            this.labwrkpalse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.labwrkpalse.ForeColor = System.Drawing.Color.Teal;
            this.labwrkpalse.Location = new System.Drawing.Point(129, 232);
            this.labwrkpalse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labwrkpalse.Name = "labwrkpalse";
            this.labwrkpalse.Size = new System.Drawing.Size(75, 28);
            this.labwrkpalse.TabIndex = 7;
            this.labwrkpalse.Text = "label8";
            // 
            // txtbirth
            // 
            this.txtbirth.Location = new System.Drawing.Point(94, 111);
            this.txtbirth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbirth.Name = "txtbirth";
            this.txtbirth.ReadOnly = true;
            this.txtbirth.Size = new System.Drawing.Size(166, 28);
            this.txtbirth.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(-6, 222);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 31);
            this.label7.TabIndex = 5;
            this.label7.Text = "工作单位：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(4, 105);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "生日：";
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(94, 54);
            this.txtgender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtgender.Name = "txtgender";
            this.txtgender.ReadOnly = true;
            this.txtgender.Size = new System.Drawing.Size(73, 28);
            this.txtgender.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(8, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 31);
            this.label5.TabIndex = 2;
            this.label5.Text = "性别：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(94, 14);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtname.Name = "txtname";
            this.txtname.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(166, 28);
            this.txtname.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(8, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "姓名：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 76);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1248, 588);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnrtrhom
            // 
            this.btnrtrhom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnrtrhom.Location = new System.Drawing.Point(914, 813);
            this.btnrtrhom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnrtrhom.Name = "btnrtrhom";
            this.btnrtrhom.Size = new System.Drawing.Size(112, 34);
            this.btnrtrhom.TabIndex = 5;
            this.btnrtrhom.Text = "返回主页";
            this.btnrtrhom.UseVisualStyleBackColor = false;
            this.btnrtrhom.Click += new System.EventHandler(this.btnrtrhom_Click);
            // 
            // btnretrn
            // 
            this.btnretrn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnretrn.Location = new System.Drawing.Point(1078, 813);
            this.btnretrn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnretrn.Name = "btnretrn";
            this.btnretrn.Size = new System.Drawing.Size(112, 34);
            this.btnretrn.TabIndex = 6;
            this.btnretrn.Text = "返回";
            this.btnretrn.UseVisualStyleBackColor = false;
            this.btnretrn.Click += new System.EventHandler(this.btnretrn_Click);
            // 
            // tmrvepcrchnge
            // 
            this.tmrvepcrchnge.Enabled = true;
            this.tmrvepcrchnge.Interval = 5000;
            this.tmrvepcrchnge.Tick += new System.EventHandler(this.tmrvepcrchnge_Tick);
            // 
            // frmserch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 862);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pnllistserch);
            this.Controls.Add(this.btnretrn);
            this.Controls.Add(this.btnrtrhom);
            this.Controls.Add(this.btnsuer);
            this.Controls.Add(this.pnldata);
            this.Controls.Add(this.pnlnameserch);
            this.Controls.Add(this.pnlserchway);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmserch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form8";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.pnlserchway.ResumeLayout(false);
            this.pnlserchway.PerformLayout();
            this.pnlnameserch.ResumeLayout(false);
            this.pnlnameserch.PerformLayout();
            this.pnllistserch.ResumeLayout(false);
            this.pnllistserch.PerformLayout();
            this.pnldata.ResumeLayout(false);
            this.pnldata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlserchway;
        private System.Windows.Forms.RadioButton rdotableserch;
        private System.Windows.Forms.RadioButton rdolistserch;
        private System.Windows.Forms.RadioButton rdoimpotnam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsuer;
        private System.Windows.Forms.Panel pnlnameserch;
        private System.Windows.Forms.TextBox txtimpotname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnllistserch;
        private System.Windows.Forms.ComboBox cmblistname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnldata;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labwrkpalse;
        private System.Windows.Forms.TextBox txtbirth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labnative;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labnumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labqq;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtxsenword;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnrtrhom;
        private System.Windows.Forms.Button btnretrn;
        private System.Windows.Forms.Timer tmrvepcrchnge;

    }
}