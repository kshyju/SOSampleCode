using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOSampleCode.Models;

namespace SOSampleCode.Controllers
{
    public class IndexVm
    {
      
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var vm = new IndexVm() {};
            return View(vm);
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
