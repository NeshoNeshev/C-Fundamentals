using System;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
       
        static void Main(string[] args)
        {
            bool isEnded = false;
            double sum = 0;
            while (!isEnded)
            {
                string input = Console.ReadLine();
                if (input == "Start")
                {
                    while (!isEnded)
                    {
                        string product = Console.ReadLine();
                        if (product != "End")
                        {
                            switch (product)
                            {
                                case "Nuts":
                                    if (sum >= 2.0)
                                    {
                                        sum -= 2.0;
                                        Console.WriteLine($"Purchased {product.ToLower()}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }
                                    break;
                                case "Water":
                                    if (sum >= 0.7)
                                    {
                                        sum -= 0.7;
                                        Console.WriteLine($"Purchased {product.ToLower()}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }
                                    break;
                                case "Crisps":
                                    if (sum >= 1.5)
                                    {
                                        sum -= 1.5;
                                        Console.WriteLine($"Purchased {product.ToLower()}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }
                                    break;
                                case "Soda":
                                    if (sum >= 0.8)
                                    {
                                        sum -= 0.8;
                                        Console.WriteLine($"Purchased {product.ToLower()}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }
                                    break;
                                case "Coke":
                                    if (sum >= 1.0)
                                    {
                                        sum -= 1.0;
                                        Console.WriteLine($"Purchased {product.ToLower()}");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry, not enough money");
                                    }
                                    break;

                                default:
                                    Console.WriteLine("Invalid product");
                                    break;
                            }
                        }
                        else
                        {
                            isEnded = true;
                        }
                    }
                }
                if (!isEnded)
                {
                    double money = double.Parse(input);
                    if (money == 0.1 || money == 0.2 || money == 0.5 || money == 1.0 || money == 2.0)
                    {
                        sum += money;
                    }
                    else
                    {
                        Console.WriteLine($"Cannot accept {money}");
                    }
                }
            }
            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}
