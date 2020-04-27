//Ed Louie -- Collaborated w/ Matt Boensch
using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> category = new Dictionary<string, List<string>>();
            List<string> Fruit = new List<string>();
            Fruit.Add("Apple");
            Fruit.Add("Orange");
            Fruit.Add("Grape");

            List<string> Meat = new List<string>();
            Meat.Add("Beef");
            Meat.Add("Chicken");
            Meat.Add("Pork");

            List<string> Pasta = new List<string>();
            Pasta.Add("Spaghetti");
            Pasta.Add("Macaroni");
            Pasta.Add("Linguini");

            category.Add("FRUIT", Fruit);
            category.Add("MEAT", Meat);
            category.Add("PASTA", Pasta);

            Console.WriteLine("Are you going to add another category or another food?");
            string answer = Console.ReadLine();

            while (answer.ToUpper() == "YES")
            {
                Console.WriteLine("Is this a category, or a food?");
                string response = Console.ReadLine();

                if (response.ToUpper() == "CATEGORY")
                {
                    Console.WriteLine("What category would you like to add?");
                    string key = Console.ReadLine();

                    bool keyExists = category.ContainsKey(key);
                    if (keyExists)
                    {
                        Console.WriteLine("Sorry, this category already exists.");
                    }
                    else
                    {
                        List<string> newList = new List<string>();
                        category.Add(key.ToUpper(), newList);

                    }
                }
                else if (response.ToUpper() == "FOOD")
                {
                    Console.WriteLine("What food would you like to add?");
                    string food = Console.ReadLine();
                    Console.WriteLine("What kind of food is this?");
                    string newRes = Console.ReadLine();


                    if (category.ContainsKey(newRes))
                    {
                        category[newRes.ToUpper()].Add(food.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine("Sorry, this food does not fit into a given category.");
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you didn't give a correct response. :(");
                }


                Console.WriteLine("Do you have another category or food to add?");
                answer = Console.ReadLine();

            }

            var keyList = new List<string>(category.Keys);
            Console.WriteLine("Here are the categories.");
            foreach (string item in keyList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Which category would you like to see?");
            string catRes = Console.ReadLine();

            var catList = category[catRes.ToUpper()];
            
            foreach (string item in catList)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();

        }
    }
}
