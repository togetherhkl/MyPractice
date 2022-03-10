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
    public partial class frmsrhslct : Form
    {
        public frmsrhslct()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmserchset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            this.Text = "选择查询阶段";
            label1.Font = new Font("黑体",20f);
        }
        private void serchtime(int stage)
        {
            var frm = new frmserch();
            Class1.falgtime = stage;
            frm.Show();
            this.Hide();
        }
        private void btnprm_Click(object sender, EventArgs e)
        {
            serchtime(1);
        }

        private void btnjnr_Click(object sender, EventArgs e)
        {
            serchtime(2);
        }

        private void btnsnr_Click(object sender, EventArgs e)
        {
            serchtime(3);
        }

        private void btnunr_Click(object sender, EventArgs e)
        {
            serchtime(4);
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            if (Class1.frmhome1 == null)//主页不存在
            {
                Class1.frmhome1 = new Frmhome();
                Class1.frmhome1.Show();
            }
            else//主页存在
            {
                Class1.frmhome1.Activate();
                Class1.frmhome1.Show();

            }
            this.Dispose();
        }
    }
}
