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
            var input = Console.ReadLine().ToCharArray();
            string encrypted = "";
            foreach (var item in input)
            {
                int asci = (int)item;
                int result = asci + 3;
                char chars = (char)result;
                encrypted += chars.ToString();
            }
            Console.WriteLine(encrypted);
        }
       
    }
}


