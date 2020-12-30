using System;
using System.Collections.Generic;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine().Split('|').Reverse().ToList();

            List<int> sortedArray = new List<int>();
            foreach (var str in numbers)
            {
                sortedArray.AddRange(str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", sortedArray));
        }
    }
}

