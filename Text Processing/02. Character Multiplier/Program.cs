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
            var words = Console.ReadLine().Split().ToArray();
            int result = CharSum(words);
            Console.WriteLine(result);
        }
        static int CharSum(string[] words)
        {
            var firstWord = words[0].ToCharArray();
            var secondWord = words[1].ToCharArray();

            int firstLenght = firstWord.Length;
            int secondLenght = secondWord.Length;
            int result = 0;
            if (firstLenght > secondLenght)
            {
                for (int i = 0; i < secondLenght; i++)
                {
                    result += ((int)firstWord[i]) * ((int)secondWord[i]);
                }
                for (int i = secondLenght; i < firstLenght; i++)
                {
                    result += (int)firstWord[i];
                }
            }
            if (secondLenght > firstLenght)
            {
                for (int i = 0; i < firstLenght; i++)
                {
                    result += ((int)firstWord[i]) * ((int)secondWord[i]);
                }
                for (int i = firstLenght; i < secondLenght; i++)
                {
                    result += ((int)secondWord[i]);
                }
            }
            if (firstLenght == secondLenght)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    result += ((int)firstWord[i]) * ((int)secondWord[i]);
                }
            }
            return result;
        }
    }
}


