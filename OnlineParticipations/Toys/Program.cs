//Ed Louie
using System;

namespace Toys
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string response;
            Toy Toy1 = new Toy();

            do
            {
                Console.WriteLine("Please input the name of the toy.");
                Toy1.Name.Add(Console.ReadLine());

                Console.WriteLine("What is the price of the toy?");
                Toy1.Price.Add(Console.ReadLine());

                Console.WriteLine("Do you have another toy to add?");
                response = Console.ReadLine();

            } while (response.ToUpper() == "YES");



            Console.ReadKey();
        }
    }
}
