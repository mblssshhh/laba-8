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
    public partial class Form2 : Form
    {
        Bitmap bitmap; //= new Bitmap(pictureBox.ClientSize.Width, pictureBox.ClientSize.Height);
        Pen pen = new Pen(Color.Black, 5);
        static class Init
        {
            public static Bitmap bitmap;
            public static PictureBox pictureBoxP;
            public static Pen pen;
        }
        public Form2()
        {
            InitializeComponent();
            this.bitmap = new Bitmap(pictureBoxP.ClientSize.Width, pictureBoxP.ClientSize.Height);
            this.pen = new Pen(Color.Black, 5);
            Init.bitmap = this.bitmap;
            Init.pictureBoxP = pictureBoxP;
            Init.pen = this.pen;
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
            Polygon po = new Polygon();
            po.Draw(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

        }

        private void pictureBoxP_Click(object sender, EventArgs e)
        {

        }
    }
}
