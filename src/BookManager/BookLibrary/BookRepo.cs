using System;
using System.Collections.Generic;
using System.Text;
using HeyMeow.BookLibrary;

namespace HeyMeow.BookLibrary
{
    public class BookRepo
    {
        private static List<Book> _books = new List<Book>();
        private static int nextId = 0;

        public List<Book> ListAll()
        {
            return _books;
        }

        public Book GetById(int id)
        {
            return _books.Find(Book => Book.Id == id);
        }

        public void Add(Book newBook)
        {
            newBook.Id = nextId++;
            _books.Add(newBook);
        }

        public void Edit(Book editBook)
        {
            var originalBook = GetById(editBook.Id);

            originalBook.Title = editBook.Title;
            originalBook.PublishDate = editBook.PublishDate;
            originalBook.Author = editBook.Author;
            originalBook.Catagory = editBook.Catagory;
        }

        public void Delete(int id)
        {
            var bookToDelete = GetById(id);

            _books.Remove(bookToDelete);
        }
    }
}
