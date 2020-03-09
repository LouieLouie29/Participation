//Ed Louie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] courseNum = new int[3];
            string[] courseName = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Please input a course number.");
                courseNum[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Please input a course abbreviation.");
                courseName[i] = Console.ReadLine();

                //Console.WriteLine($"{courseNum} corresponds with {courseName}.");
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"{courseName[i]}{courseNum[i]}.");
            }

            
           


            Console.ReadKey();
        }
    }
}
