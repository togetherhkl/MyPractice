using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication_同学录_
{
    public partial class Frmmodfiy : Form
    {
        public Frmmodfiy()
        {
            InitializeComponent();
        }

        private void btnrtrnhome_Click(object sender, EventArgs e)
        {
            if (Class1.frmhome1 == null)//主页
            {
                Class1.frmhome1 = new Frmhome();
                Class1.frmhome1.Show();
            }
            else
            {
                Class1.frmhome1.Activate();
                Class1.frmhome1.Show();

            }
            this.Dispose();
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            var frm = new Frmhome();
            frm.Show();
            this.Dispose();
        }

        private void Frmmodfiy_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmmodifiyset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            this.Text = Class1.modfiy;
        }
        private void  modfiytime(int stage)//选择修改的阶段的函数
        {
            var frm = new Frmdata();
            Class1.falgtime = stage;
            frm.Show();
            this.Hide();
        }
        private void btnmdfiprm_Click(object sender, EventArgs e)
        {
            modfiytime(1);
            
        }

        private void btmmodfijnr_Click(object sender, EventArgs e)
        {
            modfiytime(2);
           
        }

        private void btnmodfisnr_Click(object sender, EventArgs e)
        {
            modfiytime(3);
           
        }

        private void btnmodfiunr_Click(object sender, EventArgs e)
        {
            modfiytime(4);
            
        }
    }
}
