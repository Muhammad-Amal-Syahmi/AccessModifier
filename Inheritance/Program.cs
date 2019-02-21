using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.Title="Learning C# for Beginner";

            Console.WriteLine($"Book title: {book.Title}");
        }
    }
}
