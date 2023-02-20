using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    public class Circle : Elips
    {
        public override void Draw(int x, int y, int w, int h)
        {
            Pen line = new Pen(Color.Black, 5);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(line, x, y, w, w);
            Init.pictureBox.Image = Init.bitmap;
        }
    }

    public class Square : Rectangle
    {


        public override void Draw(int x, int y, int w, int h)
        {
            Pen line = new Pen(Color.Black, 5);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(line, x, y, w, w);
            Init.pictureBox.Image = Init.bitmap;
        }

    }


    public class Triangle : Polygon
    {

    }
}
