//Ed Louie -- Collaborated w/ Matt Boensch
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students would you like to store?");
            int StoreNumber = Convert.ToInt32(Console.ReadLine());
            string[] FirstName = new string[StoreNumber];
            string[] LastName = new string[StoreNumber];

            for (int i = 0; i < StoreNumber; i++)
            {
                Console.WriteLine($"What is student {i} first name?");
                FirstName[i] = Console.ReadLine();
                Console.WriteLine($"What is student {i} last name?");
                LastName[i] = Console.ReadLine();
            }

            for (int i = 0; i < StoreNumber; i++)
            {
                Console.WriteLine($"{LastName[i]}, {FirstName[i]}");
            }

            Console.ReadKey();

        }
    }
}
