using System;


namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            string result = "";
            for (int i = start; i <= stop; i++)
            {
                char value = Convert.ToChar(i);
                result += value + " ";
            }
            Console.Write(result);
        }
    }
}
