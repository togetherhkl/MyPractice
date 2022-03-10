namespace WindowsFormsApplication_同学录_
{
    partial class Frmhome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmhome));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnhome = new System.Windows.Forms.Button();
            this.btnserch = new System.Windows.Forms.Button();
            this.btndelet = new System.Windows.Forms.Button();
            this.btnset = new System.Windows.Forms.Button();
            this.btnquit = new System.Windows.Forms.Button();
            this.btnmodify = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnpause = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.lstmusic = new System.Windows.Forms.ListBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnmsicopadn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 13;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.030928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.030928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.030928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.030928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.030928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40206F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.030928F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.40206F));
            this.tableLayoutPanel1.Controls.Add(this.btnhome, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnserch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btndelet, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnset, 10, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnquit, 12, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnmodify, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnadd, 8, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 506);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(799, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnhome
            // 
            this.btnhome.BackColor = System.Drawing.Color.ForestGreen;
            this.btnhome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnhome.Location = new System.Drawing.Point(3, 3);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(101, 32);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "主页";
            this.btnhome.UseVisualStyleBackColor = false;
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // btnserch
            // 
            this.btnserch.BackColor = System.Drawing.Color.PaleGreen;
            this.btnserch.Location = new System.Drawing.Point(118, 3);
            this.btnserch.Name = "btnserch";
            this.btnserch.Size = new System.Drawing.Size(101, 32);
            this.btnserch.TabIndex = 1;
            this.btnserch.Text = "查询";
            this.btnserch.UseVisualStyleBackColor = false;
            this.btnserch.Click += new System.EventHandler(this.btnserch_Click);
            // 
            // btndelet
            // 
            this.btndelet.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btndelet.Location = new System.Drawing.Point(348, 3);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(101, 32);
            this.btndelet.TabIndex = 3;
            this.btndelet.Text = "删除";
            this.btndelet.UseVisualStyleBackColor = false;
            this.btndelet.Click += new System.EventHandler(this.btndelet_Click);
            // 
            // btnset
            // 
            this.btnset.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnset.Location = new System.Drawing.Point(578, 3);
            this.btnset.Name = "btnset";
            this.btnset.Size = new System.Drawing.Size(101, 32);
            this.btnset.TabIndex = 5;
            this.btnset.Text = "设置";
            this.btnset.UseVisualStyleBackColor = false;
            this.btnset.Click += new System.EventHandler(this.btnset_Click);
            // 
            // btnquit
            // 
            this.btnquit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnquit.Location = new System.Drawing.Point(693, 3);
            this.btnquit.Name = "btnquit";
            this.btnquit.Size = new System.Drawing.Size(101, 32);
            this.btnquit.TabIndex = 6;
            this.btnquit.Text = "退出";
            this.btnquit.UseVisualStyleBackColor = false;
            this.btnquit.Click += new System.EventHandler(this.btnquit_Click);
            // 
            // btnmodify
            // 
            this.btnmodify.BackColor = System.Drawing.Color.MediumBlue;
            this.btnmodify.Location = new System.Drawing.Point(233, 3);
            this.btnmodify.Name = "btnmodify";
            this.btnmodify.Size = new System.Drawing.Size(101, 32);
            this.btnmodify.TabIndex = 2;
            this.btnmodify.Text = "修改";
            this.btnmodify.UseVisualStyleBackColor = false;
            this.btnmodify.Click += new System.EventHandler(this.btnmodify_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnadd.Location = new System.Drawing.Point(463, 3);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(101, 32);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "添加";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(358, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80509F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lstmusic, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.trackBar1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(200, 54);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.586057F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.41553F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.99543F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(457, 446);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.btnplay, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnpause, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnstop, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnlast, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnnext, 5, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 384);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(451, 44);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnplay
            // 
            this.btnplay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnplay.Location = new System.Drawing.Point(3, 3);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(84, 38);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = "播放";
            this.btnplay.UseVisualStyleBackColor = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnpause
            // 
            this.btnpause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnpause.Location = new System.Drawing.Point(93, 3);
            this.btnpause.Name = "btnpause";
            this.btnpause.Size = new System.Drawing.Size(84, 38);
            this.btnpause.TabIndex = 1;
            this.btnpause.Text = "暂停";
            this.btnpause.UseVisualStyleBackColor = false;
            this.btnpause.Click += new System.EventHandler(this.btnpause_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnstop.Location = new System.Drawing.Point(183, 3);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(84, 38);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "停止";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // btnlast
            // 
            this.btnlast.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnlast.Location = new System.Drawing.Point(273, 3);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(84, 38);
            this.btnlast.TabIndex = 3;
            this.btnlast.Text = "上一首";
            this.btnlast.UseVisualStyleBackColor = false;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnnext.Location = new System.Drawing.Point(363, 3);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(85, 38);
            this.btnnext.TabIndex = 4;
            this.btnnext.Text = "下一首";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // lstmusic
            // 
            this.lstmusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstmusic.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstmusic.FormattingEnabled = true;
            this.lstmusic.ItemHeight = 21;
            this.lstmusic.Location = new System.Drawing.Point(3, 82);
            this.lstmusic.Name = "lstmusic";
            this.lstmusic.Size = new System.Drawing.Size(451, 296);
            this.lstmusic.TabIndex = 2;
            this.lstmusic.SelectedIndexChanged += new System.EventHandler(this.lstmusic_SelectedIndexChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.trackBar1.Location = new System.Drawing.Point(18, 39);
            this.trackBar1.Maximum = 1000;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(421, 37);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseDown);
            this.trackBar1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBar1_MouseUp);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02575F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.97425F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.axWindowsMediaPlayer1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(451, 30);
            this.tableLayoutPanel4.TabIndex = 1;
            this.tableLayoutPanel4.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(3, 3);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnmsicopadn
            // 
            this.btnmsicopadn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnmsicopadn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmsicopadn.ForeColor = System.Drawing.Color.Red;
            this.btnmsicopadn.Location = new System.Drawing.Point(705, 53);
            this.btnmsicopadn.Name = "btnmsicopadn";
            this.btnmsicopadn.Size = new System.Drawing.Size(106, 30);
            this.btnmsicopadn.TabIndex = 3;
            this.btnmsicopadn.Text = "打开音乐播放器";
            this.btnmsicopadn.UseVisualStyleBackColor = false;
            this.btnmsicopadn.Click += new System.EventHandler(this.btnmsicopadn_Click);
            // 
            // Frmhome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.btnmsicopadn);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmhome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button btnserch;
        private System.Windows.Forms.Button btnmodify;
        private System.Windows.Forms.Button btndelet;
        private System.Windows.Forms.Button btnset;
        private System.Windows.Forms.Button btnquit;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnpause;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstmusic;
        private System.Windows.Forms.TrackBar trackBar1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnmsicopadn;
    }
}