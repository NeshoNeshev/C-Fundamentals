using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, Produckt>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "buy")
                {
                    break;
                }
                string[] splitedInput = input.Split();
                string name = splitedInput[0];
                double price = double.Parse(splitedInput[1]);
                int quantyty = int.Parse(splitedInput[2]);

                Produckt produckt = new Produckt(name, price, quantyty);
                if (!products.ContainsKey(name))
                {
                    products.Add(name, produckt);
                }
                else
                {
                    products[name].Price = price;
                    products[name].Quantity += quantyty;
                }
            }
            foreach (var pair in products)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value.Price * pair.Value.Quantity:f2}");
            }
        }
    }
    public class Produckt
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Produckt(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
    }
}


