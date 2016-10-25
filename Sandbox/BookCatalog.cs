using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class BookCatalog
    {
        private List<Book> books;

        public BookCatalog()
        {
            books = new List<Book>();
        }

        public void AddBook(Book aBook)
        {
            books.Add(aBook);

            // Add code that can add the given Book object to the list
        }

        public void PrintAllBooks()
        {
            // Add code that can print all books in the list
            // Hint: You will need a repetition statement

            foreach (Book aBook in books)
            {
                //aBook.GetAllInformation();
                Console.WriteLine($"{aBook.GetAllInformation()}");
            }
        }

        public Book LookupBook(string isbn)
        {
            Book matchingBook = null;

            foreach (Book aBook in books)
            {
                if (aBook.GetISBN() == isbn)
                {
                    matchingBook = aBook;
                }                     
            }

            // Add code that will find a book (if any) in the list
            // which has a matching ISBN number. The variable matchingBook
            // should be set to this book
            // Hint: You will need a repetition statement

            return matchingBook;
        }
    }
}
