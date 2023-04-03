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
        public Circle(string name, int x, int y, int w) : base(name, x, y, w, w)
        {

        }
    }

    public class Square : Rectangle
    {

        public Square(int x, int y, int w) : base(x, y, w, w, "")
        { 
        
        }

    }
}
