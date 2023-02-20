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

namespace laba_8
{

    public partial class Form1 : Form
    {
        Bitmap bitmap; //= new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
        Pen pen = new Pen(Color.Black, 5);
        ShapeContainer shapeContainer;
        static class Init
        {
            public static Bitmap bitmap;
            public static PictureBox pictureBox;
            public static Pen pen;
            
        }
        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox;
            Init.pen = this.pen;
            ShapeContainer shapeContainer = new ShapeContainer();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
        private void button1_Click(object sender, EventArgs e)
        {

            if (RectagleCheck.Checked == true)
            {
                Rectangle re = new Rectangle();
                ShapeContainer.AddFigure(re);
                re.Draw(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
            }



            if (checkBoxSquare.Checked == true)
            { 
                
                Square sq = new Square();
               ShapeContainer.AddFigure(sq);
                sq.Draw(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
                 
            }



            if (checkBoxElips.Checked == true)
            {
                Elips el = new Elips();
                el.Draw(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
            }



            if (checkBoxCircle.Checked == true)
            {
                Circle ci = new Circle();
                ci.Draw(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
            }



            if (checkBoxPolygon.Checked == true)
            {
                Polygon po = new Polygon();
                po.Draw(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
            }



            if (checkBoxTriangle.Checked == true)
            {
                Rectangle r = new Rectangle();
                r.Draw(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
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

        private void textBoxW_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
        }

        private void checkBoxSquare_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxElips_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCircle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPolygon_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPolygon.Checked == true)
            {
                Form ifrm = new Form2();
                ifrm.Show();
            }
            
        }


        private void checkBoxTriangle_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonMy_Click(object sender, EventArgs e)
        {
            Circle ci = new Circle();
            Rectangle re = new Rectangle();
            ci.Draw(100, 100, 40, 40);
            ci.Draw(200, 100, 40, 40);
            re.Draw(85, 50, 180, 50);
        }
    }
}
