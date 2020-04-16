//Ed Louie
using System;

namespace Studen1
{
    class Program
    {
        static void Main(string[] args)
        {
            string response;
            string GPA;
            string Hours;

            Student Info = new Student();

            Console.WriteLine("What is your first name?");
            Info.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            Info.LastName = Console.ReadLine();

            do
            {
                Console.WriteLine("What is the name of the class?");
                Info.CourseNames.Add(Console.ReadLine());

                Console.WriteLine("What is your grade in the class?");
                Info.CourseGrades.Add(Console.ReadLine());

                Console.WriteLine("Do you have another class to add?");
                response = Console.ReadLine();

            } while (response.ToUpper() == "YES");

            Console.WriteLine($"{Info.FirstName} {Info.LastName}, your grade for {Info.CourseNames} was {Info.CourseGrades}.");
            Console.WriteLine($"Your overall GPA is {Info.GPACalc()}.");

            Console.ReadKey();
        }
    }
}
