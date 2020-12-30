using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @">>(?<furniture>[A-Z-a-z]+)<<(?<price>[\d+\.?\d*]+)!(?<quantity>\d+)";
            List<string> furniture = new List<string>();
            double price = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
                var match = Regex.Match(input, patern);
                if (match.Success)
                {
                    furniture.Add(match.Groups[1].Value);
                    price += double.Parse(match.Groups[2].Value) *
                             double.Parse(match.Groups[3].Value);
                }
            }
            Console.WriteLine("Bought furniture:");
            if (furniture.Count > 0)
            {

                Console.WriteLine(string.Join(Environment.NewLine, furniture));
            }
            Console.WriteLine($"Total money spend: {price:f2}");
        }
    }
}


