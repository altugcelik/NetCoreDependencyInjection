using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NetCoreDependencyInjection.Interfaces;
using NetCoreDependencyInjection.Models;

namespace NetCoreDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        IBook _book;
        IComment _comment;
        IUser _user;

        public HomeController(IBook book, IComment comment, IUser user)
        {
            _book = book;
            _comment = comment;
            _user = user;
        }

        public IActionResult Index()
        {
            var b = _book.GetBooks();
            var c = _comment.GetComments();
            var u = _user.Getuser();
            var d = _book.deneme();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

        public ActionResult GetBook()
        {
            return View();
        }
    }
}
