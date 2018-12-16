using System;

namespace ThisBase_ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Id = 2;

            ChangeId(book); // call method with book.Id = 1; inside.

            Console.WriteLine(book.Id);
            Console.ReadKey();


            //ThisBase thisbase = new ThisBase();

        }

        static void ChangeId(Book book)
        {
            book.Id = 1;
        }
    }

    class Book
    {
        public int Id { get; set; }
    }
    
}

