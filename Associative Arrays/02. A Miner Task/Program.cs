using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                int quantyty = int.Parse(Console.ReadLine());
                if (!task.ContainsKey(input))
                {
                    task.Add(input, quantyty);
                }
                else
                {
                    task[input] += quantyty;
                }
            }
            foreach (var pair in task)
            {
                Console.WriteLine(pair.Key + " -> " + pair.Value);
            }
        }
    }
}


