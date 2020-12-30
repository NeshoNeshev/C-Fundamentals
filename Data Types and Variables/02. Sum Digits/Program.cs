using System;


namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            char[] numbers = number.ToString().ToCharArray();
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int value = (int)Char.GetNumericValue(numbers[i]);

                result += value;

            }
            Console.WriteLine(result);
        }
    }
}
