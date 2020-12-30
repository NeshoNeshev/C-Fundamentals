using System;
using System.Collections.Generic;
using System.Linq;


namespace Fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = ReadLIstSingleLine();
            var second = ReadLIstSingleLine();
            Console.WriteLine(string.Join(" ", MergelIst(first, second)));

        }
        static List<int> MergelIst(List<int> first, List<int> second)
        {

            int count = Math.Max(first.Count, second.Count);
            List<int> merge = new List<int>();

            for (int i = 0; i < count; i++)
            {
                if (first.Count > i)
                {
                    merge.Add(first[i]);
                }
                if (second.Count > i)
                {
                    merge.Add(second[i]);
                }
            }

            return merge;
        }
        static List<int> ReadLIstSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
    }
}

