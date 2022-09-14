using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CombinedFigure
{
    internal class Rectangle : Figure, FigureData
    {
        public new int Width { get; set; }
        public new int Height { get; set; }
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle
            {
                Width = s.Length * 2,
                Height = s.Length
            };
        }
        public override void Draw()
        {
            for (int i = 0; i < Height; i++, WriteLine())
            {
                for (int j = 0; j < Width; j++)
                {
                    Write("*");
                }
            }
            WriteLine();
        }
        public override string ToString()
        {
            return $"Rectangle: Width = {Width},Height = {Height}";
        }

        double FigureData.Square()
        {
            throw new NotImplementedException();
        }

        double FigureData.Perimeter()
        {
            throw new NotImplementedException();
        }

    }
}
