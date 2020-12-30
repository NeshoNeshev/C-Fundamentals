using System;
using System.Text;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int power = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char curent = input[i];
                if (curent == '>')
                {
                    power += int.Parse(input[i + 1].ToString());
                    sb.Append(curent);
                }
                else if (power == 0)
                {
                    sb.Append(curent);
                }
                else
                {
                    power--;
                }
            }
            Console.WriteLine(sb);
        }
    }
}


