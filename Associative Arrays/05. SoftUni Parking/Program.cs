using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var parkingValidation = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var validation = Console.ReadLine().Split();
                string comand = validation[0];
                string name = validation[1];

                if (comand == "unregister")
                {
                    if (parkingValidation.ContainsKey(name))
                    {
                        parkingValidation.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
                if (comand == "register")
                {
                    string license = validation[2];
                    if (!parkingValidation.ContainsKey(name))
                    {
                        parkingValidation.Add(name, license);
                        Console.WriteLine($"{name} registered {license} successfully");
                    }
                    else
                    {

                        Console.WriteLine($"ERROR: already registered with plate number {license}");
                    }
                }

            }
            foreach (var pair in parkingValidation)
            {
                Console.WriteLine($"{pair.Key} => {pair.Value}");
            }
        }
    }
}


