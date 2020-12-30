using System;


namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int four = int.Parse(Console.ReadLine());

            double result = 0.0;
            result = (((first + second) / third) * four);
            Console.WriteLine(result);
        }
    }
}
