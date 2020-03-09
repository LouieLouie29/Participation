//Ed Louie
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeveloperInformationMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Do you want to perform a new calculation?");
                answer = Console.ReadLine();

                Console.WriteLine($"Please input your first value.");
                double val1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Please input your second value.");
                double val2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"What would you like to do with these values? e.g. Add, Subtract.");
                response = Console.ReadLine();
                if (response.ToUpper() == "ADD")
                {
                    Console.WriteLine(AddValues);
                }
                else
                {
                    Console.WriteLine("Testing.");
                }

                Console.WriteLine($"Input your first value.");
                double val1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Input your second value.");
                double val2 = Convert.ToDouble(Console.ReadLine());*/

            string answer;
            string response;
            

            do
            {
                            
            Console.WriteLine("Do you want to perform a new calculation?");
            answer = Console.ReadLine();

            if (answer.ToUpper() == "YES")
            {
                Console.WriteLine($"Please input your first value.");
                double val1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Please input your second value.");
                double val2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"What would you like to do with these values? e.g. Add, Subtract.");
                response = Console.ReadLine();
                if (response.ToUpper() == "ADD")
                {
                    double calc = Add(val1, val2);
                    Console.WriteLine(calc);
                }
                else if (response.ToUpper() == "SUBTRACT")
                {
                    double calc = Subtract(val1, val2);
                    Console.WriteLine(calc);
                }
                else if (response.ToUpper() == "MULTIPLY")
                {
                    double calc = Multiple(val1, val2);
                    Console.WriteLine(calc);
                }
                else
                {
                    double calc = Divide(val1, val2);
                    Console.WriteLine(calc);
                }
            }
                else if (answer.ToUpper() != "YES")
                {
                    Console.WriteLine("Do you want to use the results of the previous calculation?");
                    string prevCalc = Console.ReadLine();
                    if (prevCalc.ToUpper() == "YES")
                    {
                        Console.WriteLine($"Please input your first value.");
                        double val1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"Please input your second value.");
                        double val2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine($"What would you like to do with these values? e.g. Add, Subtract.");
                        response = Console.ReadLine();
                        if (response.ToUpper() == "ADD")
                        {
                            double calc = Add(val1, val2);
                            Console.WriteLine(calc);
                        }
                        else if (response.ToUpper() == "SUBTRACT")
                        {
                            double calc = Subtract(val1, val2);
                            Console.WriteLine(calc);
                        }
                        else if (response.ToUpper() == "MULTIPLY")
                        {
                            double calc = Multiple(val1, val2);
                            Console.WriteLine(calc);
                        }
                        else
                        {
                            double calc = Divide(val1, val2);
                            Console.WriteLine(calc);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Thanks for your time.");
                    }
                }
            
            else
            {
                Console.WriteLine("Thanks for your time.");
            }

            } while (answer.ToUpper() == "YES");



            Console.ReadKey();
        }
        static double Add(double val1, double val2)
        {
            return val1 + val2;
        }
        static double Subtract(double value1, double value2)
        {
            return value1 - value2;
        }
        static double Multiple(double num1, double num2)
        {
            return num1 * num2;
        }
        static double Divide(double number1, double number2)
        {
            return number1 / number2;
        }
      
        static void developerInfo(string devName, string classname, string date)
        {
            Console.WriteLine($"{devName} wrote this application for {classname} on {date}.");
            devName = Console.ReadLine();
            classname = Console.ReadLine();
            date = Console.ReadLine();
        }        
    }
}
