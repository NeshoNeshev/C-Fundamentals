using System;
using System.Collections.Generic;
using System.Linq;



namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            while (true)
            {
                var comand = Console.ReadLine().Split(" ");
                if (comand[0] == "end")
                {
                    break;
                }
                if (comand[0] == "decrease")
                {
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] -= 1;
                    }
                    continue;
                }
                int firtsIndex = int.Parse(comand[1]);
                int secondIndex = int.Parse(comand[2]);
                if (comand[0] == "swap")
                {
                    int indexZero = numbers[firtsIndex];
                    int indexOne = numbers[secondIndex];
                    numbers[firtsIndex] = indexOne;
                    numbers[secondIndex] = indexZero;
                }
                if (comand[0] == "multiply")
                {
                    int index = numbers[firtsIndex] * numbers[secondIndex];
                    numbers[firtsIndex] = index;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}


