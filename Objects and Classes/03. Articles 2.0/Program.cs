using System;
using System.Collections.Generic;
using System.Linq;


namespace Fundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            List<Article> artic = new List<Article>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var comand = Console.ReadLine().Split(", ").ToArray();

                Article article = new Article(comand[0], comand[1], comand[2]);
                artic.Add(article);

            }
            string sort = Console.ReadLine(); ;
            if (sort == "title")
            {
                Console.WriteLine(string.Join(Environment.NewLine, artic.OrderBy(x => x.Title)));
            }
            if (sort == "content")
            {
                Console.WriteLine(string.Join(Environment.NewLine, artic.OrderBy(x => x.Content)));
            }
            if (sort == "author")
            {
                Console.WriteLine(string.Join(Environment.NewLine, artic.OrderBy(x => x.Author)));
            }
        }
    }
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}


