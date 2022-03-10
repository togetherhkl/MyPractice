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
    public partial class Frmdelet : Form
    {
        public Frmdelet()
        {
            InitializeComponent();
        }
        private void deletestate(int state)
        {
            var frm = new Frmdata();
            Class1.falgtime = state;
            Class1.flag = 3;
            frm.Show();
            this.Close();
        }
        private void btndeletprm_Click(object sender, EventArgs e)
        {
            deletestate (1);

        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            var frm = new Frmhome();
            frm.Show();
            this.Dispose();
        }

        private void btndetjnr_Click(object sender, EventArgs e)
        {
            deletestate(2);
        }

        private void btndetsnr_Click(object sender, EventArgs e)
        {
            deletestate(3);
        }

        private void btndetunr_Click(object sender, EventArgs e)
        {
            deletestate(4);
        }

        private void Frmdelet_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmdeleteset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
        }
    }
}
