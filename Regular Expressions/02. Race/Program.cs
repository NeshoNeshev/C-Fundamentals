using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"([A-Za-z])";
            string pointsPattern = @"\d";
            Dictionary<string, int> personKm = new Dictionary<string, int>();
            List<string> person = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }
                var nameMatch = Regex.Matches(input, namePattern);
                var kmMatch = Regex.Matches(input, pointsPattern);
                var name = string.Concat(nameMatch);
                var sum = kmMatch.Select(x => int.Parse(x.Value)).Sum();
                if (person.Contains(name))
                {
                    if (!personKm.ContainsKey(name))
                    {
                        personKm.Add(name, sum);
                    }
                    else
                    {
                        personKm[name] += sum;
                    }
                }
            }
            var sorted = personKm.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
            Console.WriteLine($"1st place: {sorted[0]}");
            Console.WriteLine($"2nd place: {sorted[1]}");
            Console.WriteLine($"3rd place: {sorted[2]}");
        }
    }
}


