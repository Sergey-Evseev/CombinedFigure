using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedFigure
{
    internal class Triangle : Figure, IFigureData

    {
        public override void Draw()
        {

        }
        double IFigureData.Perimeter()
        {
            return 0;
        }

        double IFigureData.Square()
        {
            return 0;
        }
    }
}

  
