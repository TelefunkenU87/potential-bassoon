using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HeyMeow.BookLibrary;

namespace BookManager.Controllers
{
    public class BookManagerController : Controller
    {
        private BookRepo _bookLib = new BookRepo();

        // GET: BookManager
        public ActionResult Index()
        {
            return View(_bookLib.ListAll());
        }

        // GET: BookManager/Details/5
        public ActionResult Details(int id)
        {
            return View(_bookLib.GetById(id));
        }

        // GET: BookManager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookManager/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book newBook, IFormCollection collection)
        {
            try
            {
                _bookLib.Add(newBook);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookManager/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_bookLib.GetById(id));
        }

        // POST: BookManager/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book editBook, int id, IFormCollection collection)
        {
            try
            {
                _bookLib.Edit(editBook);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookManager/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_bookLib.GetById(id));
        }

        // POST: BookManager/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _bookLib.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult GenPop()
        {
            _bookLib.GenPop();
            
            //var book1 = new Book
            //{
            //    Title = "Debt: The First 5,000 Years",
            //    PublishDate = "12/09/2014",
            //    Author = "David Graeber",
            //    Catagory = "Nonfiction"
            //};
            //_bookLib.Add(book1);

            //var book2 = new Book
            //{
            //    Title = "Why Nations Fail",
            //    PublishDate = "03/20/2012",
            //    Author = "Daron Acemoglu",
            //    Catagory = "Nonfiction"
            //};
            //_bookLib.Add(book2);

            //var book3 = new Book
            //{
            //    Title = "The Three-Body Problem",
            //    PublishDate = "10/14/2014",
            //    Author = "Liu Cixin",
            //    Catagory = "Fiction"
            //};
            //_bookLib.Add(book3);

            //var book4 = new Book
            //{
            //    Title = "A Scanner Darkly",
            //    PublishDate = "08/17/1977",
            //    Author = "Philip K. Dick",
            //    Catagory = "Fiction"
            //};
            //_bookLib.Add(book4);

            return RedirectToAction("Index");
        }

        public ActionResult ClearListPrompt()
        {
            //_bookLib.DeleteAll();

            //return RedirectToAction("Index");

            return View();
        }

        public ActionResult ClearList()
        {
            _bookLib.DeleteAll();

            return RedirectToAction("Index");

            //return View();
        }
    }
}