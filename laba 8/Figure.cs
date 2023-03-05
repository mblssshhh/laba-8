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
            public int n;


            public virtual void Draw()
            {

            }

            public virtual void MoveTo(int x, int y, Figure figure)
            {
                this.x = x;
                this.y = y;


            }

            public void DeleteF(Figure figure, bool flag = true) 
            {
                
            }
            
        }
}

