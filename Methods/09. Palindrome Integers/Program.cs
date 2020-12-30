using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            SymetricNUmber();

        }
        static void SymetricNUmber()
        {
            while (true)
            {
                string number = Console.ReadLine();
                if (number == "END")
                {
                    break;
                }
                number.ToCharArray();
                bool symmetric = true;
                int num = number.Length;
                for (int i = 0; i < number.Length / 2; i++)
                {
                    if (number[i] != number[num - i - 1])

                    {
                        symmetric = false;
                    }
                }
                if (symmetric)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
