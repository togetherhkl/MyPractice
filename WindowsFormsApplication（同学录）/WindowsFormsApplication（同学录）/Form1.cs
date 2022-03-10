using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Data.SqlClient;
namespace WindowsFormsApplication_同学录_
{   
    public partial class FrmInto : Form//登录界面
    {
        
        
        
        public FrmInto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//combox来选择进入谁的同学录
        {
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmintoset.txt"));//调用函数，传入存图片路径的文件名
            this.BackgroundImageLayout = ImageLayout.Stretch;//使背景图片适应
            string sql="select *from stuname";
            DataTable t = new Class1().gettable("同学录数目", sql);
            for (int i = 0; i < t.Rows.Count; i++)
            {
                combstu.Items.Add(t.Rows[i][0].ToString());
            }
            labstu.Font = new Font("黑体", 12f);
            combstu.Font = new Font("黑体", 12f);
            combstu.ForeColor = Color.Blue;
            this.Font = new Font("宋体",18f);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)//画时钟
        {
            //this.SetStyle(ControlStyles.AllPaintingInWmPaint , true);
           Graphics g = e.Graphics;//定义一个画板
            Pen p = new Pen(Color.Black, 2);//定义一个画笔，颜色为黑色，字号为2号，画黑圈
            g.DrawEllipse(p, 300, 100, 200, 200);//画一个圆，矩形的左上角的坐标为（100,100）矩形的长度与宽度都为200
            Pen p1 = new Pen(Color.Red, 2);//定义一个画笔，颜色为红色，字号为2，画红圈
            g.DrawEllipse(p1, 296, 96, 208, 208);
            g.ResetTransform();//回复到默认状态
            g.TranslateTransform(400, 200);//原点坐标，更改为（200,200）
            Font drawfont = new Font("Arial", 12);//定义一个新的字体，字体为Arial，字号为12号
            SolidBrush drawbrush = new SolidBrush(Color.White );//定义一个笔刷，笔刷颜色为黑色
            e.Graphics.DrawString("12", drawfont, drawbrush, -10, -80);//在新的坐标下，在（-10,-80）处，写一个字符为12
            e.Graphics.DrawString("3", drawfont, drawbrush, 80, -7);
            e.Graphics.DrawString("6", drawfont, drawbrush, -10, 80);
            e.Graphics.DrawString("9", drawfont, drawbrush, -80, -10);
            for (int z = 0; z < 60; z++)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;//使画出的指针平滑，高质量
                //画钟的刻度
                g.ResetTransform();
                g.TranslateTransform(400, 200);
                g.RotateTransform(z * 6);//每循环一次，圆就旋转6度
                if (z % 5 == 0)//每隔五个小格，就画长一点
                    e.Graphics .DrawLine(new Pen(Color.Yellow , 3.0f), 94, 0, 100, 0);
                else
                    e.Graphics .DrawLine(new Pen(Color.Yellow , 1.5f), 96, 0, 100, 0);
            }

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            txttime.Text = hh + " : " + mm + " : " + ss;
 
            //画秒针
            g.ResetTransform();
            g.TranslateTransform(400, 200);
            g.RotateTransform(ss * 6 + 270);//
            Pen secpen = new Pen(Color.Red, 1);
            secpen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;//划线的开始为圆
            secpen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//划线的末尾为箭头
            e.Graphics .DrawLine(secpen, 0, 0, 65, 0);//长度为65

            g.ResetTransform();
            g.TranslateTransform(400, 200);
            g.RotateTransform(mm * 6 + 270);
            Pen minpen = new Pen(Color.Blue, 2);
            minpen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            minpen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            e.Graphics .DrawLine(minpen, 0, 0, 50, 0);

            g.ResetTransform();
            g.TranslateTransform(400, 200);
            g.RotateTransform(hh * 30 + mm * 1 / 2 + 270);
            Pen hourpen = new Pen(Color.Black, 3);
            hourpen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            hourpen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            e.Graphics .DrawLine(hourpen, 0, 0, 35, 0);
            
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
           //Invalidate();
            Bitmap bmp = new Bitmap(864, 601);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint  ,true);
           this.SetStyle(ControlStyles .OptimizedDoubleBuffer ,true);
           this.SetStyle(ControlStyles.UserPaint, true);
           // this.SetStyle(ControlStyles.ResizeRedraw, true);
            Graphics g = Graphics.FromImage(bmp);            
           g.Clear(System.Drawing.Color.Transparent );//使用透明画布
            //g.Clear(this.BackColor );
            
