namespace WindowsFormsApplication_同学录_
{
    partial class Frmdelet
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
            this.btndetprm = new System.Windows.Forms.Button();
            this.btndetjnr = new System.Windows.Forms.Button();
            this.btndetsnr = new System.Windows.Forms.Button();
            this.btndetunr = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(276, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请问你要删除那个时间段的学生";
            // 
            // btndetprm
            // 
            this.btndetprm.BackColor = System.Drawing.Color.Salmon;
            this.btndetprm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btndetprm.Location = new System.Drawing.Point(141, 124);
            this.btndetprm.Name = "btndetprm";
            this.btndetprm.Size = new System.Drawing.Size(205, 47);
            this.btndetprm.TabIndex = 1;
            this.btndetprm.Text = "删除小学学生";
            this.btndetprm.UseVisualStyleBackColor = false;
            this.btndetprm.Click += new System.EventHandler(this.btndeletprm_Click);
            // 
            // btndetjnr
            // 
            this.btndetjnr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btndetjnr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btndetjnr.Location = new System.Drawing.Point(528, 124);
            this.btndetjnr.Name = "btndetjnr";
            this.btndetjnr.Size = new System.Drawing.Size(205, 47);
            this.btndetjnr.TabIndex = 2;
            this.btndetjnr.Text = "删除初中学生";
            this.btndetjnr.UseVisualStyleBackColor = false;
            this.btndetjnr.Click += new System.EventHandler(this.btndetjnr_Click);
            // 
            // btndetsnr
            // 
            this.btndetsnr.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btndetsnr.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btndetsnr.Location = new System.Drawing.Point(141, 273);
            this.btndetsnr.Name = "btndetsnr";
            this.btndetsnr.Size = new System.Drawing.Size(205, 47);
            this.btndetsnr.TabIndex = 3;
            this.btndetsnr.Text = "删除高中学生";
            this.btndetsnr.UseVisualStyleBackColor = false;
            this.btndetsnr.Click += new System.EventHandler(this.btndetsnr_Click);
            // 
            // btndetunr
            // 
            this.btndetunr.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btndetunr.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndetunr.Location = new System.Drawing.Point(528, 273);
            this.btndetunr.Name = "btndetunr";
            this.btndetunr.Size = new System.Drawing.Size(205, 47);
            this.btndetunr.TabIndex = 4;
            this.btndetunr.Text = "删除大学学生";
            this.btndetunr.UseVisualStyleBackColor = false;
            this.btndetunr.Click += new System.EventHandler(this.btndetunr_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(676, 466);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(130, 28);
            this.btnreturn.TabIndex = 5;
            this.btnreturn.Text = "返回";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // Frmdelet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btndetunr);
            this.Controls.Add(this.btndetsnr);
            this.Controls.Add(this.btndetjnr);
            this.Controls.Add(this.btndetprm);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmdelet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form10";
            this.Load += new System.EventHandler(this.Frmdelet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndetprm;
        private System.Windows.Forms.Button btndetjnr;
        private System.Windows.Forms.Button btndetsnr;
        private System.Windows.Forms.Button btndetunr;
        private System.Windows.Forms.Button btnreturn;
    }
}