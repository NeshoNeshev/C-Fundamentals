using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            PrintNumMatrix(num);
        }
        static void PrintNumMatrix(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.Write(num + " ");
                for (int j = 0; j < num - 1; j++)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
