using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication_同学录_
{
    public partial class Frmset : Form
    {
        public Frmset()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Text = "设置";
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmintoset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            
        }
        private void 添加新的同学录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // var frm = new Frmhome();
            //frm.ShowDialog(this);
           // this.Hide();
        }

        private void 添加音乐ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();//显示一个对话框，提示用户打开文件
            of.Multiselect = true;//获取一个值，该值指示对话框是否选择多个文件
            of.Title = "请选择音乐文件";//打开的窗口的标题为 “请选择音乐文件”
            of.Filter = "(*.mp3)|*.mp3";//决定对话框“另存文件类型”或“文件类型”在框中出现的选择类容
            if (of.ShowDialog() == DialogResult.OK)//最后选择了文件结果（即已经选择了文件）
            {
                
                string[] namelist = of.FileNames;//定义一个字符数组，用来储存文件的路径                             
               foreach (var url in namelist)//循环，把文件中的歌名写进listbox
                {
                    FileInfo f = new FileInfo(url);
                    string musicname = url.Substring(url.LastIndexOf("\\") + 1, url.Length - url.LastIndexOf("\\") - 1);
                    try
                    {
                       
                        f.CopyTo("..\\..\\music\\" + musicname );//把文件复制到当前路径的前两级的music路径下
                    }
                    catch (System.IO.IOException)
                    {
                       // MessageBox.Show("该音乐已经存在！");该音乐在文music下已经存在
                    }
                   
                    DataTable t = new Class1().gettable("音乐", "select *from 音乐名字 where musicname='..\\..\\music\\" + musicname + "'");
                   //先判断是否存在音该音乐名字
                    if (t.Rows.Count > 0)
                    {
                        MessageBox.Show(musicname +" 该音已经存在！");
                    }
                    else
                    {        
                        string sql = "insert 音乐名字(musicname) values ('..\\..\\music\\"+musicname+ "')";
                        new Class1().noequery("音乐", sql);
                        
                    }
                    MessageBox.Show(musicname +" 添加音乐成功！");
                }
               MessageBox.Show("退出在次进入方可刷新音乐");
            }
        }

        private void btnreturn_Click(object sender, EventArgs e)
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
            this.Hide();
        }

        private void 删除音乐ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm =new  frmmusicdel();
            frm.ShowDialog();
        }
      

        private void 更改背景图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Class1().imagemodify("frmhomeset.txt");//调用函数，输入需要把照片路径存入到某个文件的文件名
            
        }

        private void 背景图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Class1().imagemodify("frmintoset.txt");//调用函数，输入需要把照片路径存入到某个文件的文件名
        }

        private void 更改背景图片ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Class1().imagemodify("frmdeleteset.txt");//调用函数，输入需要把照片路径存入到某个文件的文件名
        }

        private void 更改背景图片ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new Class1().imagemodify("frmserchset.txt");//调用函数，输入需要把照片路径存入到某个文件的文件名
        }

        private void 背景图片ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Class1().imagemodify("frmaddset.txt");//调用函数，输入需要把照片路径存入到某个文件的文件名
        }

        private void 更改背景图ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new Class1().imagemodify("frmmodifiyset.txt");//调用函数，输入需要把照片路径存入到某个文件的文件名
        }

        private void 音乐的设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
