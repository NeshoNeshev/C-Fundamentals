using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (day == "Friday")
            {
                if (typeOfGroup == "Students")
                {
                    price += number * 8.45;
                    if (number >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (typeOfGroup == "Business")
                {

                    if (number >= 100)
                    {
                        number -= 10;
                        price += number * 10.90;
                    }
                    else
                    {
                        price += number * 10.90;
                    }
                }
                else if (typeOfGroup == "Regular")
                {

                    if (number >= 10 && number <= 20)
                    {
                        price += number * (15 * 0.95);
                    }
                    else
                    {
                        price += number * 15;
                    }
                }
            }
            if (day == "Saturday")
            {
                if (typeOfGroup == "Students")
                {
                    price += number * 9.80;
                    if (number >= 30)
                    {
                        price *= 9.80;
                    }
                }
                else if (typeOfGroup == "Business")
                {

                    if (number >= 100)
                    {
                        number -= 10;
                        price += number * 15.60;
                    }
                    else
                    {
                        price += number * 15.60;
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    if (number >= 10 && number <= 20)
                    {
                        price += number * (20 * 0.95);
                    }
                    else
                    {
                        price += number * 20;
                    }
                }
            }
            if (day == "Sunday")
            {
                if (typeOfGroup == "Students")
                {
                    price += number * 10.46;
                    if (number >= 30)
                    {
                        price *= 0.85;
                    }
                }
                else if (typeOfGroup == "Business")
                {
                    if (number >= 100)
                    {
                        number -= 10;
                        price += number * 16;
                    }
                    else
                    {
                        price += number * 16;
                    }
                }
                else if (typeOfGroup == "Regular")
                {
                    if (number >= 10 && number <= 20)
                    {
                        price += number * (22.50 * 0.95);
                    }
                    else
                    {
                        price += number * 22.50;
                    }
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
