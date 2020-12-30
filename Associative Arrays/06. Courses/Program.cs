using System;
using System.Collections.Generic;
using System.Linq;

namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var courseAndStudents = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine().Split(" : ");
                if (input[0] == "end")
                {
                    break;
                }
                string courseName = input[0];
                string studentName = input[1];
                if (!courseAndStudents.ContainsKey(courseName))
                {
                    courseAndStudents.Add(courseName, new List<string>());
                    courseAndStudents[courseName].Add(studentName);
                }
                else
                {
                    courseAndStudents[courseName].Add(studentName);
                }

            }
            foreach (var item in courseAndStudents.OrderByDescending(x => x.Value.Count))
            {

                Console.WriteLine(item.Key + ": " + item.Value.Count);
                foreach (var pair in item.Value.OrderBy(x => x))
                {

                    Console.WriteLine("-- " + pair);
                }
            }
        }
    }
}


