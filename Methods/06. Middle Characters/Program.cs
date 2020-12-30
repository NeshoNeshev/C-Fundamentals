using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            MidlleCharacter(text);
        }

        static void MidlleCharacter(string text)
        {
            text.ToCharArray();
            string midlleChar = "";

            if (text.Length % 2 != 0)
            {

                for (int i = 0; i < (text.Length + 1) / 2; i++)
                {
                    midlleChar = text[i].ToString();
                }
            }
            else
            {
                for (int i = 0; i < (text.Length + 1) / 2; i++)
                {
                    midlleChar = text[i].ToString() + text[i + 1];
                }
            }

            Console.WriteLine(midlleChar);
        }
    }
}
