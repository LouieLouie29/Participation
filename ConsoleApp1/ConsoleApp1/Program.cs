using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input your favorite number.");
            int FavoriteNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{FavoriteNumber}");

            Console.ReadKey();
        }
    }
}
