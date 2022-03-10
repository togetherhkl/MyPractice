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
    public partial class Frmadd : Form
    {
        public Frmadd()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmaddset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            this.Text = Class1.add;//添加的标题
            label1.Text = "请选择你添加到的方式";
            label1.Font = new Font("黑体", 20f);
        }
        public void test()
        {

        }
        private void btnretrnhome_Click(object sender, EventArgs e)//返回主页
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

        private void btnaddnewstu_Click(object sender, EventArgs e)//添加新的同学录
        {
            Class1.flag = 1;//使打开的见面知道是添加新同学
            var frm = new Frmaddnewstu();
            this.Hide();
            frm.Show();
            
        }

        private void btnaddnewdata_Click(object sender, EventArgs e)//添加新的数据
        {
            Class1.flag = 0;//在下一个见面中表示添加的是新数据
            var frm = new Frmaddnewstu();
            this.Hide();
            frm.Show();
        }
    }
}
