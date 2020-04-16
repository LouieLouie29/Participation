//Ed Louie
using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleAndCircle
{
    class Circle
    {
        public const double PI = 3.1415926535897931;
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }

        public double CArea()
        {
            return PI * Radius * Radius;
        }

        public double CPerimeter()
        {
            return 2 * PI * Radius;
        }
    }
}
