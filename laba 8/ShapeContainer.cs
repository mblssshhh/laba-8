using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba_8
{
    public class ShapeContainer
    {
        public static List<Figure> figureList;
        public ShapeContainer()
        {
            figureList = new List<Figure>();
        }
        public static void AddFigure(Figure figure)
        {
            
            figureList.Add(figure);
        }
        public static Figure FindFigure(string name)
        {
            foreach (Figure figure in figureList)
            {
                if (figure.name == name)
                {
                    return figure;
                }
            }
            return null;
        }
    }

}
