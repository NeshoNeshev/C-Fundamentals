using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string[] people = { "baby", "child", "teenager", "adult", "elder" };

            if (age >= 0 && age <= 2)
            {
                Console.WriteLine(people[0]);
            }
            else if (age >= 3 && age <= 13)
            {
                Console.WriteLine(people[1]);
            }
            else if (age >= 14 && age <= 19)
            {
                Console.WriteLine(people[2]);
            }
            else if (age >= 20 && age <= 65)
            {
                Console.WriteLine(people[3]);
            }
            else if (age >= 66)
            {
                Console.WriteLine(people[4]);
            }
        }
    }
}
