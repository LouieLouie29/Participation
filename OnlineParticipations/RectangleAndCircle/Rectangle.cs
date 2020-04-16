using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleAndCircle
{
    class Rectangle
    {
        public double Length { get; set; }

        public double Width { get; set; }

        public Rectangle()
        {
            Width = 0;
            Length = 0;
        }

        public double RArea()
        {
            return Width * Length;
        }

        public double RPerimeter()
        {
            return 2 * (Length + Width);
        }
    }
}
