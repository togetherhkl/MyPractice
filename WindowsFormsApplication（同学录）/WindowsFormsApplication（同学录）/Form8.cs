using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WMPLib;
using System.IO;

namespace WindowsFormsApplication_同学录_
{
    public partial class frmserch : Form
    {
        DataTable t = new DataTable();
        int n = 0, m= 0;
        List<string> picture = new List<string>();
        List<string> video = new List<string>();
        public frmserch()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmserchset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            tmrvepcrchnge.Stop();
            switch (Class1.falgtime)
            {
                case 1: 
                    this.Text = "查询小学同学";
                    Class1.serchtime = "小学同学";
                    Class1.serchtimename = "prmsname";
                    break;//查询阶段点击的是查询小学同学
                case 2: 
                    this.Text = "查询初中同学"; 
                    Class1.serchtime = "初中同学";
                    Class1.serchtimename = "jnrsname";
                    break;
                case 3: 
                    this.Text = "查询高中同学"; 
                    Class1.serchtime = "高中同学";
                    Class1.serchtimename = "snrsname";
                    break;
                case 4:
                    this.Text = "查询大学同学";
                    Class1.serchtime = "大学同学";
                    Class1.serchtimename = "unrsname";
                    break;
            }
           
        }

        private void rdoimpotnam_CheckedChanged(object sender, EventArgs e)//以名字输入查询
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();//视频播放停止
            tmrvepcrchnge.Stop();//循环播放停止
            pnlnameserch.Visible = true;
            btnsuer.Visible = true;
            pnllistserch.Visible = false;
            pnldata.Visible = false;
            dataGridView1.Visible = false;
            
        }

        private void rdolistserch_CheckedChanged(object sender, EventArgs e)//下拉链表
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();//视频播放停止
            tmrvepcrchnge.Stop();//循环播放停止
            pnllistserch.Visible = true;//下拉列表框显示输出来
            btnsuer.Visible = true;
            pnldata.Visible = false;
            pnlnameserch.Visible = false;
            dataGridView1.Visible = false;
            cmblistname.Items.Clear();
            string sql = "select *from " + Class1.home;
             t = new Class1().gettable(Class1 .serchtime ,sql);
            for (int i = 0; i < t.Rows.Count; i++)
            {
                
                cmblistname.Items.Add(t.Rows [i][0].ToString ());//把名字存入下拉列表
            }
            if (t.Rows.Count > 0)
            {
                cmblistname.SelectedIndex = 0;
            }
        }

        private void btnsuer_Click(object sender, EventArgs e)
        {
            tmrvepcrchnge.Stop();//防止多次点击该页面，造成播放重复的卡顿
            string firstsql = "select *from " + Class1.home;
            DataTable first = new Class1().gettable(Class1 .serchtime ,firstsql);
            if (first.Rows.Count <= 0)//如果该阶段还没有储存人
            {
                MessageBox.Show("该同学录还没有添加相应的数据");
                return;
            }
            string canshu = "";
            string sql = "";
            if (rdoimpotnam.Checked == true)//输入名字来查询
            {
                axWindowsMediaPlayer1.Ctlcontrols.stop();//视频播放停止
                canshu = txtimpotname.Text.Trim();
                string sql1 = "select *from " + Class1.home;
                DataTable name=  new Class1().gettable(Class1.serchtime, sql1);//传入数据库的名字，以及操作语句
                int flage = 0;//1表示有此人，0表示没有此人
                for (int i = 0; i < name.Rows.Count;i++ )
                {
                    if (canshu == name.Rows[i][0].ToString ())
                        flage = 1;
                }
                if (flage == 0)
                {
                    MessageBox.Show("没有此人，请重新输入！");
                    txtimpotname.Focus();
                    pnldata.Visible = false;
                    return;
                }
                
            }
            if (rdolistserch.Checked == true)//选择名字来查询
            {
                canshu = cmblistname.Text.Trim();
                axWindowsMediaPlayer1.Ctlcontrols.stop();//视频播放停止
            }
            sql="select *from "+Class1 .home
                +" inner join vepcrsource"+Class1 .home 
                +" on "+Class1 .home +"."+Class1 .serchtimename +"=vepcrsource"+Class1 .home +"."+Class1 .serchtimename
                +" where "+Class1 .home +"."+ Class1 .serchtimename +"="+"'"+canshu+"'" ;
            //查询数据库中拥有外键的某个同学的所信息
             t = new Class1().gettable(Class1 .serchtime ,sql);
             if (t.Rows.Count > 0)
             {
                 picture.Clear();//清除里面之前存放的照片的路径
                 video.Clear();//清除里面的之气那存放的视频的路径
                 for (int i = 0; i < t.Rows.Count; i++)
                 {
                     pictureBox1.Visible = true;
                     axWindowsMediaPlayer1.Visible = true;
                     picture.Add(t.Rows[i][8].ToString());//把所有的照片路径放进一个字符串数组
                     video.Add(t.Rows[i][9].ToString());//把所有的视频路径放进一个字符串数组当中
                 }
                 tmrvepcrchnge.Start();//条用timer控件循环播放视频和音乐
             }
             if (t.Rows.Count <= 0)//如果没有添加照片或者视频查出来就是空的
             {
                 picture.Clear();
                 video.Clear();
                 axWindowsMediaPlayer1.Ctlcontrols.stop();
                 //只查询没有照片或者视频的
                 string resql = "select *from " + Class1.home + " where " + Class1.serchtimename + "='" + canshu + "'";
                 t = new Class1().gettable(Class1.serchtime, resql);
             }
             pnldata.Visible = true;               
            if (t.Rows.Count  > 0)
            {
                pnldata.Visible = true;
                txtname.Text = t.Rows[0][0].ToString();
                if (t.Rows [0][1].ToString()=="True")
                    txtgender.Text = "男";
                else
                    txtgender.Text = "女";
                txtbirth.Text = t.Rows[0][2].ToString().Substring(0, t.Rows[0][2].ToString().IndexOf (' '));//去掉后面的时间
                labnative.Text = t.Rows[0][3].ToString();
                labwrkpalse.Text = t.Rows[0][4].ToString();
                labnumber.Text = t.Rows[0][5].ToString();
                labqq.Text = t.Rows[0][6].ToString();
                rtxsenword.Text = t.Rows[0][7].ToString();
                if (picture.Count <= 0)
                {
                    MessageBox.Show("该同学没有添加照片!");
                    pictureBox1.Visible = false;
                }
                else
                {
                    pictureBox1.ImageLocation = picture[n];//一开始就显示出图片
                    pictureBox1.Visible = true;
                }              
                if (video.Count <= 0)
                {
                    MessageBox.Show("该同学没有添加视频！");
                    axWindowsMediaPlayer1.Visible = false;
                }
                else
                {
                    axWindowsMediaPlayer1.URL = Path.GetFullPath(video [m]);//一开始就播放图片
                    axWindowsMediaPlayer1.Visible = true;
                }
                
   
                
            }
        }
        private void vepcrchange()//图片和视频的循环播放函数
        {

            try
            {
                n++;
                if (n >= picture.Count)
                    n = 0;
                pictureBox1.ImageLocation = picture[n];//图片的循环播放
                m = m + 1;
                if (m >= video.Count)
                    m = 0;
                if (axWindowsMediaPlayer1.playState == WMPPlayState.wmppsStopped)//视频的循环播放
                {

                   
                    axWindowsMediaPlayer1.URL = Path.GetFullPath(video[m]);

                }
            }
            catch
            {

            }
        }

        private void btnsuer2_Click(object sender, EventArgs e)
        {
            pnldata.Visible = true;
        }

        private void rdotableserch_CheckedChanged(object sender, EventArgs e)//选中的是用表框来查看
        {           
            axWindowsMediaPlayer1.Ctlcontrols.stop();//视频播放停止
            tmrvepcrchnge.Stop();//循环播放停止
            dataGridView1.Visible = true;
            pnllistserch.Visible = false;//下拉列表隐藏
            btnsuer.Visible = false;//确认按钮隐藏
            pnldata.Visible = false;//显示的数据框隐藏
            pnlnameserch.Visible = false;  //名字输入的查询框隐藏
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();         
            string coum = "姓名,性别,生日,籍贯,工作单位,电话,QQ,寄语";//存表头的内容
            string[] cloum = coum.Split(',');//变成字符数组，用循环语句存到表头
            for (int n = 0; n < cloum.Count(); n++)
            {
                DataGridViewColumn coll0 = new DataGridViewColumn();//建立表框
                coll0.HeaderText = cloum[n].ToString();//表框表头的内容
                coll0.Width =101;//表列的宽度为81
                DataGridViewCell coll1 = new DataGridViewTextBoxCell();//建立单元格,并且为文本单元格
                coll0.CellTemplate = coll1;//每一列都为设定的单元格
                dataGridView1.Columns.Add(coll0);//表款增加一列
            }
            string sql = "select *from " + Class1.home;
            //对数据库的操作，连接两个表
                DataTable t = new Class1().gettable(Class1 .serchtime ,sql);//调用函数，传入数据库的名字，和对数据库的操作
            
                for (int i = 0; i < t.Rows.Count; i++)
                {
                    int k = dataGridView1.Rows.Add();//增加一行
                    for (int j = 0; j < t.Columns.Count ; j++)
                    {
                        if (j == 1)//数据库的内容中的bit转换
                        {
                            if (t.Rows[i][j].ToString () == "True")
                                dataGridView1.Rows[k].Cells[j].Value = "男";
                            else
                                dataGridView1.Rows[k].Cells[j].Value = "女";
                            j++;//这一列已经添加
                        }
                        if (j == 2)
                        {
                            dataGridView1.Rows[k].Cells[j].Value = t.Rows[i][j].ToString().Substring(0, t.Rows[i][j].ToString().IndexOf (' '));
                            j++;
                        }
                        dataGridView1.Rows[k].Cells[j].Value = t.Rows[i][j].ToString();
                    }
                }
            
        }

        private void btnrtrhom_Click(object sender, EventArgs e)//返回主页
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

        private void btnretrn_Click(object sender, EventArgs e)//返回
        {
            var frm = new frmsrhslct();
            frm.Show();
            this.Dispose();
        }

        private void tmrvepcrchnge_Tick(object sender, EventArgs e)//timer控件，实现图片，视频的循环播放
        {
            vepcrchange();//调用函数

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
