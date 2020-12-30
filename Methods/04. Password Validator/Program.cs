using System;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string pasword = Console.ReadLine();
            PassValidator(pasword);
        }
        static void PassValidator(string pass)
        {
            string pasword = pass;
            pasword.ToCharArray();
            int number = 0;
            int character = 0;
            bool isValid = true;
            bool check = true;
            for (int i = 0; i < pasword.Length; i++)
            {
                if (pasword[i] >= 48 && pasword[i] <= 57)
                {
                    number++;
                }
                else if ((pasword[i] >= 65 && pasword[i] <= 90))
                {
                    character++;
                }
                else if ((pasword[i] >= 97 && pasword[i] <= 122))
                {
                    character++;
                }
                else
                {
                    isValid = false;
                }
            }
            if (pasword.Length < 6 || pasword.Length > 10)
            {
                check = false;
                Console.WriteLine("Password must be between 6 and 10 characters ");
            }
            if (isValid == false)
            {
                check = false;
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (number < 2)
            {
                check = false;
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isValid && check)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
