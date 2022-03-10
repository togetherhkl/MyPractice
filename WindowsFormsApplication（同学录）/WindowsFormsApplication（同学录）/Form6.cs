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

namespace WindowsFormsApplication_同学录_
{
    public partial class Frmdata : Form
    {
        public Frmdata()
        {
            InitializeComponent();
        }
        DataTable t1;//定义全局变量，用来储存同学录的某个阶段的同学
        DataTable t2;//定义全局变量，用来储存照片视频
        int point;//对cmbbobox的顺序操作
        int point1;//对lstvideo内容的删除操作
        int point2;//对lstpictrue内容的删除操作
        string oriname = "";

        private void yermoninto()//年月的选择
        {
            int y = DateTime.Now.Year;
            for (; y >=2019 - 80; y--)
                cmbyear.Items.Add(y.ToString());
            for (int m = 1; m <= 12; m++)
                cmbmonth.Items.Add(m.ToString());
        }
        private void nativeinto()
        {
            cmbprovince.Items.Add("四川省");
            cmbprovince.Items.Add("贵州省");
            cmbprovince.Items.Add("海南省");
            
        }
        private void newstudata(string statetime,string time)//统一对公共变量进行修改
        {
            
            Class1.serchtime = statetime +"同学";
            Class1.serchtimename = time+"name";
            Class1.picture = time + "picture"; ;
            Class1.vedvio = time + "video";
        }
        private void Form6_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmhomeset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            if (Class1.flag == 1)//点击的为添加新同学
            {
                btnmodfiy.Visible = false;
                btnsave.Visible = true;
                pnlmodfiy.Visible = false ;
                pnldata.Visible = true;
                btndelet.Visible = false;
                yermoninto();//年月日的选择
                nativeinto();//省份的选择
                switch (Class1.falgtime)//输入新同学的信息
                {
                    case 1:
                        this.Text = "输入新同学的小学同学的信息";
                        newstudata("小学", "prms");
                        new Class1().sqlcolummod("prm");//传入时间段的前缀，保存修改的列名
                        break;
                    case 2:
                        this.Text = "输入新同学的初中同学的信息";
                        newstudata("初中", "jnrs");
                        new Class1().sqlcolummod("jnr");//传入时间段的前缀，保存修改的列名
                        break;
                    case 3:
                        this.Text = "输入新同学的高中同学的信息";
                        newstudata("高中","snrs");
                        new Class1().sqlcolummod("snr");//传入时间段的前缀，保存修改的列名
                        break;
                    case 4:
                        this.Text = "输入新同学的大学同学的信息";
                        newstudata("大学", "unrs");
                        new Class1().sqlcolummod("unr");//传入时间段的前缀，保存修改的列名
                        break;

                }
            }
            if (Class1.flag == 0)//点击的为曾添新数据
            {
                btnmodfiy.Visible = false;
                btnsave.Visible = true;
                pnlmodfiy.Visible = false ;
                pnldata.Visible = true;
                btndelet.Visible = false;
                yermoninto();//年月日的选择
                nativeinto();//省份的选择
                switch (Class1.falgtime)//判断点击的阶段
                {
                    case 1:
                        this.Text = "输入增加的小学同学的信息";
                        //1先创建该同学的小学同学的数据库表，模块化
                        //2在把数据入库，模块化
                        newstudata("小学", "prms");
                        new Class1().sqlcolummod("prm");//传入时间段的前缀，保存修改的列名
                        break;
                    case 2:
                        this.Text = "输入增加的初中同学的信息";
                        newstudata("初中", "jnrs");
                        new Class1().sqlcolummod("jnr");//传入时间段的前缀，保存修改的列名
                        break;
                    case 3:
                        this.Text = "输入增加的高中同学的信息";
                        newstudata("高中", "snrs");
                        new Class1().sqlcolummod("snr");//传入时间段的前缀，保存修改的列名
                        break;
                    case 4:
                        this.Text = "输入增加的大学同学的信息";
                        newstudata("大学", "unrs");
                        new Class1().sqlcolummod("unr");//传入时间段的前缀，保存修改的列名
                        break;
                }
            }
            if (Class1.flag == 2)//修改学生的数据
            {
                this.Text = "修改数据";
                btnmodfiy.Visible = true;//修改按钮
                btnsave.Visible = false;//保存按钮
                pnlmodfiy.Visible = true;//修改的容器
                pnldata.Visible = true;//查看数据的容器
                btndelet.Visible = false;//删除按钮
                btnlstpcdeleall.Visible = true;//照片的清除全部
                btnlstpcdeleslect.Visible = true;//照片的清除该项
                btnlstvedeleall.Visible = true;//视频的清除全部
                btnlstvedeleslect.Visible = true;//视频的清除该项
                switch (Class1.falgtime)
                {
                    case 1:
                        this.Text = "修改小学同学的信息";
                        newstudata("小学", "prms");                                           
                       Class1.modfiystate = "小学同学";
                       Class1.modfiyname = "prmsname";
                       cmbstuadd("小学同学");
                       new Class1().sqlcolummod("prm");//传入时间段的前缀，保存修改的列名
                            break;
                    case 2:
                        this.Text = "修改初中同学的信息";
                        newstudata("初中", "jnrs");                                          
                       Class1.modfiystate = "初中同学";
                       Class1.modfiyname = "jnrsname";
                       new Class1().sqlcolummod("jnr");//传入时间段的前缀，保存修改的列名
                       cmbstuadd("初中同学");
                        break;
                    case 3:
                        this.Text = "修改高中同学的信息";
                        newstudata("高中", "snrs");                                          
                        Class1.modfiystate = "高中同学";
                        Class1.modfiyname = "snrsname";
                        new Class1().sqlcolummod("snr");//传入时间段的前缀，保存修改的列名
                        cmbstuadd("高中同学");
                        break;
                    case 4:
                        this.Text = "修改大学同学的信息";
                        newstudata("大学", "unrs");                      
                        
                       Class1.modfiystate = "大学同学";
                       Class1.modfiyname = "unrsname";
                       new Class1().sqlcolummod("unr");//传入时间段的前缀，保存修改的列名
                       cmbstuadd("大学同学");
                        break;
                }
                

            }
            if (Class1.flag == 3)//上一个窗体点击的是删除按钮
            {
                lable8.Text = "请选择你要删除的学生";
                btnmodfiy.Visible = false;
                btnsave.Visible = false;
                btndelet.Visible = true;
                switch (Class1.falgtime)
                {
                    case 1:
                        this.Text = "删除小学同学";
                        newstudata("小学", "prms");
                        Class1.modfiystate = "小学同学";
                        Class1.modfiyname = "prmsname";
                        cmbstuadd("小学同学");
                        break;
                    case 2:
                        this.Text = "删除初中同学";
                        newstudata("初中", "jnrs");
                        Class1.modfiystate = "初中同学";
                        Class1.modfiyname = "jnrsname";
                        cmbstuadd("初中同学");
                        break;
                    case 3:
                        this.Text = "删除高中同学";
                        newstudata("高中", "snrs");
                        Class1.modfiystate = "高中同学";
                        Class1.modfiyname = "snrsname";
                        cmbstuadd("高中同学");
                        break;
                    case 4:
                        this.Text = "删除大学同学";
                        newstudata("大学", "unrs");
                        Class1.modfiystate = "大学同学";
                       Class1.modfiyname = "unrsname";
                       cmbstuadd("大学同学");
                        break;
                }              
            }
            
            
        }
        private void vepcr(string state)//使t2填充
        {
            string sql1 = "select *from vepcrsource" + Class1.home + " where "+Class1 .modfiyname  +"='"+cmbstu .Text+"'" ;//用来储存照片视频
            t2 = new Class1().gettable(state, sql1);
        }
        private void cmbstuadd(string state)//函数传入数据库的民名字，使下拉列表框库显示数据
        {
            string sql0 = "select * from " + Class1.home;//用来储存同学录的某个阶段的同学           
             t1 = new Class1().gettable(state, sql0);
             if (t1.Rows.Count <= 0)
             {
                 MessageBox.Show("该同学录还没有添加相应的数据");
                 pnldata.Visible = false;
                 pnlmodfiy.Visible = false;
                 btnmodfiy.Visible = false;
                 var frm =new Frmmodfiy();               
                 frm.Show();
                 this.Dispose();
                 return;
             }
            for (int i = 0; i < t1.Rows.Count; i++)
            {
                cmbstu.Items.Add(t1.Rows[i][0].ToString());
            }
            cmbstu.Text = t1.Rows[0][0].ToString();
            
        }
        private void btnreternhome_Click(object sender, EventArgs e)
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

