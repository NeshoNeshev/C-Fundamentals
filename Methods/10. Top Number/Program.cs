using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int sum = NumberSum(i);
                bool isDivisible = CheckIfDivisible(sum);
                bool oddFound = CheckForOdd(i);

                if (isDivisible == true && oddFound == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static int NumberSum(int i)
        {
            int sum = 0;

            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }

            return sum;
        }

        static bool CheckIfDivisible(int sum)
        {
            bool isDivisible = false;

            if (sum % 8 == 0)
            {
                isDivisible = true;
            }

            return isDivisible;
        }

        static bool CheckForOdd(int i)
        {
            bool oddFound = false;

            while (i > 0)
            {
                int digit = i % 10;
                i /= 10;

                if (digit % 2 == 1)
                {
                    oddFound = true;
                    break;
                }
            }

            return oddFound;
        }
    }
}
