using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    public class MyFigure : Figure
    {
        public PointF[] pointFs;
        public MyFigure()
        {
        }

        public MyFigure( int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public override void MoveTo(int x, int y, Figure figure)
        {

            if (!((this.x + x < 0 && this.y + y < 0) || (this.y + y < 0) || (this.x + x > Init.pictureBox.Width && this.y + y < 0) || (this.x + this.w + x > Init.pictureBox.Width) || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height) || (this.y + this.h + y > Init.pictureBox.Height) || (this.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                DeleteF(this, false);
                Draw();
            }
        }

        public override void Draw()
        {
            Pen line = new Pen(Color.Black, 5);
            Pen line1 = new Pen(Color.White, 5);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(line1, x, y, w, h);
            g.DrawRectangle(line, x, y, w, h/2);
            g.DrawEllipse(line, x, y + + h/2, w / 3, h / 2);
            g.DrawEllipse(line, (x + w) - w / 3, (y + h) - h/2, w / 3, h / 2);
            Init.pictureBox.Image = Init.bitmap;
        }


    }
}
