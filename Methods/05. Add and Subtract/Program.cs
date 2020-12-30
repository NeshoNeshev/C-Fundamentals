using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberTree = int.Parse(Console.ReadLine());
            SmalestNumber(number, numberTwo, numberTree);
        }
        static void SmalestNumber(int one, int two, int tree)
        {
            int smallNumber = one + two - tree;

            Console.WriteLine(smallNumber);
        }
    }
}
