using System;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static int Factorial(int n)
        {
            int fact = 1;
            do
            {
                fact *= n;
                n--;
            } while (n > 0);
            if (fact == 0)
            {
                return fact + 1;
            }
            else
            {
                return fact;
            }

        }
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[] strong = number.ToString().ToCharArray();
            int[] Aint = strong.Select(i => Int32.Parse(i.ToString())).ToArray();
            int result = 0;
            for (int i = 0; i < Aint.Length; i++)
            {
                result += Factorial(Aint[i]);
            }
            if (number == result)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
