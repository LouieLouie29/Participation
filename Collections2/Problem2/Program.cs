//Ed Louie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            double userGrade;
            List<double> grades = new List<double>();

            
            do
            {
                
                Console.WriteLine($"Please enter your grade.");
                userGrade = Convert.ToDouble(Console.ReadLine());
                double gs = Convert.ToDouble(userGrade);
                grades.Add(gs);

                Console.WriteLine($"Do you have another grade to input?");
                answer = Console.ReadLine();                
               
            } while (answer.ToUpper() == "YES");

            double sum = userGrade;            

            double averageGrade = sum / grades.Count;

            Console.WriteLine(averageGrade);


            Console.ReadKey();
        }
    }
}
