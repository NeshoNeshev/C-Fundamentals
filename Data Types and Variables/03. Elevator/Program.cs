using System;


namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int result = (int)Math.Ceiling((double)numPeople / capacity);
            Console.WriteLine(result);
        }
    }
}
