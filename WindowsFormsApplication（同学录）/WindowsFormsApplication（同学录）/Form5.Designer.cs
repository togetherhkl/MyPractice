namespace WindowsFormsApplication_同学录_
{
    partial class Frmaddnewstu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnaddprmstu = new System.Windows.Forms.Button();
            this.btnaddjunstu = new System.Windows.Forms.Button();
            this.btnaddhighstu = new System.Windows.Forms.Button();
            this.btnaddunvstu = new System.Windows.Forms.Button();
            this.btnreterhome = new System.Windows.Forms.Button();
            this.btnretren = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstuname = new System.Windows.Forms.TextBox();
            this.btnsure = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(135, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "你想添加哪一段时间";
            // 
            // btnaddprmstu
            // 
            this.btnaddprmstu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnaddprmstu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnaddprmstu.Location = new System.Drawing.Point(3, 77);
            this.btnaddprmstu.Name = "btnaddprmstu";
            this.btnaddprmstu.Size = new System.Drawing.Size(172, 46);
            this.btnaddprmstu.TabIndex = 1;
            this.btnaddprmstu.Text = "添加小学同学";
            this.btnaddprmstu.UseVisualStyleBackColor = false;
            this.btnaddprmstu.Click += new System.EventHandler(this.btnaddprmstu_Click);
            // 
            // btnaddjunstu
            // 
            this.btnaddjunstu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnaddjunstu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnaddjunstu.Location = new System.Drawing.Point(217, 77);
            this.btnaddjunstu.Name = "btnaddjunstu";
            this.btnaddjunstu.Size = new System.Drawing.Size(172, 46);
            this.btnaddjunstu.TabIndex = 2;
            this.btnaddjunstu.Text = "添加初中同学";
            this.btnaddjunstu.UseVisualStyleBackColor = false;
            this.btnaddjunstu.Click += new System.EventHandler(this.btnaddjunstu_Click);
            // 
            // btnaddhighstu
            // 
            this.btnaddhighstu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnaddhighstu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnaddhighstu.Location = new System.Drawing.Point(3, 192);
            this.btnaddhighstu.Name = "btnaddhighstu";
            this.btnaddhighstu.Size = new System.Drawing.Size(172, 46);
            this.btnaddhighstu.TabIndex = 3;
            this.btnaddhighstu.Text = "添加高中同学";
            this.btnaddhighstu.UseVisualStyleBackColor = false;
            this.btnaddhighstu.Click += new System.EventHandler(this.btnaddhighstu_Click);
            // 
            // btnaddunvstu
            // 
            this.btnaddunvstu.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnaddunvstu.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnaddunvstu.Location = new System.Drawing.Point(217, 192);
            this.btnaddunvstu.Name = "btnaddunvstu";
            this.btnaddunvstu.Size = new System.Drawing.Size(172, 46);
            this.btnaddunvstu.TabIndex = 4;
            this.btnaddunvstu.Text = "添加大学同学";
            this.btnaddunvstu.UseVisualStyleBackColor = false;
            this.btnaddunvstu.Click += new System.EventHandler(this.btnaddunvstu_Click);
            // 
            // btnreterhome
            // 
            this.btnreterhome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnreterhome.Location = new System.Drawing.Point(571, 512);
            this.btnreterhome.Name = "btnreterhome";
            this.btnreterhome.Size = new System.Drawing.Size(88, 38);
            this.btnreterhome.TabIndex = 5;
            this.btnreterhome.Text = "返回主页";
            this.btnreterhome.UseVisualStyleBackColor = false;
            this.btnreterhome.Click += new System.EventHandler(this.btnreterhome_Click);
            // 
            // btnretren
            // 
            this.btnretren.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnretren.Location = new System.Drawing.Point(712, 512);
            this.btnretren.Name = "btnretren";
            this.btnretren.Size = new System.Drawing.Size(88, 38);
            this.btnretren.TabIndex = 6;
            this.btnretren.Text = "返回";
            this.btnretren.UseVisualStyleBackColor = false;
            this.btnretren.Click += new System.EventHandler(this.btnretren_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnaddprmstu);
            this.panel1.Controls.Add(this.btnaddjunstu);
            this.panel1.Controls.Add(this.btnaddhighstu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnaddunvstu);
            this.panel1.Location = new System.Drawing.Point(244, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 254);
            this.panel1.TabIndex = 7;
            this.panel1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "输入新同学的姓名：";
            // 
            // txtstuname
            // 
            this.txtstuname.Location = new System.Drawing.Point(131, 40);
            this.txtstuname.Name = "txtstuname";
            this.txtstuname.Size = new System.Drawing.Size(165, 21);
            this.txtstuname.TabIndex = 9;
            // 
            // btnsure
            // 
            this.btnsure.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsure.Location = new System.Drawing.Point(302, 40);
            this.btnsure.Name = "btnsure";
            this.btnsure.Size = new System.Drawing.Size(75, 23);
            this.btnsure.TabIndex = 10;
            this.btnsure.Text = "确认";
            this.btnsure.UseVisualStyleBackColor = false;
            this.btnsure.Click += new System.EventHandler(this.btnsure_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.txtstuname);
            this.panel2.Controls.Add(this.btnsure);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(244, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 101);
            this.panel2.TabIndex = 11;
            // 
            // Frmaddnewstu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnretren);
            this.Controls.Add(this.btnreterhome);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmaddnewstu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Frmaddnewstu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddprmstu;
        private System.Windows.Forms.Button btnaddjunstu;
        private System.Windows.Forms.Button btnaddhighstu;
        private System.Windows.Forms.Button btnaddunvstu;
        private System.Windows.Forms.Button btnreterhome;
        private System.Windows.Forms.Button btnretren;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstuname;
        private System.Windows.Forms.Button btnsure;
        private System.Windows.Forms.Panel panel2;
    }
}