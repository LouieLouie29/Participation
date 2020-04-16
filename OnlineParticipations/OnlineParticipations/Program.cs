//Ed Louie
using System;

namespace OnlineParticipations
{
    class Program
    {
        static void Main(string[] args, object speak)
        {
            string animal = " ";
            Console.WriteLine("Please input whether your animal is a dog, cat, or horse.");
            animal = Console.ReadLine();           
            
            Console.WriteLine($"{animal} makes the noise {Speak(animal)}.");

            Console.ReadKey();
        }

    }

    static string Speak(string animal)
    {
        if (animal == "dog")
        {
            return "woof";
        }
        else if (animal == "cat")
        {
            return "meow";
        }
        else if (animal == "horse")
        {
            return "neigh";
        }
        else
            return "Sorry, I don't know what animal that is.";
    }
    
}
