using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
//#define OHJE7JW7DXUK91P DESKTOP-KDHOUKC

namespace WindowsFormsApplication_同学录_
{

    class Class1
    {
        public static  string home = "";//记录进入同学录的名字，主页窗体的标题好调用
        public static string serch = "";//存主页中查询按钮的名字，查询界面的标题调用
        public static string modfiy = "";//存修改
        public static string delete = "";//存删除
        public static string add = "";//存添加
        public static string set = "";//存设置
        public static int flag = 0;//记录是添加新的同学，还是添加新的数据
        public static int falgtime;//记录添加的同学阶段
        public static string serchtime = "";//记录查询或添加的时间段；
        public static string serchtimename = "";//查询或添加的人的名字
        public static string picture = "";//在数据库中添加图片
        public static string vedvio = "";//在数据库中添加视频
        public static string modfiystate = "";//记录修改的状态
        public static string modfiyname = "";//记录数据库视频图片的人名的列的头名称
        //修改时对数据库中列的操作，为列名
        public static string name = "";
        public static string bitrh = "";
        public static string gender = "";
        public static string native = "";
        public static string wrkplase = "";
        public static string number = "";
        public static string qq = "";
        public static string senword = "";
        public static string pictures = "";
        public static string video = "";
        //主页变
        public static Frmhome frmhome1 = null;
        
         public DataTable  gettable(string cnstr0,string sql)
        {
            string cnstr = "server=DESKTOP-KDHOUKC;database=" + cnstr0 + ";uid=sasa;pwd=sasasa;";
            SqlConnection cn = new SqlConnection(cnstr );
            cn.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter myad = new SqlDataAdapter(sql ,cn);
            myad.Fill(ds);
            DataTable t = ds.Tables[0];
            cn.Close();
            return t;
        }
         public void noequery(string cnstr0, string sql)
         {
             string cnstr = "server=DESKTOP-KDHOUKC;database=" + cnstr0 + ";uid=sasa;pwd=sasasa;";
             SqlConnection cn = new SqlConnection(cnstr );
             cn.Open();
             SqlCommand cmd = new SqlCommand(sql,cn );
             cmd.ExecuteNonQuery();
             cn.Close();
         }
         public void formset(string frmselect,string xiugai)//传入打开的文件名，以及要修改的图片的相对路径
         {
             string fname = "..\\..\\Formset\\"+frmselect ;
             if (!(File.Exists(fname)))
             {
                 MessageBox.Show("更改设置的文件不存在或者已经损坏！");
                 return;
             }
             FileStream fs = new FileStream(fname,FileMode.Create  ,FileAccess .Write );
             StreamWriter sw = new StreamWriter(fs);
             sw.WriteLine(xiugai );//以覆盖的形式把文件给修改了
             sw.Close();
             fs.Close();
         }
         public string imageselsect()//返回选择的图片的相对位置的字符串
         {
             string imagepath="";
             OpenFileDialog of = new OpenFileDialog();//选择图片
             of.Title = "请选择主页的背景图片！";
             if (of.ShowDialog() == DialogResult.OK)
             {
                 string image = of.FileName;//获得图片的绝对路径
                 string imagename = image.Substring(image.LastIndexOf("\\") + 1, image.Length - image.LastIndexOf("\\") - 1);//获取照片的名字，含后缀名
                 FileInfo f = new FileInfo(image);
                 imagepath = "..\\..\\Formset\\image\\" + imagename;
                 try
                 {
                     f.CopyTo(imagepath);//把照片复制到Formset下的image文件下
                 }
                 catch
                 {
                     MessageBox.Show("该图片名已经存在，请确认是保存了相同的图片还是图片名重复！");
                     //如果该图片已经存在则什么也不做，
                     //bug没有对图片名相同的进行修改
                 }
                
             }
             return imagepath;
         }
         public void imagemodify(string filename)//调用函数，输入需要把照片路径存入到某个文件的文件名
         {
             string imagepath = new Class1().imageselsect();//调用函数，返回选择的图片的相对位置的字符串
             if (imagepath == "")
             {
                 MessageBox.Show("你取消了照片的选择！");//在选择图片是，点击了取消
             }
             else
             {
                 new Class1().formset(filename , imagepath);//调用函数传入打开的文件,并把照片路径储存到该文件中
                 MessageBox.Show("修改成功！");
             }
         }
         public string imageset(string imagepath)
         {
             string fname = "..\\..\\Formset\\" + imagepath;
             if (!(File.Exists(fname)))
             {
                 return "";
             }
             FileStream fs= new FileStream(fname, FileMode.Open, FileAccess.Read);
             StreamReader rd = new StreamReader(fs);
             string data = rd.ReadLine();
             rd.Close();
             fs.Close();
             return data;

         }
         public void sqlcolummod(string time)
         {
             Class1.name = time + "sname='";
             Class1.gender = time + "sgender='";
             Class1.bitrh = time + "sbirth='";
             Class1.native = time + "snative='";
             Class1.wrkplase = time + "swrkplase='";
             Class1.number = time + "snumber='";
             Class1.qq = time + "sqq='";
             Class1.senword = time + "ssenword='";
             Class1.pictures = time + "spicture";
             Class1.video = time + "svideo";
         }
    }
}
