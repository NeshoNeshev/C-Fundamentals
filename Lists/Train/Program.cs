using System;
using System.Collections.Generic;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersOfVagon = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

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
                    int numberPasangers = int.Parse(tocen[1]);
                    numbersOfVagon.Add(numberPasangers);
                }
                else
                {
                    int number = int.Parse(tocen[0]);
                    for (int i = 0; i < numbersOfVagon.Count; i++)
                    {
                        if (numbersOfVagon[i] + number <= maxCapacity)
                        {
                            numbersOfVagon[i] += number;
                            break;
                        }
                        else
                        {


                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbersOfVagon));
        }
       
    }
}

