using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BookManager.Models;
using HeyMeow.BookLibrary;

namespace BookManager.Controllers
{
    public class HomeController : Controller
    {
        private static BookRepo _bookLib = new BookRepo();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "A remake of the CCA CarManager with added features.";

            return View();
        }

        public IActionResult GenLib()
        {
            ViewData["Message"] = "This will generate a starting library";

            var book1 = new Book
            {
                Title = "Debt: The First 5,000 Years",
                PublishDate = "12/09/2014",
                Author = "David Graeber",
                Catagory = "Nonfiction"
            };
            _bookLib.Add(book1);

            var book2 = new Book
            {
                Title = "Why Nations Fail",
                PublishDate = "03/20/2012",
                Author = "Daron Acemoglu",
                Catagory = "Nonfiction"
            };
            _bookLib.Add(book2);

            var book3 = new Book
            {
                Title = "The Three-Body Problem",
                PublishDate = "10/14/2014",
                Author = "Liu Cixin",
                Catagory = "Fiction"
            };
            _bookLib.Add(book3);

            var book4 = new Book
            {
                Title = "A Scanner Darkly",
                PublishDate = "08/17/1977",
                Author = "Philip K. Dick",
                Catagory = "Fiction"
            };
            _bookLib.Add(book4);
            return View(book1);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
