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
using System.Collections;

namespace WindowsFormsApplication_同学录_
{
    public partial class frmmusicdel : Form
    {
        List<string> urllist = new List<string>(); //储存读取音乐的名字
        public frmmusicdel()
        {
            InitializeComponent();
        }

        private void frmmusicdel_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmdeleteset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            this.Text = "删除音乐";
            string sql = "select *from 音乐名字";
            DataTable t = new Class1().gettable("音乐", sql);
            for (int i = 0; i < t.Rows.Count; i++)
            {
                string fullpath = Path.GetFullPath(t.Rows[i][0].ToString());//获取相对路径的绝对路径
                urllist.Add(fullpath);//把绝对路径存入到urllist中

            }
            foreach (var url in urllist)
            {
                lstmusic.Items.Add(Path.GetFileNameWithoutExtension(url));//想lstmusic中存入不含路径与扩展名的歌名
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (lstmusic.SelectedIndex == -1)//如果没有选择音乐，提醒先选取音乐
            {
                MessageBox.Show("请选择你要删除的音乐");
                return;
            }
            string musicname = urllist[lstmusic.SelectedIndex].ToString();//获取含有绝对路径的音乐名字
            //删除文件中的音乐名
            if (!(File.Exists(musicname)))//先判断文件或者文件路径是否存在
            {
                MessageBox.Show("储存照片的文件已经损坏或者不存在！");
                return;
            }
            FileAttributes attr = File.GetAttributes(musicname);//根据路径字符串判断是文件还是文件夹
            if (attr == FileAttributes.Directory)//如果文件是文件夹
            {
                Directory.Delete(musicname);//删除文件夹
            }
            else
            {
                File.Delete(musicname );//如果是文件则删除文件
            }
            //删除数据库中音乐名字
            //下一个语句使获取不含路径但是含有后缀名的文件名
            string sqlmusicdle = "..\\..\\music\\"+musicname.Substring(musicname.LastIndexOf("\\") + 1, musicname.Length - musicname.LastIndexOf("\\") - 1);
            string sql = "delete 音乐名字 where musicname='" + sqlmusicdle + "'";
            new Class1().noequery("音乐", sql);
            lstmusic.Items.RemoveAt(lstmusic.SelectedIndex);//删除lstmusic中的音乐名
            MessageBox.Show("删除成功！");
            
        }
    }
}
