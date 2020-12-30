using System;
using System.Collections.Generic;
using System.Linq;


namespace Fundamentals
{

    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Article article = new Article(input[0], input[1], input[2]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var comand = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (comand[0])
                {
                    case "Edit":
                        article.Edit(comand[1]);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(comand[1]);
                        break;
                    case "Rename":
                        article.Rename(comand[1]);
                        break;

                }
            }
            Console.WriteLine(string.Join("", article));
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
        public void Edit(string content)
        {
            this.Content = content;
        }
        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }
        public void Rename(string title)
        {
            this.Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}

