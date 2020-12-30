using System;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] trains = new int[n];
            int result = 0;
            for (int i = 0; i < trains.Length; i++)
            {
                trains[i] = int.Parse(Console.ReadLine());
                result += trains[i];
            }

            Console.WriteLine(string.Join(" ", trains));
            Console.WriteLine(result);
        }
    }
}
