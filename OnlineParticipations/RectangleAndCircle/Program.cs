//Ed Louie
using System;

namespace RectangleAndCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle();
            rect1.Length = 10;
            rect1.Width = 7;

            Rectangle rect2 = new Rectangle();
            rect2.Length = 5;
            rect2.Width = 6;

            Circle cir1 = new Circle();
            cir1.Radius = 5;

            Circle cir2 = new Circle();
            cir2.Radius = 7;

            Console.WriteLine($"The rectangle with {rect1.Length} length and {rect1.Width} width has an area of {rect1.RArea()}.");
            Console.WriteLine($"The rectangle with {rect1.Length} length and {rect1.Width} width has an perimeter of {rect1.RPerimeter()}.");

            Console.WriteLine($"The rectangle with {rect2.Length} length and {rect2.Width} width has an area of {rect2.RArea()}.");
            Console.WriteLine($"The rectangle with {rect2.Length} length and {rect2.Width} width has an perimeter of {rect2.RPerimeter()}.");

            Console.WriteLine($"The circle with {cir1.Radius} radius has an area of {cir1.CArea()}.");
            Console.WriteLine($"The circle with {cir1.Radius} radius has a perminter of {cir1.CPerimeter()}.");

            Console.WriteLine($"The circle with {cir2.Radius} radius has an area of {cir2.CArea()}.");
            Console.WriteLine($"The circle with {cir2.Radius} radius has a perminter of {cir2.CPerimeter()}.");

            Console.ReadKey();
        }       
       
    }
}
