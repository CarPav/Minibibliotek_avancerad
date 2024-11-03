using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Minibibliotek_avancerad
{
    public class Library
    {
        public List<Book> allBooks = new List<Book>();
        public List<Author> allAuthors = new List<Author>();
        public void AddNewBook(List<Book> allBooks)
        {
            Console.Write("Bokens titel: ");
            string addBookTitle = Console.ReadLine()!;

            Console.Write("Bokens ID-nummer: ");
            int addBookID =Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Bokens författare: ");
            string addBookAuthor = Console.ReadLine()!;

            Console.Write("Bokens publiceringsår: ");
            int addBookYear = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Bokens ISBN-nummer: ");
            int addBookISBN = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Ge boken ett betyg: ");
            int addBookRating = Convert.ToInt32(Console.ReadLine()!);
            List<int> bookReviews = new List<int>();
            bookReviews.Add(addBookRating);

            allBooks.Add(new Book(addBookTitle, addBookID, addBookAuthor, addBookYear, addBookISBN, bookReviews));
        }
        public void AddNewAuthor()
        {

        }
        public void UpdateBook()
        {

        }
        public void UpdateAuthor()
        {

        }
        public void RemoveBook()
        {

        }
        public void RemoveAuthor()
        {

        }
        public void ListAllBooksAndAuthors(List<Book> allBooks)
        {
            Console.WriteLine("Vilken lista vill du visa?");
            Console.WriteLine("1. Alla böcker?");
            Console.WriteLine("2. Alla författare");

            string userOptionShow = Console.ReadLine();
            switch (userOptionShow)
            {
                case "1":
                    var sortedBooks = allBooks.OrderBy(book => book.Title);
                    Console.WriteLine("Här är alla böcker i alfabetisk ordning");

                    foreach (var book in sortedBooks)
                    {
                        Console.WriteLine("BÖCKER");
                        Console.WriteLine($"Titel: {book.Title}");
                        Console.WriteLine($"ID: {book.ID}");
                        Console.WriteLine($"Författare: {book.Author}");
                        Console.WriteLine($"Publiceringsår: {book.YearPublished}");
                        Console.WriteLine($"ISBN: {book.ISBN}");
                        Console.WriteLine($"Betyg: {book.Reviews}");
                    }
                    break;

            }

        }
        public void SearchAndFilterBooks()
        {

        }

    }
}
