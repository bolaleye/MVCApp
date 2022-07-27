using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCApp.Controllers
{
    public class OfficeController : Controller
    {
        public IActionResult Staff()
        {
            OfficeViewModel office = new() 
            { Id = 3, Name = "Sola" };

            return View(office);
        }

        public IActionResult WorkLoad()
        {
            return View();
        }

        public IActionResult Workout()
        {
            return View();
        }
    }
}
