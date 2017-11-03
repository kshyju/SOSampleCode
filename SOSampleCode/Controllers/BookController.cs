using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SOSampleCode.Models;

namespace SOSampleCode.Controllers
{
    public class BookIndexVm
    {
        public List<Book> Books { set; get; }
    }
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var books = MyMockDataStorage.GetAll();
            var vm = new BookIndexVm() { Books = books };
            return View(vm);
        }

        [HttpPost]
        public ActionResult DeleteAndReturnJson(string name)
        {
            MyMockDataStorage.Remove(new Book() {BookName = name});
           
            return Json(new { status = "success", id = name });
        }

        [HttpPost]
        public ActionResult DeleteAndReturnJList(string name)
        {
            MyMockDataStorage.Remove(new Book() { BookName = name });
            var list = MyMockDataStorage.GetAll();
            return PartialView("_BookList", list);
        }


        [HttpGet]
        public IActionResult AddBook()
        {
            var b = new Book();

            return PartialView("_AddBook", b);
        }

        [HttpGet]
        public IActionResult AddBookWithValidation()
        {
            var b = new Book();

            return PartialView("_AddBookWithValidation", b);
        }

        [HttpPost]
        public IActionResult AddBookAndReturnNewList(Book model)
        {
            if (ModelState.IsValid)
            {
                MyMockDataStorage.Add(model);
                var list = MyMockDataStorage.GetAll();
                return PartialView("_BookList", list);
            }
            return PartialView("_AddBook", model);
        }


    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddBook(Book model)
    {
        if (ModelState.IsValid)
        {
            MyMockDataStorage.Add(model);
                
            return PartialView("_AddedSuccessfully");
        }
        return PartialView("_AddBook", model);
    }
    }
}