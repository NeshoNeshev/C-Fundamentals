using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            CharactersInRange(a, b);
        }
        static void CharactersInRange(char start, char end)
        {
            if (start > end)
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write(char.ConvertFromUtf32(i) + " ");
                }
            }
            else
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write(char.ConvertFromUtf32(i) + " ");
                }
            }
        }
    }
}
