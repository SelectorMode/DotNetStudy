using System;

namespace Classes_ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Author author1 = new Author()
            {                               //initialization block
                Name = "Jeffrey Richter",
                Book = "CLT via C#"
            };

            Author author2 = new Author // we can skip parentheses
            {
                Name = "Steve McConell",
                Book = "Code Comlete"
            };

            Console.WriteLine("Name: {0}, Book: {1}", author1.Name, author1.Book);

            Console.WriteLine(new string('-', 40));

            Console.WriteLine("Name: {0}, Book: {1}", author2.Name, author2.Book);

            Console.ReadKey(); 
        }

        public class Author
        {
            string name;
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public string Book { get; set; }

        }

    }
}
