namespace WindowsFormsApplication_同学录_
{
    partial class Frmadd
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
            this.btnaddnewstu = new System.Windows.Forms.Button();
            this.btnaddnewdata = new System.Windows.Forms.Button();
            this.btnretrnhome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(235, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnaddnewstu
            // 
            this.btnaddnewstu.BackColor = System.Drawing.Color.OrangeRed;
            this.btnaddnewstu.Location = new System.Drawing.Point(227, 147);
            this.btnaddnewstu.Name = "btnaddnewstu";
            this.btnaddnewstu.Size = new System.Drawing.Size(186, 57);
            this.btnaddnewstu.TabIndex = 1;
            this.btnaddnewstu.Text = "添加一个新的同学录";
            this.btnaddnewstu.UseVisualStyleBackColor = false;
            this.btnaddnewstu.Click += new System.EventHandler(this.btnaddnewstu_Click);
            // 
            // btnaddnewdata
            // 
            this.btnaddnewdata.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnaddnewdata.Location = new System.Drawing.Point(227, 291);
            this.btnaddnewdata.Name = "btnaddnewdata";
            this.btnaddnewdata.Size = new System.Drawing.Size(186, 57);
            this.btnaddnewdata.TabIndex = 2;
            this.btnaddnewdata.Text = "给该同学录添加新的数据";
            this.btnaddnewdata.UseVisualStyleBackColor = false;
            this.btnaddnewdata.Click += new System.EventHandler(this.btnaddnewdata_Click);
            // 
            // btnretrnhome
            // 
            this.btnretrnhome.Location = new System.Drawing.Point(659, 507);
            this.btnretrnhome.Name = "btnretrnhome";
            this.btnretrnhome.Size = new System.Drawing.Size(137, 43);
            this.btnretrnhome.TabIndex = 3;
            this.btnretrnhome.Text = "返回主页";
            this.btnretrnhome.UseVisualStyleBackColor = true;
            this.btnretrnhome.Click += new System.EventHandler(this.btnretrnhome_Click);
            // 
            // Frmadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.btnretrnhome);
            this.Controls.Add(this.btnaddnewdata);
            this.Controls.Add(this.btnaddnewstu);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnaddnewstu;
        private System.Windows.Forms.Button btnaddnewdata;
        private System.Windows.Forms.Button btnretrnhome;
    }
}