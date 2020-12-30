using System;
using System.Collections.Generic;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> persons = new List<string>();

            for (int i = 0; i < number; i++)
            {
                var person = Console.ReadLine();
                string[] name = person.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                bool check = true;
                if (name[2] == "not")
                {
                    check = false;
                    if (!persons.Contains(name[0]))
                    {
                        Console.WriteLine($"{name[0]} is not in the list!");
                    }
                    if (persons.Contains(name[0]) && name[2] == "not")
                    {
                        persons.Remove(name[0]);
                    }
                    if (persons.Contains(name[0]))
                    {
                        Console.WriteLine($"{name[0]} is already in the list!");
                    }
                }
                if (persons.Contains(name[0]))
                {
                    Console.WriteLine($"{name[0]} is already in the list!");
                }
                else if (check)
                {
                    persons.Add(name[0]);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, persons));

        }
    }
}

