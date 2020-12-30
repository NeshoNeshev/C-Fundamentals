using System;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int capcapacity = 255;
            int result = 0;
            while (number > 0)
            {
                int liters = int.Parse(Console.ReadLine());
                number--;
                capcapacity -= liters;
                result += liters;
                if (capcapacity < 0)
                {
                    result -= liters;
                    capcapacity += liters;
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
            }
            Console.WriteLine(result);
        }
    }
}
