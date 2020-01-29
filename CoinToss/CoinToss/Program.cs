//Ed Louie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinToss
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Heads or Tails");
            string guessInputAsString = Console.ReadLine();
            int guessInput;

            if (guessInputAsString == "Heads")
            {
                guessInput = 0;
                Console.WriteLine("You guessed Heads");
            }
            else
            {
                guessInput = 1;
                Console.WriteLine("You guessed Tails");
            }
            Random rand = new Random();
            int randomNumber = rand.Next(0, 2);

            if (randomNumber == 0)
            {
                Console.WriteLine("The coin landed on Heads");
            }
            else
            {
                Console.WriteLine("The coin landed on Tails");
            }
            
            if (guessInput == randomNumber)
            {
                Console.WriteLine("You guessed correctly");
            }
            else
            {
                Console.WriteLine("You guessed incorrectly");
            }


            Console.ReadKey();           
            }
    }
}
