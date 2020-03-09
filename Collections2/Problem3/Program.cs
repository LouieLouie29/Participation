//Ed Louie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> course = new Dictionary<string, int>();

            string courseName;
            int courseNum;            

            for (int i = 0; i >= 3; i++)
            {
                Console.WriteLine($"Please input a course name.");
                courseName = Console.ReadLine();

                Console.WriteLine($"Please input a course number.");
                courseNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"{courseNum} associates with {courseName}.");
            }


            

            Console.ReadLine();
        }
    }
}
