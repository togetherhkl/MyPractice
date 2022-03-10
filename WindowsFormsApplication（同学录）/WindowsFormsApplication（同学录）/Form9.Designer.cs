namespace WindowsFormsApplication_同学录_
{
    partial class Frmmodfiy
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
            this.btnmdfiprm = new System.Windows.Forms.Button();
            this.btmmodfijnr = new System.Windows.Forms.Button();
            this.btnmodfisnr = new System.Windows.Forms.Button();
            this.btnmodfiunr = new System.Windows.Forms.Button();
            this.btnrtrnhome = new System.Windows.Forms.Button();
            this.btnreturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("黑体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(287, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择你要修改的时间段";
            // 
            // btnmdfiprm
            // 
            this.btnmdfiprm.BackColor = System.Drawing.Color.SandyBrown;
            this.btnmdfiprm.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmdfiprm.Location = new System.Drawing.Point(155, 158);
            this.btnmdfiprm.Name = "btnmdfiprm";
            this.btnmdfiprm.Size = new System.Drawing.Size(181, 49);
            this.btnmdfiprm.TabIndex = 1;
            this.btnmdfiprm.Text = "修改小学同学";
            this.btnmdfiprm.UseVisualStyleBackColor = false;
            this.btnmdfiprm.Click += new System.EventHandler(this.btnmdfiprm_Click);
            // 
            // btmmodfijnr
            // 
            this.btmmodfijnr.BackColor = System.Drawing.Color.Linen;
            this.btmmodfijnr.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btmmodfijnr.Location = new System.Drawing.Point(550, 158);
            this.btmmodfijnr.Name = "btmmodfijnr";
            this.btmmodfijnr.Size = new System.Drawing.Size(181, 49);
            this.btmmodfijnr.TabIndex = 2;
            this.btmmodfijnr.Text = "修改初中同学";
            this.btmmodfijnr.UseVisualStyleBackColor = false;
            this.btmmodfijnr.Click += new System.EventHandler(this.btmmodfijnr_Click);
            // 
            // btnmodfisnr
            // 
            this.btnmodfisnr.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnmodfisnr.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmodfisnr.Location = new System.Drawing.Point(155, 273);
            this.btnmodfisnr.Name = "btnmodfisnr";
            this.btnmodfisnr.Size = new System.Drawing.Size(181, 49);
            this.btnmodfisnr.TabIndex = 3;
            this.btnmodfisnr.Text = "修改高中同学";
            this.btnmodfisnr.UseVisualStyleBackColor = false;
            this.btnmodfisnr.Click += new System.EventHandler(this.btnmodfisnr_Click);
            // 
            // btnmodfiunr
            // 
            this.btnmodfiunr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnmodfiunr.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnmodfiunr.Location = new System.Drawing.Point(550, 273);
            this.btnmodfiunr.Name = "btnmodfiunr";
            this.btnmodfiunr.Size = new System.Drawing.Size(181, 49);
            this.btnmodfiunr.TabIndex = 4;
            this.btnmodfiunr.Text = "修改大学同学";
            this.btnmodfiunr.UseVisualStyleBackColor = false;
            this.btnmodfiunr.Click += new System.EventHandler(this.btnmodfiunr_Click);
            // 
            // btnrtrnhome
            // 
            this.btnrtrnhome.Location = new System.Drawing.Point(593, 515);
            this.btnrtrnhome.Name = "btnrtrnhome";
            this.btnrtrnhome.Size = new System.Drawing.Size(92, 35);
            this.btnrtrnhome.TabIndex = 5;
            this.btnrtrnhome.Text = "返回主页";
            this.btnrtrnhome.UseVisualStyleBackColor = true;
            this.btnrtrnhome.Click += new System.EventHandler(this.btnrtrnhome_Click);
            // 
            // btnreturn
            // 
            this.btnreturn.Location = new System.Drawing.Point(725, 515);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(92, 35);
            this.btnreturn.TabIndex = 6;
            this.btnreturn.Text = "返回";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // Frmmodfiy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 562);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.btnrtrnhome);
            this.Controls.Add(this.btnmodfiunr);
            this.Controls.Add(this.btnmodfisnr);
            this.Controls.Add(this.btmmodfijnr);
            this.Controls.Add(this.btnmdfiprm);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frmmodfiy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form9";
            this.Load += new System.EventHandler(this.Frmmodfiy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmdfiprm;
        private System.Windows.Forms.Button btmmodfijnr;
        private System.Windows.Forms.Button btnmodfisnr;
        private System.Windows.Forms.Button btnmodfiunr;
        private System.Windows.Forms.Button btnrtrnhome;
        private System.Windows.Forms.Button btnreturn;
    }
}