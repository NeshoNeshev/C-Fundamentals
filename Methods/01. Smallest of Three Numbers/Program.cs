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
            int numberThree = int.Parse(Console.ReadLine());
            SmalestNumber(number, numberTwo, numberThree);
        }
        static void SmalestNumber(int one, int two, int three)
        {
            int smallNumber = 0;
            if (one < two && one < three)
            {
                smallNumber = one;
            }
            else if (two < one && two < three)
            {
                smallNumber = two;
            }
            else
            {
                smallNumber = three;
            }
            Console.WriteLine(smallNumber);
        }
    }
}
