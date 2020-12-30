using System;
using System.Collections.Generic;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadLIstSingleLine();
            returnModifyList(numbers);
        }
        static void returnModifyList(List<int> numbers)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                string[] tocen = line.Split();
                if (tocen[0] == "Add")
                {
                    int number = int.Parse(tocen[1]);
                    numbers.Add(number);

                }
                if (tocen[0] == "Remove")
                {
                    int numberToRemove = int.Parse(tocen[1]);
                    numbers.Remove(numberToRemove);

                }
                if (tocen[0] == "RemoveAt")
                {
                    int numberToRemoveAt = int.Parse(tocen[1]);
                    numbers.RemoveAt(numberToRemoveAt);

                }
                if (tocen[0] == "Insert")
                {
                    int numberInsert = int.Parse(tocen[1]);
                    int indexInsert = int.Parse(tocen[2]);
                    numbers.Insert(indexInsert, numberInsert);
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        static List<int> ReadLIstSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
    }
}

