namespace WindowsFormsApplication_同学录_
{
    partial class frmsrhslct
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
            this.btnprm = new System.Windows.Forms.Button();
            this.btnjnr = new System.Windows.Forms.Button();
            this.btnunr = new System.Windows.Forms.Button();
            this.btnsnr = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(447, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择你要查询的阶段";
            // 
            // btnprm
            // 
            this.btnprm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnprm.Location = new System.Drawing.Point(206, 212);
            this.btnprm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprm.Name = "btnprm";
            this.btnprm.Size = new System.Drawing.Size(236, 70);
            this.btnprm.TabIndex = 1;
            this.btnprm.Text = "查询小学同学";
            this.btnprm.UseVisualStyleBackColor = false;
            this.btnprm.Click += new System.EventHandler(this.btnprm_Click);
            // 
            // btnjnr
            // 
            this.btnjnr.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnjnr.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnjnr.Location = new System.Drawing.Point(782, 212);
            this.btnjnr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnjnr.Name = "btnjnr";
            this.btnjnr.Size = new System.Drawing.Size(236, 70);
            this.btnjnr.TabIndex = 2;
            this.btnjnr.Text = "查询初中同学";
            this.btnjnr.UseVisualStyleBackColor = false;
            this.btnjnr.Click += new System.EventHandler(this.btnjnr_Click);
            // 
            // btnunr
            // 
            this.btnunr.BackColor = System.Drawing.Color.DarkOrange;
            this.btnunr.Location = new System.Drawing.Point(782, 417);
            this.btnunr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnunr.Name = "btnunr";
            this.btnunr.Size = new System.Drawing.Size(236, 70);
            this.btnunr.TabIndex = 3;
            this.btnunr.Text = "查询大学同学";
            this.btnunr.UseVisualStyleBackColor = false;
            this.btnunr.Click += new System.EventHandler(this.btnunr_Click);
            // 
            // btnsnr
            // 
            this.btnsnr.BackColor = System.Drawing.Color.OrangeRed;
            this.btnsnr.Location = new System.Drawing.Point(190, 417);
            this.btnsnr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsnr.Name = "btnsnr";
            this.btnsnr.Size = new System.Drawing.Size(236, 70);
            this.btnsnr.TabIndex = 4;
            this.btnsnr.Text = "查询高中同学";
            this.btnsnr.UseVisualStyleBackColor = false;
            this.btnsnr.Click += new System.EventHandler(this.btnsnr_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnreturn.Location = new System.Drawing.Point(998, 588);
            this.btnreturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(154, 50);
            this.btnreturn.TabIndex = 5;
            this.btnreturn.Text = "返回";
            this.btnreturn.UseVisualStyleBackColor = false;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // frmsrhslct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 843);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnsnr);
            this.Controls.Add(this.btnunr);
            this.Controls.Add(this.btnjnr);
            this.Controls.Add(this.btnprm);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmsrhslct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprm;
        private System.Windows.Forms.Button btnjnr;
        private System.Windows.Forms.Button btnunr;
        private System.Windows.Forms.Button btnsnr;
        private System.Windows.Forms.Button btnreturn;
    }
}