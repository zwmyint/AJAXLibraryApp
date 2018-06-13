using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AJAXLibraryLab.Models;

namespace AJAXLibraryLab.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult GetBookByAuthor(string author)
        {
            Library2Entities db = new Library2Entities();
            List<book> ab = db.books.Where(
                a => a.Author.Contains(author)
                ).ToList();
            return Json(ab);
        }

        [HttpPost]
        public ActionResult GetBookByTitle(string title)
        {
            Library2Entities db = new Library2Entities();
            List<book> ab = db.books.Where(
                a => a.Title.Contains(title)
                ).ToList();
            return Json(ab);
        }

        [HttpPost]
        public ActionResult GetBookByYear(int year)
        {
            Library2Entities db = new Library2Entities();
            List<book> ab = db.books.Where(
                    a => a.YearPublished == year
                    ).ToList();
            
            return Json(ab);

        }

        [HttpPost]
        public ActionResult GetBookByPublisher(string publisher)
        {
          Library2Entities   db = new Library2Entities();
            List<book> ab = db.books.Where(
                a => a.Publisher.Contains(publisher)
                ).ToList();
            return Json(ab);
        }
    }
}