//Ed Louie
using System;

namespace TextBox
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBox tb1 = new TextBox();
            tb1.Padding = 15;
            tb1.BackColor = ConsoleColor.White;
            tb1.ForeColor = ConsoleColor.Red;            
            tb1.Text = ($"The BackColor is {tb1.BackColor} and the ForeColor is {tb1.ForeColor}.");

            Console.WriteLine(tb1.Text.PadLeft(15, '-'));
            
           
            TextBox tb2 = new TextBox();
            tb2.Padding = 9;
            tb2.BackColor = ConsoleColor.Blue;
            tb2.ForeColor = ConsoleColor.White;
            tb2.Text = ($"The BackColor is {tb2.BackColor} and the ForeColor is {tb2.ForeColor}.");

            Console.WriteLine(tb2.Text.PadLeft(9, '-'));                          

            Console.ReadKey();
        }
        
    }
}
