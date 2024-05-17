using Bilet3.DAL;
using Bilet3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Bilet3.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class DoctorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _environment;

        public DoctorController(AppDbContext context)
        {
           _context = context;
         
        }

     

        public IActionResult Index()
        {
           
            return View(_context.Doctors.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Doctor doctor)
        {
            return RedirectToAction("Index");
        }
      
    }
}
