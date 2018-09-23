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

        //Doesn't generate next Id
        public void GenPop()
        {
            var book1 = new Book
            {
                Id = nextId++,
                Title = "Debt: The First 5,000 Years",
                PublishDate = "12/09/2014",
                Author = "David Graeber",
                Catagory = "Nonfiction"
            };
            _books.Add(book1);

            var book2 = new Book
            {
                Id = nextId++,
                Title = "Why Nations Fail",
                PublishDate = "03/20/2012",
                Author = "Daron Acemoglu",
                Catagory = "Nonfiction"
            };
            _books.Add(book2);

            var book3 = new Book
            {
                Id = nextId++,
                Title = "The Three-Body Problem",
                PublishDate = "10/14/2014",
                Author = "Liu Cixin",
                Catagory = "Fiction"
            };
            _books.Add(book3);

            var book4 = new Book
            {
                Id = nextId++,
                Title = "A Scanner Darkly",
                PublishDate = "08/17/1977",
                Author = "Philip K. Dick",
                Catagory = "Fiction"
            };
            _books.Add(book4);
        }

        public void DeleteAll()
        {
            _books.Clear();
        }
    }
}
