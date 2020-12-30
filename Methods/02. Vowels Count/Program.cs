using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            VowelsCount(text);
        }
        static void VowelsCount(string a)
        {
            string text = a;
            text.ToCharArray();
            char[] volvels = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };
            int num = 0;
            foreach (var item in volvels)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (item == text[i])
                    {
                        num++;
                    }
                }
            }
            Console.WriteLine(num);
        }
    }
}
