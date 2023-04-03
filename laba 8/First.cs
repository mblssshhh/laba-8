using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace laba_8
{
    public static class Init
    {
        public static Bitmap bitmap;
        public static PictureBox pictureBox;
        public static Pen pen;

    }
    public class Rectangle : Figure
    {
        public Rectangle(int x, int y, int w, int h, string name)
         {
         this.x = x;
         this.y = y;
         this.w = w;
         this.h = h;
         }
         public Rectangle()
         {
         this.x = 0;
         this.y = 0;
         this.w = 0;
         this.h = 0;
         }
        public override void MoveTo(int x, int y)
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
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawRectangle(line, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }
    }

    public class Elips : Figure
    {
        public override void MoveTo(int x, int y)
        {

            if (!((this.x + x < 0 && this.y + y < 0) || (this.y + y < 0) || (this.x + x > Init.pictureBox.Width && this.y + y < 0) || (this.x + this.w + x > Init.pictureBox.Width) || (this.x + x > Init.pictureBox.Width && this.y + y > Init.pictureBox.Height) || (this.y + this.h + y > Init.pictureBox.Height) || (this.x + x < 0 && this.y + y > Init.pictureBox.Height) || (this.x + x < 0)))
            {
                this.x += x;
                this.y += y;
                DeleteF(this, false);
                Draw();
            }
        }
        public Elips(string name, int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.name = name;
        }
        public Elips()
        {
            this.x = 0;
            this.y = 0;
            this.w = 0;
            this.h = 0;
        }

        public override void Draw()
        {
            Pen line = new Pen(Color.Black, 5);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawEllipse(line, x, y, w, h);
            Init.pictureBox.Image = Init.bitmap;
        }

    }

    public class Polygon : Figure
    {
        public PointF[] pointFs;

        public Polygon(PointF[] pointFs)
        {
            this.pointFs = pointFs;
        }
        public Polygon()
        {
            this.x = 0;
            this.y = 0;
        }
        public void DrawPolygon(System.Drawing.Pen pen, System.Drawing.PointF[] pointFs)
        {
        }
        public override void Draw()
        {
            Pen pol = new Pen(Color.Black, 5);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(pol, pointFs);
            Init.pictureBox.Image = Init.bitmap;
        }
        public override void MoveTo(int x, int y)
        {
            bool fl = true;
            for (int i = 0; i < pointFs.LongLength; i++)
            {
                if ((pointFs[i].X + x < 0 && pointFs[i].Y + y < 0) || (pointFs[i].Y + y < 0) || (pointFs[i].X + x > Init.pictureBox.Width && pointFs[i].Y + y < 0) || (pointFs[i].X + this.w + x > Init.pictureBox.Width) || (pointFs[i].X + x > Init.pictureBox.Width && pointFs[i].Y + y > Init.pictureBox.Height) || (pointFs[i].Y + this.h + y > Init.pictureBox.Height) || (pointFs[i].X + x < 0 && pointFs[i].Y + y > Init.pictureBox.Height) || (pointFs[i].X + x < 0))
                {

                    fl = false; break;
                }
            }
            if (fl == true)
            {
                for (int i = 0; i < pointFs.LongLength; i++)
                {
                    this.pointFs[i].X += x;
                    this.pointFs[i].Y += y;
                }
                DeleteF(this, false);
                Draw();
            }
        }
        

    }

}


