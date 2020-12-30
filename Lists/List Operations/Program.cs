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
            returnModifyList(numbers);
        }
        static void returnModifyList(List<int> numbers)
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }
                string[] comand = line.Split();
                if (comand[0] == "Add")
                {
                    int number = int.Parse(comand[1]);
                    numbers.Add(number);

                }
                if (comand[0] == "Remove")
                {
                    int indexToRemoveAt = int.Parse(comand[1]);
                    if (indexToRemoveAt >= 0 && indexToRemoveAt < numbers.Count)
                    {
                        numbers.RemoveAt(indexToRemoveAt);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                if (comand[0] == "Insert")
                {
                    int numberInsert = int.Parse(comand[1]);
                    int indexInsert = int.Parse(comand[2]);
                    if (indexInsert >= 0 && indexInsert < numbers.Count)
                    {
                        numbers.Insert(indexInsert, numberInsert);
                    }
                    else
                    {
                        Console.WriteLine("Invalid index");
                    }
                }
                if (comand[0] == "Shift")
                {
                    int num = int.Parse(comand[2]);
                    if (comand[1] == "left")
                    {
                        for (int i = 0; i < num; i++)
                        {
                            int firstNum = numbers[0];
                            numbers.Add(firstNum);
                            numbers.RemoveAt(0);
                        }
                    }
                    if (comand[1] == "right")
                    {
                        for (int i = 0; i < num; i++)
                        {
                            int lastNum = numbers[numbers.Count - 1];
                            numbers.Insert(0, lastNum);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

