using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedFigure
{
    internal class Triangle : Figure, FigureData

    {
        public override void Draw()
        {

        }
        double FigureData.Perimeter()
        {
            return 0;
        }

        double FigureData.Square()
        {
            return 0;
        }
    }
}

  
