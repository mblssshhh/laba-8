using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba_8
{
    static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;

    }
    public class Rectangle : Figure
    {
        public override void Draw(int x, int y, int w, int h)
        {
            Pen line = new Pen(Color.Black, 5);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(line, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }

    public class Elips : Figure
    {
        public override void Draw(int x, int y, int w, int h)
        {
            Pen line = new Pen(Color.Black, 5);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(line, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }

    public class Polygon : Figure
    {

    }
}
