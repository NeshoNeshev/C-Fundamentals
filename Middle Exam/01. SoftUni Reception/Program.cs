using System;
using System.Collections.Generic;
using System.Linq;



namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());

            int peoplePerHour = first + second + third;
            int hours = 0;
            while (people > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                people -= peoplePerHour;
            }
            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}


