using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            double start = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Factorial(start, second);

        }

        static void Factorial(double start, double end)
        {
            double result = 1;
            double secondResult = 1;
            if (start == 0)
            {
                result = 1;
            }

            for (double i = start; i > 1; i--)
            {
                result *= i;
            }

            for (double i = end; i > 1; i--)
            {
                secondResult *= i;
            }

            Console.WriteLine($"{(result) / secondResult:f2}");
        }
    }
}
