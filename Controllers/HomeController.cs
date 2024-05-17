
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bilet3.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}