//Ed Louie
using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> roster = new List<string>();
            roster.Add("Ashlynn Dunbar");
            roster.Add("Paige Anderson");
            roster.Add("Paige Johnson");
            roster.Add("Kylee McLaughlin");
            roster.Add("Hali'a Swartman-Hogan");
            roster.Add("Sanaá Dotson");
            roster.Add("Haley Sanchez");
            roster.Add("Olvia Curtis");
            roster.Add("Keyton Kinley");
            roster.Add("Sarah Maras");
            roster.Add("Abby Butler");
            roster.Add("Sarah Sanders");
            roster.Add("Kira Morikawa");
            roster.Add("Sabrina Simms");
            roster.Add("Aysia Harty");
            roster.Add("Brianna Kadiku");
            roster.Add("Rylie Gregston");

            

            foreach (string item in roster)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
