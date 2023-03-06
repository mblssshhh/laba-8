using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static laba_8.Form1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace laba_8
{
    public partial class Form2 : Form
    {
        public static PointF[] pointFs;
        public static int x, y, n = 0, r;
        
        public static Polygon polygon;
        public Form2(ref PointF[] pointFs, ref Polygon polygon)
        {
            InitializeComponent();
            //this.polygon = polygon;
           

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }




        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);

            pointFs[n].X = x;
            pointFs[n].Y = y;

            n++;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            polygon = new Polygon(pointFs);
            polygon.Draw();
            ShapeContainer.AddFigure(polygon);
            
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxN.Text != "")
            {



                r = Convert.ToInt32(textBoxN.Text);
                pointFs = new PointF[r];
                button2.Visible = false;
                textBoxN.Enabled = false;
            }
        }

        private void textBoxN_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
