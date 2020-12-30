using System;
using System.Collections.Generic;
using System.Linq;



namespace Fundamentals
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Composer> composer = new List<Composer>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split("|");
                string piece = input[0];
                string author = input[1];
                string key = input[2];
                if (!composer.Where(x => x.Author == author && x.Piece == piece).Any())
                {
                    composer.Add(new Composer(piece, author, key));
                }
            }
            while (true)
            {
                var comand = Console.ReadLine().Split("|");
                //•	Add|{piece}|{composer}|{key}
                if (comand.Contains("Stop"))
                {
                    break;
                }
                if (comand.Contains("Add"))
                {
                    string piece = comand[1];
                    string author = comand[2];
                    string key = comand[3];
                    if (composer.Where(x => x.Piece == piece).Any())
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        composer.Add(new Composer(piece, author, key));
                        Console.WriteLine($"{piece} by {author} in {key} added to the collection!");
                    }
                }
                //•	Remove|{piece}
                if (comand.Contains("Remove"))
                {
                    string piece = comand[1];
                    var c = composer.Where(x => x.Piece == piece).FirstOrDefault();
                    if (c != null)
                    {
                        composer.Remove(c);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                //•	ChangeKey|{piece}|{new key}
                if (comand.Contains("ChangeKey"))
                {
                    string piece = comand[1];
                    string newKey = comand[2];
                    var c = composer.Where(x => x.Piece == piece).FirstOrDefault();

                    if (c != null)
                    {

                        c.Key = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            var sorted = composer.OrderBy(x => x.Piece).ThenBy(x => x.Author).Select(x => string.Format("{0} -> Composer: {1}, Key: {2}", x.Piece, x.Author, x.Key)).ToList();
            foreach (var item in sorted)
            {
                Console.WriteLine(item);
            }
        }
    }
    public class Composer
    {
        public string Piece { get; set; }
        public string Author { get; set; }
        public string Key { get; set; }
        public Composer(string piece, string author, string key)
        {
            this.Author = author;
            this.Piece = piece;
            this.Key = key;
        }
    }
}


