using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace WindowsFormsApplication_同学录_
{
    public partial class Frmhome : Form//home主页窗体
    {
        List<string> urllist = new List<string>();//储存在数据库中读出来的播放路径
        double max, min;
        public Frmhome()
        {          
            InitializeComponent();
        }      
        private void Form3_Load(object sender, EventArgs e)
        {
            
            this.Text = Class1.home  + "同学录的主页";//主页窗体的标题，调用全窗体的变量
            label1.Text = btnhome.Text;//
            label1.Font = new Font("黑体", 20f);
            //pictureBox1.ImageLocation = "C:\\Users\\Administrator\\Pictures\\杂志锁屏\\3.jpg";
            //pictureBox2.ImageLocation = "C:\\Users\\Administrator\\Pictures\\杂志锁屏\\1.jpg";
            //pictureBox3.ImageLocation = "C:\\Users\\Administrator\\Pictures\\杂志锁屏\\2.jpg";
            this.BackgroundImage = Image.FromFile(new Class1 ().imageset ("frmhomeset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            Class1.add = btnadd.Text.ToString();//公共变量，add的内容为btnadd的内容，添加
            Class1.delete = btndelet.Text.ToString();
            Class1.modfiy = btnmodify.Text.ToString();
            Class1.serch = btnserch.Text.ToString();
            Class1.set = btnset.Text.ToString();
            string sql = "select *from 音乐名字";
            DataTable t = new Class1().gettable("音乐",sql);
            for (int i = 0; i < t.Rows.Count; i++)
            {
                string fullpath = Path.GetFullPath(t.Rows[i][0].ToString());//获取相对路径的绝对路径
                urllist.Add(fullpath );//把绝对路径存入到urllist中
                
            }
            foreach (var url in urllist)
            {
                lstmusic.Items.Add(Path .GetFileNameWithoutExtension (url));//想lstmusic中存入不含路径与扩展名的歌名
            }
        }

        private void btnadd_Click(object sender, EventArgs e)//添加按钮
        {
            var frm = new Frmadd();
            this.Hide();
            frm.ShowDialog(this);
        }

        private void btnserch_Click(object sender, EventArgs e)//查询按钮
        {
            var frm = new frmsrhslct();
            this.Hide();
            frm.Show();
        }

        private void btnmodify_Click(object sender, EventArgs e)
        {
            var frm = new Frmmodfiy();
            Class1.flag = 2;
            frm.Show();
            this.Hide();
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            var frm = new Frmdelet();
            Class1.flag = 3;
            frm.Show();
            this.Hide();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            var frm = new FrmInto();
            Class1.frmhome1.Dispose();
            frm.Show();
            this.Hide();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstmusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstmusic.SelectedIndex == -1)
                MessageBox.Show("请选择音乐！");
            else
            {
                int point = lstmusic.SelectedIndex;
                if (point == 0)
                {
                    btnlast.Enabled = false;
                    btnnext.Enabled = true;
                }
                else
                    btnlast.Enabled = true;
                if (point == lstmusic.Items.Count - 1)
                {
                    btnlast.Enabled = true;
                    btnnext.Enabled = false;
                }
                else
                    btnnext.Enabled = true;
                axWindowsMediaPlayer1.URL = urllist[point];//含有播放路径
                label2.Text = lstmusic.SelectedItem.ToString();
                label2.Visible = true;
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.currentMedia != null)//这句特别重要，首先判断是否为空
                max = axWindowsMediaPlayer1.currentMedia.duration;//获得音乐的总长度（int）型
            min = axWindowsMediaPlayer1.Ctlcontrols.currentPosition;//获得当前进度（int）型
            trackBar1.Maximum = (int)max;//进度条的范围上限为音乐的总长度
            trackBar1.Value = (int)(min);//进度条的当前值为播放的当前进度
            if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped)//播放状态，枚举型的状态为播放停止
            //integer; 播放状态，1=停止，2=暂停，3=播放，6=正在缓冲，9=正在连接，10=准备就绪 
            {
                if (lstmusic.SelectedIndex == lstmusic.Items.Count - 1)//如果是最后一首
                {
                    axWindowsMediaPlayer1.URL = urllist[0];//播放第一首
                    lstmusic.SelectedIndex = 0;
                }
                else 
               btnnext_Click(this, e);//调用下一首的点击事件，注意参数的传递
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            int point = lstmusic.SelectedIndex;

            if (point == 1)//因为后面减一后我零，则没有上一首了
            {
                btnlast.Enabled = false;
                btnnext.Enabled = true;
            }
            point = point - 1;
            if (point < 0)
                point = 0;
            lstmusic.SelectedIndex = point;//listbox显示的条移动到上一条
            axWindowsMediaPlayer1.URL = urllist[point];
            label2.Text = lstmusic.SelectedItem.ToString();
            label2.Visible = true;
            timer1.Start();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            int point = lstmusic.SelectedIndex;
            if (point == lstmusic.Items.Count - 2)//总数比位置索引多一，在达到位置索引之前一个就不启用
            //下一首控件，因为后面还要加一
            {
                btnlast.Enabled = true;
                btnnext.Enabled = false;
            }
            else
                btnnext.Enabled = true;
            point = point + 1;
            lstmusic.SelectedIndex = point;
            axWindowsMediaPlayer1.URL = urllist[point];
            label2.Text = lstmusic.SelectedItem.ToString();
            label2.Visible = true;
            timer1.Start();
        }

        private void btnstop_Click(object sender, EventArgs e)//停止的按钮
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            timer1.Stop();
            label2.Text = lstmusic.SelectedItem.ToString();
            label2.Visible = true;
        }

        private void btnpause_Click(object sender, EventArgs e)//暂停的按钮
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();//暂停
            timer1.Stop();
            label2.Text = lstmusic.SelectedItem.ToString();
            label2.Visible = true;
        }

        private void btnplay_Click(object sender, EventArgs e)//播放的按钮
        {
            int piont = lstmusic.SelectedIndex;
            if (lstmusic.SelectedIndex < 0)//如果没有选择当前项
            {
                piont = 0;//就播放第一首
                lstmusic.SelectedIndex = piont;//当前项移动到第一首
                axWindowsMediaPlayer1.URL = urllist[piont];//
                label2.Text = lstmusic.SelectedItem.ToString();
                label2.Visible = true;
            }
            else
            {
                axWindowsMediaPlayer1.Ctlcontrols.play();//播放就开始，从当前位置开始播放
            }
            timer1.Start();
        }

        private void trackBar1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Stop();
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            double dovalue = trackBar1.Value;//获得当前滚动框的当前位置数值

            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = dovalue;//播放位置移动到当前的位置
            axWindowsMediaPlayer1.Ctlcontrols.play();//从该位置播放
            timer1.Start();
        }

        private void btnset_Click(object sender, EventArgs e)
        {
            var frm = new Frmset();
            frm.Show();
            this.Hide ();
        }

        private void btnmsicopadn_Click(object sender, EventArgs e)
        {
            if (btnmsicopadn.Text == "打开音乐播放器")
            {
                tableLayoutPanel2.Visible = true;
                btnmsicopadn.Text = "关闭音乐播放器";
            }
            else if (btnmsicopadn.Text == "关闭音乐播放器")
            {
                tableLayoutPanel2.Visible =false ;
                btnmsicopadn.Text = "打开音乐播放器";
            }
        }

        private void btnhome_Click(object sender, EventArgs e)
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
            
        }

    }
}
