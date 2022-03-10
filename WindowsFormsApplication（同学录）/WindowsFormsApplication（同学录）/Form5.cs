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

namespace WindowsFormsApplication_同学录_
{
    public partial class Frmaddnewstu : Form
    {
        public Frmaddnewstu()
        {
            InitializeComponent();
        }

        private void btnreterhome_Click(object sender, EventArgs e)//返回主页
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

        private void btnretren_Click(object sender, EventArgs e)//返回
        {
            var frm = new Frmadd();
            frm.Show();
            this.Hide();
        }
        private void stutime(int sttime)//建立一个函数用来打开添加的界面，参数数据添加的阶段
        {
            var frm = new Frmdata();
            Class1.falgtime =sttime ;//添加的阶段
            frm.Show();
            this.Dispose();
        }
        private void Frmaddnewstu_Load(object sender, EventArgs e)//添加界面的开始
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmaddset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            if (Class1.flag == 1)//根据flag 使标题显示的是，登录界面输入的学生的姓名flage=1表示上一页点击的是添加新的同学录
            {
                panel1.Visible = false;
                panel2.Visible = true;
                this.Text = "添加新的同学录";
            }
            if (Class1.flag == 0)//falge=0表示上一页点击的是添加新数据
            {
                panel1.Visible = true;
                panel2.Visible = false;
                this.Text = "增添新的数据";
            }
        }
        string sqldatatablename = "";//储存新添加新的同学录
        private void btnsure_Click(object sender, EventArgs e)//确认按钮
        {
            if (txtstuname.Text == "")
            {
                MessageBox.Show("请先输入姓名！");
                txtstuname.Focus();
            }
            if(txtstuname .Text !="")
            {
                panel1.Visible = true;
                sqldatatablename = txtstuname.Text.Trim();
                string[] databasename = { "小学同学", "初中同学", "高中同学", "大学同学" };
                string[] timename = {"prms","jnrs","snrs","unrs" };
                for (int i = 0; i < databasename.Count(); i++)
                {
                    creatadatatable(databasename[i], timename[i]);//创建储存信息的表。传入数据库的名字，以及创建表列的名字相同的部分
                    createvepcrtable(databasename[i], timename[i]);//创建储存图片信息的地方，传入数据库的名字，以及创建表列的名字相同的部分
                    //foreignkey(databasename[i], timename[i]);//建立外键
                    
                }
                string sql = "insert stuname values('" + sqldatatablename + "')";
                new Class1 ().noequery ("同学录数目",sql);
                MessageBox.Show("新同学添加成功，接下来添加数据吧！");
            }
        }
        private void creatadatatable(string statetime,string timename)//在对应的数据库中建立基本表,基本信息
        {
            string name = timename + "name nvarchar(10) not null";
            string gender = timename + "gender bit null";
            string birth = timename + "birth date null";
            string native = timename + "native nvarchar(50) null";
            string wrkplase = timename + "wrkplase nvarchar(50) null";
            string number = timename + "unmber char(11) null";
            string qq = timename + "qq nvarchar(15) null";
            string senword = timename + "senword nvarchar(300) null";
            string sql = "create table " + sqldatatablename + " (" +
                   name + ",  " +
                   gender + ", " +
                   birth + ", " +
                   native + ", " +
                   wrkplase + ", " +
                   number + ", " +
                   qq +","+
                   senword +")";
                   
            new Class1().noequery(statetime ,sql);
                   
        }
        private void createvepcrtable(string statetime, string timename)//在数据库中创建储存图片的表
        {
            string picture = timename + "picture nvarchar(100) null, ";
            string video = timename + "video nvarchar(100) null, ";
            string name = timename + "name nvarchar(10), ";
            string sql = "create table " + "vepcrsource" + sqldatatablename + " (" + picture + video + name +");";
           new Class1().noequery(statetime ,sql);
        }
       /* private void foreignkey(string statetime, string timename)//建立外键
        {
            string sql = "alter table vepcrsource" + sqldatatablename +
                " add constraint KF_vepcrsource" + sqldatatablename + "_" + sqldatatablename
                + " foreign key(" + timename + "name)" + " references " + sqldatatablename + "(" + timename + "name)";
            new Class1().noequery(statetime ,sql);
        }*/
        private void btnaddprmstu_Click(object sender, EventArgs e)//添加小学同学
        {
            stutime(1);
            

        }

        private void btnaddjunstu_Click(object sender, EventArgs e)//添加初中同学
        {
            stutime(2);
        }

        private void btnaddhighstu_Click(object sender, EventArgs e)//添加高中同学
        {
            stutime(3);
        }

        private void btnaddunvstu_Click(object sender, EventArgs e)//添加大学同学
        {
            stutime(4);
        }
    }
}
