using System;
using System.Linq;
using System.Text;


namespace Fundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            while (true)
            {
                var command = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                
                if (command.Contains("Decode"))
                {
                    break;
                }

                if (command.Contains("Move"))
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < text.Length)
                    {
                        StringBuilder sb = new StringBuilder(text);
                        string insert = text.Substring(0, index);
                        sb.Append(insert);
                        sb.Remove(0, index);
                        text = sb.ToString();
                    }
                }
                if (command.Contains("Insert"))
                {
                    int index = int.Parse(command[1]);
                    string value = command[2];
                    if (index >= 0)
                    {
                        text = text.Insert(index, value);
                    }

                }
                if (command.Contains("ChangeAll"))
                {
                    string substring = command[1];
                    string replacement = command[2];
                    if (text.Contains(substring))
                    {
                        text = text.Replace(substring, replacement);
                    }
                }
            }
            Console.WriteLine($"The decrypted message is: {text}");

        }
    }
}


