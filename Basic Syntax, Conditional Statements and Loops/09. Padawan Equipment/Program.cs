using System;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
       
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfSabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double belts = 0;
            for (int i = 1; i <= countOfStudents; i++)
            {
                if (i % 6 == 0)
                {
                    belts++;
                }
            }
            double money = 0;
            money = priceOfSabers * (Math.Ceiling(countOfStudents * 1.1)) + priceOfRobes * (countOfStudents) + priceOfBelts * (countOfStudents - belts);

            if (amountOfMoney >= money)
            {
                Console.WriteLine($"The money is enough - it would cost {money:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(money - amountOfMoney):f2}lv more.");
            }
        }
    }
    }
}
