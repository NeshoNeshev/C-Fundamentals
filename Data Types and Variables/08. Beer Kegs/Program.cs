using System;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double big = 0;
            string bigModel = "";
            double biger = 0;
            for (int i = 0; i < number; i++)
            {
                string model = Console.ReadLine();
                double rodius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                //π * r^2 * h. 
                big = Math.PI * rodius * rodius * height;
                if (big >= biger)
                {
                    biger = big;
                    bigModel = model;
                }

            }
            Console.WriteLine(bigModel);
        }
    }
}
