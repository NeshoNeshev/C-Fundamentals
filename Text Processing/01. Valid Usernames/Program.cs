using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var userName = Console.ReadLine().Split(", ").ToList();
            var validUserName = new List<string>();

            foreach (var item in userName)
            {

                if (item.Length >= 3 && item.Length <= 16)
                {
                    if (Regex.IsMatch(item, @"^[a-zA-Z0-9_-]+$"))
                    {
                        validUserName.Add(item);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, validUserName));
        }
    }
}


