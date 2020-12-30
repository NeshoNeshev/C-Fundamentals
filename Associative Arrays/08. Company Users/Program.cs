using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var companys = new SortedDictionary<string, List<string>>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string name = input.Split(" -> ")[0];
                string id = input.Split(" -> ")[1];
                if (!companys.ContainsKey(name))
                {
                    companys.Add(name, new List<string>());
                    companys[name].Add(id);
                }
                else
                {
                    List<string> ids = companys[name];
                    if (!ids.Contains(id))
                    {
                        companys[name].Add(id);
                    }
                }
            }
            foreach (var pair in companys)
            {
                Console.WriteLine(pair.Key);
                foreach (var id in pair.Value)
                {
                    Console.WriteLine("-- " + id);
                }
            }
        }
    }
}