            Pen p = new Pen(Color.Black, 2);//定义一个画笔，颜色为黑色，字号为2号，画黑圈
            g.DrawEllipse(p, 300, 100, 200, 200);//画一个圆，矩形的左上角的坐标为（100,100）矩形的长度与宽度都为200
            Pen p1 = new Pen(Color.Red, 2);//定义一个画笔，颜色为红色，字号为2，画红圈
            g.DrawEllipse(p1, 296, 96, 208, 208);
            g.ResetTransform();//回复到默认状态
            g.TranslateTransform(400, 200);//原点坐标，更改为（200,200）
            Font drawfont = new Font("Arial", 12);//定义一个新的字体，字体为Arial，字号为12号
            SolidBrush drawbrush = new SolidBrush(Color.White);//定义一个笔刷，笔刷颜色为黑色     
            g.DrawString("12", drawfont, drawbrush, -10, -80);//在新的坐标下，在（-10,-80）处，写一个字符为12
            g.DrawString("3", drawfont, drawbrush, 80, -7);
            g.DrawString("6", drawfont, drawbrush, -10, 80);
            g.DrawString("9", drawfont, drawbrush, -80, -10);
            for (int z = 0; z < 60; z++)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;//使画出的指针平滑，高质量
                //画钟的刻度
                g.ResetTransform();
                g.TranslateTransform(400, 200);
                g.RotateTransform(z * 6);//每循环一次，圆就旋转6度
                if (z % 5 == 0)//每隔五个小格，就画长一点
                    g.DrawLine(new Pen(Color.Yellow , 3.0f), 94, 0, 100, 0);
                else
                    g.DrawLine(new Pen(Color.Yellow , 1.5f), 96, 0, 100, 0);
            }

            int ss = DateTime.Now.Second;
            int mm = DateTime.Now.Minute;
            int hh = DateTime.Now.Hour;
            txttime.Text = hh + " : " + mm + " : " + ss;

            //画秒针
            g.ResetTransform();
            g.TranslateTransform(400, 200);
            
            g.RotateTransform(ss * 6 + 270);//
            Pen secpen = new Pen(Color.Red, 1);
            secpen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;//划线的开始为圆
            secpen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;//划线的末尾为箭头
            g.DrawLine(secpen, 0, 0, 65, 0);//长度为65
            //画分针
            g.ResetTransform();
            g.TranslateTransform(400, 200);
            
            g.RotateTransform(mm * 6 + 270);
            Pen minpen = new Pen(Color.Blue, 2);
            minpen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            minpen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
           g.DrawLine(minpen, 0, 0, 50, 0);
            //画时针
            g.ResetTransform();
            g.TranslateTransform(400, 200);
           
            g.RotateTransform(hh * 30 + mm * 1 / 2 + 270);
            Pen hourpen = new Pen(Color.Black, 3);
            hourpen.StartCap = System.Drawing.Drawing2D.LineCap.RoundAnchor;
            hourpen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            g.DrawLine(hourpen, 0, 0, 35, 0);
            //g.Clear(System.Drawing.Color.Transparent);
            this.CreateGraphics().DrawImage(bmp, new Point(0, 0));
            this.BackgroundImage = Image.FromFile(new Class1().imageset("frmintoset.txt"));//调用函数，传入存图片路径的文件名
            this.Invalidate(true);
        }

        private void butinto_Click(object sender, EventArgs e)
        {
            if (combstu.Text == "")
                MessageBox.Show("请选择你想进入谁的同学录！");
            else
            {
                Class1 .frmhome1  = new Frmhome();
                
                Class1.home = this.combstu.Text;//把选中的同学的名字保存到全窗体的变量home中，使主页窗体的标题可以显示这个人的名字
               Class1 .frmhome1.ShowDialog(this);
                this.Hide  ();
            }
            
        }

        private void combstu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
