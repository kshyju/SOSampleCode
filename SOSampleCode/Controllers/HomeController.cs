using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOSampleCode.Models;

namespace SOSampleCode.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddBook()
        {
            var b = new Book();

            return PartialView("_AddBook", b);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddBook(Book model)
        {
            if (ModelState.IsValid)
            {
                // If it is an ajax request, send the partial view which has javascript which does the redirection

                return PartialView("_AddedSuccessfully");
                // return RedirectToAction("Index");
            }

            return PartialView("_AddBook", model);
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

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
