using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{

        abstract public class Figure
        {


            public int x;
            public int y;
            public int w;
            public int h;


            public virtual void Draw(int x, int y, int w, int h)
            {

            }

            public virtual void MoveTo(int x, int y)
            {
                this.x = x;
                this.y = y;


            }

            public void DeleteF(Figure figure, bool flag = true) { }
        }
    }

