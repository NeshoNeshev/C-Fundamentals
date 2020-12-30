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
            var text = Console.ReadLine().ToCharArray();

            List<string> strings = new List<string>();
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text[i] != text[i + 1])
                {
                    strings.Add(Convert.ToString(text[i]));
                }
            }
            if (text[text.Length - 2] != text[text.Length - 1])
            {
                strings.Add(Convert.ToString(text[text.Length - 1]));
            }
            else
            {
                strings.Add(Convert.ToString(text[text.Length - 1]));
            }
            Console.WriteLine(string.Join("", strings));
        }
    }
}


