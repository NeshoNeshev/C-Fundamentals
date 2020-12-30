using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace Fundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string patern = @"(\||#)([a-zA-Z\s]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1([0-9]+)\1";

            List<Item> lst = new List<Item>();

            int calories = 0;
            MatchCollection matches = Regex.Matches(input, patern);
            foreach (Match m in matches)
            {
                if (m.Success)
                {
                    string num = m.Groups[4].Value;
                    calories += int.Parse(num);

                    lst.Add(new Item() { Nutrition = int.Parse(num), Date = m.Groups[3].Value, Food = m.Groups[2].Value });
                }

            }


            Console.WriteLine(string.Format("You have food to last you for: {0} days!", calories / 2000));
            //Item: Bread, Best before: 19/03/21, Nutrition: 4000
            foreach (var item in lst)
            {
                Console.WriteLine($"Item: {item.Food}, Best before: {item.Date}, Nutrition: {item.Nutrition}");
            }
        }
    }
    public class Item
    {
        public string Food;
        public string Date;
        public int Nutrition;
    }
}