        private void btnretern_Click(object sender, EventArgs e)
        {
            if (Class1.flag == 2)//flage=2表明是打开修改的窗体
            {
                var frm1 = new Frmmodfiy();
                this.Hide();
                frm1.Show();
            }
            else if (Class1.flag == 3)
            {
                var frm2 = new Frmdelet();
                this.Hide ();
                frm2.Show(); 
            }
            else 
            {
                var frm = new Frmaddnewstu();
                this.Hide();
                frm.Show();
            }
        }

        private void cmbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int y = int.Parse(cmbyear .Text );
            int m = int.Parse(cmbmonth.Text);
            cmbday.Items.Clear();
            int d = 30;
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                d = 31;
            }
            if (m == 2)
            {
                if ((y % 100 == 0 && y % 4 != 0) || y % 400 == 0)
                    d = 29;
                else
                    d = 28;
            }
            for (int d1 = 1; d1 <= d;d1++ )
                cmbday.Items.Add(d1.ToString());
        }

        private void cmbcity_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbprovince_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbprovince.Text == "四川省")
            {
                cmbcity.Items.Clear();
                cmbcity.Items.Add("成都市");
                cmbcity.Items.Add("泸州市");
                cmbcity.Items.Add("宜宾市");

            }
            if (cmbprovince.Text == "贵州省")
            {
                cmbcity.Items.Clear();
                cmbcity.Items.Add("贵阳市");
                cmbcity.Items.Add("遵义市");
                cmbcity.Items.Add("毕节市");
            }
            if (cmbprovince.Text == "海南省")
            {
                cmbcity.Items.Clear();
                cmbcity.Items.Add("海口市");
                cmbcity.Items.Add("三亚市");
                cmbcity.Items.Add("文昌市");
            }
        }
        List<string> pcrpath = new List<string>();//储存照片的字符数组
        private void btnpicther_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = true;
            of.Title = "请选择照片";

            if (of.ShowDialog() == DialogResult.OK)
            {
                string[] pcrpath0 = of.FileNames;
                foreach (var url in pcrpath0)
                {
                    //把照片保存到..\\..\\image下
                    FileInfo f = new FileInfo(url);
                  /*  string pcrnametail = url.Substring(url.LastIndexOf ("."),url .Length -url .LastIndexOf ("."));//获取照片的后缀名
                    string head = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString()
                        + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString()
                        + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                    string newpcrname = head + pcrnametail;//用时间来命名，但是不行，当同时添加多张照片时就命名就重复*/
                    string newpcrname = url.Substring(url.LastIndexOf("\\") + 1, url.Length - url.LastIndexOf("\\") - 1);//获取照片的名字
                    string newpcrpath = "..\\..\\image\\" + newpcrname;                    
                    pcrpath.Add(newpcrpath );//把新路径保存到字符数组中
                    try
                    {
                        f.CopyTo(newpcrpath);//复制到文件下
                    }
                    catch
                    {
                        MessageBox.Show(newpcrname + ":该照片名已经存在文件中，请确认是否照片名重复？");
                    }
                    lstpicture.Items.Add(newpcrpath );//存入到lis表中
                }
            }
        }
        List<string> video = new List<string>();//储存视频路径的字符数组
        private void btnvedio_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Multiselect = true;
            of.Title = "请选择视频";
            string videoname="";//存视频的名字
            video.Clear();//先把存视频路径的字符数组给清空
            if (of.ShowDialog() == DialogResult.OK)
            {
                string[] video0 = of.FileNames;
                foreach (var url in video0 )
                {
                    //把视频文件保存到..\\..\\video下
                    FileInfo f = new FileInfo(url);                                                       
                    videoname = url.Substring(url.LastIndexOf("\\") + 1, url.Length - url.LastIndexOf("\\") - 1);//获得视频的名字
                    string vieonamepath = "..\\..\\video\\" + videoname;
                    try
                    {
                        f.CopyTo(vieonamepath );//复制到..\\..\\video下
                    }
                    catch
                    {
                        MessageBox.Show(videoname +":该视频名字已经在文件里，请确认是是否名字重复？");
                    } 
                    video.Add(vieonamepath );//把新路径保存到字符数组中
                    lstvideo.Items.Add(vieonamepath );//存入到lst表中
                }
            }
        }
        
        private void savemodify(string svmd,string mody)//保存函数传入修改插入的关键词
        {
            string name = txtname.Text.Trim();
            oriname = cmbstu.Text.Trim();
            string sqlavename="select *from "+Class1.home  +" where "+Class1.serchtimename +"='"+name +"'" ;
            DataTable t = new Class1().gettable(Class1 .serchtime  ,sqlavename );//传入数据库的名字，以及操作语句
            if (t.Rows.Count > 0)
            {
                MessageBox.Show("该同学已经在同学录里面了");
                txtname.Focus();
                return;
            }
            int gender = 1;
            if (rdoman.Checked == true)
                gender = 1;
            else if (rdowoman.Checked == true)
                gender = 0;
            else//如果没有选择性别，则默认为男
                gender = 1;
            string birth = cmbyear.Text.Trim() + '.' + cmbmonth.Text.Trim() + '.' + cmbday.Text.Trim();
            if (birth == "..")//如果没有填写日期，就使用默认值
                birth = "";
            string province = "";
            string city = "";
            string county = "";
            try
            {
                 province = cmbprovince.Text.Trim();//筛选省          
                if (province.Substring(province.Length - 1, 1) != "省")
                {
                    province = province + "省";
                }
                city = cmbcity.Text.Trim();
                if (city.Substring(city.Length - 1, 1) != "市")
                {
                    city = city + "市";
                }
                county = cmbcounty.Text.Trim();
                if (county.Substring(county.Length - 1, 1) != "县")
                {
                    county = county + "县";
                }
            }
            catch
            {

            }
            string native = province +city +county ;
            string wrkplase = txtposition.Text.Trim();
            string number = txtcontact.Text.Trim();
            string qq = txtQQ.Text.Trim();
            string senword = rtxsenwords.Text;
            string sql = "";
            if (svmd == "insert")//插入的语句
            {
                sql = svmd + " " + Class1.home + " " + "values('" + name + "','" + gender + "','" + birth + "','" + native
                          + "','" + wrkplase + "','" + number + "','" + qq + "','" + senword + "')";
            }
            else if (svmd == "update")//修改的语句
            {
                sql = svmd + " " + Class1.home + " " + mody + " " + Class1.name + name + "', " + Class1.gender + gender + "', " +
                    Class1.bitrh + birth + "', " + Class1.native + native + "', " + Class1.wrkplase + wrkplase + "', " +
                    Class1.number + number + "', " + Class1.qq + qq + "', " + Class1.senword + senword + "' where " + Class1.modfiyname + "='" + oriname+"'";
            }           
            new Class1().noequery(Class1.serchtime, sql);//传入数据库的名字以及修改的语句
            //照片视频的操作
            string sql2 = "delete vepcrsource" + Class1.home + " where " + Class1.name + name + "'";//把数据库照片，视频路径全删除
            new Class1().noequery(Class1.serchtime, sql2);
            int k = lstpicture.Items.Count;
            int f = lstvideo.Items.Count;
            int m;
            if (k >= f)
                m = k;
            else
                m = f;
           
            for (int i = 0; i < m  ; i++)
            {
                if ((i <k)&&( i < f))//先把照片视频数量相同的部分储存起来
                {
                    string sql7 = "insert  vepcrsource" + Class1.home +  " values('" + lstpicture.Items[i].ToString() + "','"+lstvideo .Items[i] .ToString ()+"','"+ name + "')";
                    new Class1().noequery(Class1.serchtime, sql7);
                }
                if (i >= lstpicture.Items.Count)//视频比照片多，储存多的视频
                {                  
                    string sql6 = "insert  vepcrsource " + Class1.home + "(" + Class1.video + "," + Class1.modfiyname + ")" +
                    " values('" + lstvideo.Items[i].ToString() + "','" + name + "')";
                    new Class1().noequery(Class1.serchtime, sql6);
                }
                
                if (i >= lstvideo.Items.Count)//照片比视频多，储存多于的照片
                {
                    string sql3 = "insert  vepcrsource" + Class1.home + "(" + Class1.pictures + "," + Class1.modfiyname + ")" +
                        " values('" + lstpicture.Items[i].ToString() + "','" + name + "')";
                    new Class1().noequery(Class1.serchtime, sql3);
                }
            }         
            if(svmd =="insert" )
                MessageBox.Show("保存成功！");
            if (svmd == "update")
                MessageBox.Show("修改成功！");
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            savemodify("insert","values");
        }

        private void btnmodfiy_Click(object sender, EventArgs e)//修改的按钮
        {
            savemodify("update","set");
        }

        private void pnldata_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btnfirst_Click(object sender, EventArgs e)//第一个按钮
        {
            point = 0;
            cmbstu.SelectedIndex = point;
        }

        private void btnlast_Click(object sender, EventArgs e)//上一个按钮
        {
            point--;
            if (point < 0)
                point = 0;
            cmbstu.SelectedIndex = point;
        }

        private void btnnext_Click(object sender, EventArgs e)//下一个按钮
        {
           
            point++;
            if (point >= cmbstu.Items.Count)
                point = cmbstu.Items.Count - 1;
            cmbstu.SelectedIndex = point;
        }

        private void btnend_Click(object sender, EventArgs e)//最后一个按钮
        {
            point = cmbstu.Items.Count - 1;
            cmbstu.SelectedIndex = point;
        }

        private void cmbstu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cmbstu.Text;
            point = cmbstu.SelectedIndex;
            if (point == 0)
            {
                btnlast.Enabled = false;
                btnnext.Enabled = true;
            }
            else
                btnlast.Enabled = true;
            if (point == cmbstu.Items.Count - 1)
            {
                btnnext.Enabled = false;
                btnlast.Enabled = true;
            }
            else
                btnnext.Enabled = true;
            for (int i = 0; i < t1.Rows.Count; i++)
            {
                if (name == t1.Rows[i][0].ToString())
                {
                    txtname.Text = t1.Rows[i][0].ToString();
                    if (t1.Rows[i][1].ToString() == "True")
                        rdoman.Checked = true;
                    else
                        rdowoman.Checked = true;
                    cmbyear.Text = t1.Rows[i][2].ToString().Substring(0, t1.Rows[i][2].ToString().IndexOf('/'));//获取数据库里日期的年
                    //获得数据库日期中的月
                    cmbmonth.Text = t1.Rows[i][2].ToString().Substring(t1.Rows[i][2].ToString()
                        .IndexOf('/') + 1, t1.Rows[i][2].ToString().LastIndexOf('/') - 1 - t1.Rows[i][2].ToString().IndexOf('/'));
                    //获得数据库日期中的天
                    cmbday.Text = t1.Rows[i][2].ToString().Substring(t1.Rows[i][2].ToString().LastIndexOf('/') + 1,
                       t1.Rows[i][2].ToString().IndexOf(" ") - t1.Rows[i][2].ToString().LastIndexOf('/'));
                    //获取省
                    cmbprovince.Text = t1.Rows[i][3].ToString().Substring(0, t1.Rows[i][3].ToString().IndexOf("省")+1);
                    //获取市
                    cmbcity.Text = t1.Rows[i][3].ToString().Substring(t1.Rows[i][3].ToString().IndexOf("省") + 1,
                            t1.Rows[i][3].ToString().IndexOf("市") - t1.Rows[i][3].ToString().IndexOf("省"));
                    //获取县
                    cmbcounty.Text = t1.Rows[i][3].ToString().Substring(t1.Rows[i][3].ToString().IndexOf("市") + 1,
                        t1.Rows[i][3].ToString().Length - 1 - t1.Rows[i][3].ToString().IndexOf("市"));
                    txtposition.Text = t1.Rows[i][4].ToString();
                    txtcontact.Text = t1.Rows[i][5].ToString();
                    txtQQ.Text = t1.Rows[i][6].ToString();
                    rtxsenwords.Text = t1.Rows[i][7].ToString();
                }
                vepcr(Class1.modfiystate );
                lstvideo.Items.Clear();
                lstpicture.Items.Clear();
                for (int j=0;j<t2.Rows.Count;j++)
                {
                    if (t2.Rows[j][0].ToString()!="")
                    lstpicture.Items.Add(t2.Rows[j][0].ToString ());
                    if (t2.Rows[j][1].ToString()!="")
                    lstvideo.Items.Add(t2.Rows[j][1].ToString());
                }
                if(lstpicture.Items .Count >0)
                lstpicture.SelectedIndex = 0;
                if(lstvideo .Items .Count >0)
                lstvideo.SelectedIndex = 0;
            }

        }

        private void btnlstvedeleslect_Click(object sender, EventArgs e)
        {
            point1 = lstvideo.SelectedIndex;
            lstvideo.Items.RemoveAt(point1 );
        }

        private void btnlstvedeleall_Click(object sender, EventArgs e)
        {
            lstvideo.Items.Clear();
        }

        private void btnlstpcdeleslect_Click(object sender, EventArgs e)
        {
            point2 = lstpicture.SelectedIndex;
            lstpicture.Items.RemoveAt (point2 );
            
        }

        private void btnlstpcdeleall_Click(object sender, EventArgs e)
        {
            lstpicture.Items.Clear();
        }

        private void btndelet_Click(object sender, EventArgs e)
        {
            delete(Class1 .modfiystate ,Class1 .modfiyname );
            string sqlshuju="select *from "+Class1 .home ;
            DataTable shuju = new Class1().gettable( Class1 .modfiystate ,sqlshuju);
            if (shuju.Rows.Count <= 0)
            {
                MessageBox.Show("该同学录已经没有该阶段的数据了");
                var frm = new Frmdelet ();
                frm.Show();
                this.Dispose();
                return;
            }
            
        }
        private void delete(string state, string statetime)
        {
            string name=cmbstu .Text.Trim ();
            string sql = "delete " + Class1.home + " where " + statetime + "='" + name+"'";
            string sql2="delete vepcrsource"+Class1 .home +" where "+statetime +"='"+name+"'";
            new Class1().noequery(state,sql);
            new Class1().noequery(state ,sql2 );
            cmbstu.Items.RemoveAt(cmbstu .SelectedIndex );
            point++;
            cmbstu.Text = "";
            txtname.Clear();
            rdoman.Checked = false;
            rdowoman.Checked = false;
            cmbyear.Text = "";
            cmbmonth.Text = "";
            cmbday.Text = "";
            cmbprovince.Text = "";
            cmbcity.Text = "";
            cmbcounty.Text = "";
            txtposition.Clear();
            txtcontact.Clear();
            txtQQ.Clear();
            rtxsenwords.Clear();
            lstpicture.Items.Clear();
            lstvideo.Items.Clear();
            MessageBox.Show("删除成功！");
        }
    }
}
