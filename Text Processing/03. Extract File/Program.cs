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
            var pathToFile = Console.ReadLine().Split("\\").ToArray();
            var result = pathToFile[pathToFile.Length - 1].Split(".");
            string fileName = result[0];

            string extation = result[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extation}");
        }
       
    }
}


