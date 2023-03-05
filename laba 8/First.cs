﻿using System;
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
        public Rectangle(int x, int y, int w, int h)
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
                this.DeleteF(this, false);
                this.Draw();
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
        public Elips(int x, int y, int w, int h)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
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
        PointF[] pointFs;
        public Polygon(PointF[] pointFs)
        {
            this.pointFs = pointFs;
        }
        public Polygon()
        {
            this.x = 0;
            this.y = 0;
            this.n = 0;
        }
        public override void Draw()
        {
            Pen line = new Pen(Color.Black, 5);
            Graphics g = Graphics.FromImage(Init.bitmap);
            g.DrawPolygon(line, pointFs);
            Init.pictureBox.Image = Init.bitmap;
        }
        

    }

}


