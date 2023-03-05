﻿using laba_8;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        PointF[] pointFs;
        Polygon polygon;
       
        public Form1()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBox = pictureBox;
            Init.pen = this.pen;
        }


    public void DeleteF(Figure figure, bool flag = true)
        {
            if (flag == true)
            {
                Graphics g = Graphics.FromImage(Init.bitmap);
             ShapeContainer.figureList.Remove(figure);
             this.Clear();
             Init.pictureBox.Image = Init.bitmap;
             foreach (Figure f in ShapeContainer.figureList)
             {
             f.Draw();
             }
            }
             else
             {
                Graphics g = Graphics.FromImage(Init.bitmap);
                 ShapeContainer.figureList.Remove(figure);
                 this.Clear();
                 pictureBox.Image = Init.bitmap;
                 foreach (Figure f in ShapeContainer.figureList)
                     {
                     f.Draw();
                     }
                 ShapeContainer.figureList.Add(figure);
             }
        }


        public void Clear()
        {
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.Clear(Color.White);
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
                    Rectangle re = new Rectangle(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
                    re.Draw();
                    ShapeContainer.AddFigure(re);

                }
            




            if (checkBoxSquare.Checked == true)
            { 
                
                Square sq = new Square(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text));
                ShapeContainer.AddFigure(sq);
                sq.Draw();
                
            }



            if (checkBoxElips.Checked == true)
            {
                Elips el = new Elips(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text), Convert.ToInt32(textBoxH.Text));
                ShapeContainer.AddFigure(el);
                el.Draw();
            }



            if (checkBoxCircle.Checked == true)
            {
                Circle ci = new Circle(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text), Convert.ToInt32(textBoxW.Text));
                ShapeContainer.AddFigure(ci);
                ci.Draw();
            }



            if (checkBoxPolygon.Checked == true)
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

        private void textBoxW_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxH_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click( object sender, EventArgs e)
        {
            if (RectagleCheck.Checked == true)
            {
                //DeleteF(re, false);
            }
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
                Form ifrm = new Form2(ref pointFs);
                ifrm.Show();
                /*polygon = new Polygon(pointFs);
                polygon.Draw();
                ShapeContainer.AddFigure(polygon);*/
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
            Circle ci1 = new Circle(100, 100, 40);
            Circle ci2 = new Circle(200, 100, 40);
            Rectangle re = new Rectangle(100, 50, 145, 50);

            ci1.Draw();
            ci2.Draw();
            re.Draw();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void move1_TextChanged(object sender, EventArgs e)
        {

        }

        private void move2_TextChanged(object sender, EventArgs e)
        {

        }

        private void moveBut_Click(object sender, EventArgs e)
        {
            if (RectagleCheck.Checked == true)
            {
                //re.MoveTo(Convert.ToInt32(move1.Text), Convert.ToInt32(move2.Text));
            }
        }
    }
}
