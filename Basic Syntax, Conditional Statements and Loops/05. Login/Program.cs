using System;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {

            string userName = Console.ReadLine();
            string[] pass = new string[1];
            bool check = true;
            byte number = 0;
            for (int i = userName.Length - 1; i >= 0; i--)
            {
                pass[0] += userName[i];
            }
            string pasword = (string.Join("", pass));

            do
            {
                string login = Console.ReadLine();

                if (login == pasword)
                {
                    Console.WriteLine($"User {userName} logged in.");
                    check = false;
                }
                else
                {
                    number++;
                    if (number == 4)
                    {
                        Console.WriteLine($"User {userName} blocked!");
                        check = false;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }

            } while (check);
        }
    }
}
