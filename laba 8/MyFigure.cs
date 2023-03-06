using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    public class MyFigure : Figure
    {
        public MyFigure()
        {
        }

        public MyFigure(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        void DrawMy()
        {
            int x = 100;
            int y = 100;
            int w = 100;
            int h = 100;
            Circle ci1 = new Circle((x + w) - w / 3, y / 18 + h, w / 3);
            Circle ci2 = new Circle(x, y / 18 + h, w / 3);
            Rectangle re = new Rectangle(x, y / 2, w, h / 2);

            ci1.Draw();
            ci2.Draw();
            re.Draw();
        }
        public class Elips : MyFigure
        {
            public Elips(int x, int y, int w, int h)
            {
                this.x = x;
                this.y = y;
                this.w = w;
                this.h = h;
            }

            public override void Draw()
            {
                Pen line = new Pen(Color.Black, 5);
                Graphics g = Graphics.FromImage(Init.bitmap);
                g.DrawEllipse(line, x, y, w, h);
                Init.pictureBox.Image = Init.bitmap;
            }

        }
        public class Rectangle : MyFigure
        {
            public Rectangle(int x, int y, int w, int h)
            {
                this.x = x;
                this.y = y;
                this.w = w;
                this.h = h;
            }


            public override void Draw()
            {
                Pen line = new Pen(Color.Black, 5);
                Graphics g = Graphics.FromImage(Init.bitmap);
                g.DrawRectangle(line, x, y, w, h);
                Init.pictureBox.Image = Init.bitmap;
            }
        }

    }
}
