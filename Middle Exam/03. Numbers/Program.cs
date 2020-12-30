using System;
using System.Collections.Generic;
using System.Linq;



namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<int> greatersNumbers = new List<int>();
            double average = numbers.Sum();
            double greater = Math.Round(average / numbers.Count(), 2);
            int count = 0;
            bool check = false;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > greater)
                {
                    check = true;
                    count++;
                    greatersNumbers.Add(numbers[i]);
                }
            }
            greatersNumbers.Sort();
            greatersNumbers.Reverse();
            if (count > 5)
            {
                for (int i = greatersNumbers.Count - 1; i >= 5; i--)
                {
                    greatersNumbers.Remove(greatersNumbers[i]);
                }
            }
            if (check == false)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(string.Join(" ", greatersNumbers));
            }
        }
    }
}


