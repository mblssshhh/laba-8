using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_8
{

    public partial class Form1 : Form
    {
        Bitmap bitmap; // = new Bitmap(pictureBox1.ClientSize.Width, pictureBox1.ClientSize.Height);
        Pen pen; // = new Pen(Color.Black, 5);
        static class Init
        {
            public static Bitmap bitmap;
            public static PictureBox pictuteBox;
            public static Pen pen;
        }
        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictuteBox = pictureBox;
            Init.pen = this.pen;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        abstract public class Figure
        {
            public int x;
            public int y;
            public int w;
            public int h;

           
            public void Draw()
            {
                
            }

            public void MoveTo(int x, int y)
            {

            }
        }

        //first level
        public class Rectagle : Figure
        {
            public void DrawRectangle(System.Drawing.Pen pen)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
                g.DrawRectangle(pen, w, h, w, h);
                Init.pictuteBox.Image = Init.bitmap;
            }
        }

        public class Elips : Figure
        {
            public void Draw()
            {

            }
        }

        public class Polygon : Figure
        {

        }

        //second level
        public class Circle : Elips
        {
            
        }

        public class Square : Rectagle
        {

        }

        public class Triangle : Polygon
        {

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (RectagleCheck.Checked)
            {

            }
        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void RectagleCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
