using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();
            char[] character = words.ToCharArray();
            Dictionary<char, int> chars = new Dictionary<char, int>();
            for (int i = 0; i < character.Length; i++)
            {
                if (character[i] == ' ')
                {
                    continue;
                }
                if (chars.ContainsKey(character[i]))
                {
                    chars[character[i]]++;
                }
                else
                {
                    chars.Add(character[i], 1);
                }
            }
            foreach (var item in chars)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}


