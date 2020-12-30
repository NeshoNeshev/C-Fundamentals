using System;
using System.Collections.Generic;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "end")
                {
                    break;
                }
                else
                {
                    string[] tocen = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    if (tocen[0] == "Delete")
                    {
                        int numberDelete = int.Parse(tocen[1]);
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == numberDelete)
                            {
                                numbers.Remove(numbers[i]);
                            }
                        }
                    }
                    if (tocen[0] == "Insert")
                    {
                        int numberInsert = int.Parse(tocen[1]);
                        int indexInsert = int.Parse(tocen[2]);
                        numbers.Insert(indexInsert, numberInsert);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

