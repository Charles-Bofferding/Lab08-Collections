using Lab08_Collections.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections.Classes
{
    class Library : ILibrary
    {


        //use this to store books
        private Dictionary<string, Book> TheLibrary = new Dictionary<string, Book>();

        public int Count => TheLibrary.Count;

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            //make a new book
            Book newBook = new Book();
            newBook.Title = title;
            newBook.Author = $"{firstName} {lastName}";
            newBook.NumberOfPages = numberOfPages;

            //add it to the dictionary library
            TheLibrary.Add(title, newBook);
        }

        public Book Borrow(string title)
        {
            //Get the book object from the dictionary
            Book borrowing = TheLibrary[title];
            //Remove that book from the library
            TheLibrary.Remove(title);
            //Return the book
            return borrowing;
        }

        public void Return(Book book)
        {
            TheLibrary.Add(book.Title, book);
        }

        //Gonna be honest, have no idea what is happening here
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in TheLibrary.Values)
            {
                yield return book;
            }

        }

        //Gonna be honest, have no idea what is happening here
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }
}
