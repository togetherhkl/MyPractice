namespace WindowsFormsApplication_同学录_
{
    partial class FrmInto
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.butinto = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labstu = new System.Windows.Forms.Label();
            this.combstu = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txttime = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butinto
            // 
            this.butinto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butinto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butinto.ForeColor = System.Drawing.Color.DarkViolet;
            this.butinto.Location = new System.Drawing.Point(25, 16);
            this.butinto.Name = "butinto";
            this.butinto.Size = new System.Drawing.Size(98, 40);
            this.butinto.TabIndex = 0;
            this.butinto.Text = "进入";
            this.butinto.UseVisualStyleBackColor = false;
            this.butinto.Click += new System.EventHandler(this.butinto_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.butinto);
            this.panel1.Location = new System.Drawing.Point(352, 435);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 72);
            this.panel1.TabIndex = 1;
            // 
            // labstu
            // 
            this.labstu.AutoSize = true;
            this.labstu.BackColor = System.Drawing.Color.Transparent;
            this.labstu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labstu.ForeColor = System.Drawing.Color.Yellow;
            this.labstu.Location = new System.Drawing.Point(22, 88);
            this.labstu.Name = "labstu";
            this.labstu.Size = new System.Drawing.Size(173, 12);
            this.labstu.TabIndex = 2;
            this.labstu.Text = "请选择进入那个同学的同学录：";
            // 
            // combstu
            // 
            this.combstu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combstu.FormattingEnabled = true;
            this.combstu.Location = new System.Drawing.Point(24, 130);
            this.combstu.Name = "combstu";
            this.combstu.Size = new System.Drawing.Size(161, 20);
            this.combstu.TabIndex = 3;
            this.combstu.SelectedIndexChanged += new System.EventHandler(this.combstu_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.richTextBox1.Location = new System.Drawing.Point(619, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(231, 435);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "突然想起初三的体育课后男生三三两两的回到教室，偶尔几个通红的脸，仰头喝掉杯里的水，找女生借餐巾纸擦脸上的汉，衣角还上下翻动扇风，女生一群一群嘻嘻哈哈的走进教室交头" +
    "接耳讨论着谁和谁的八卦，偶尔伴随着寄生高分贝的尖叫“谁拿了老子勒笔？站出来！”还有一些不耐烦的同学在试卷上写下名字过后相互抱怨“天天考天天考，考毛啊！”我好像就" +
    "微笑着站在他们身边忍不住想插嘴的时候忽然什么都不见了，只剩下手里捧着的毕业照";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.ForestGreen;
            this.label1.Location = new System.Drawing.Point(264, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "现在的时间是：";
            // 
            // txttime
            // 
            this.txttime.BackColor = System.Drawing.SystemColors.Control;
            this.txttime.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txttime.ForeColor = System.Drawing.Color.Red;
            this.txttime.Location = new System.Drawing.Point(377, 339);
            this.txttime.Name = "txttime";
            this.txttime.ReadOnly = true;
            this.txttime.Size = new System.Drawing.Size(181, 26);
            this.txttime.TabIndex = 6;
            // 
            // FrmInto
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.txttime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.combstu);
            this.Controls.Add(this.labstu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "同学录";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labstu;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ComboBox combstu;
        public System.Windows.Forms.Button butinto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttime;
        public System.Windows.Forms.RichTextBox richTextBox1;


    }
}

