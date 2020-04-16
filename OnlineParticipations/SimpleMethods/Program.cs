//Ed Louie
using System;

namespace SimpleMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string animal = " ";
            Console.WriteLine("Please choose an animal. (Cat, dog, horse)");
            animal = Console.ReadLine();

            Console.WriteLine($"{animal} makes the sound {Speak(animal)}.");

            Console.ReadKey();
        }
        static string Speak(string animal)
        {
            string sound;
            if (animal == "cat")
            {
                sound = "meow";
            }
            else if (animal == "dog")
            {
                sound = "woof";
            }
            else if (animal == "horse")
            {
                sound = "neigh";
            }
            else
            {
                sound = "Sorry, I don't know what animal that is.";                   
            }
            return sound;
        }
    }
}
