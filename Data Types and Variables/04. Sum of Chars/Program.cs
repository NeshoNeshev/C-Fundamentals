using System;


namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < number; i++)
            {
                char character = char.Parse(Console.ReadLine());
                int value = Convert.ToInt32(character);
                result += value;
            }
            Console.WriteLine($"The sum equals: {result}");
        }
    }
}
