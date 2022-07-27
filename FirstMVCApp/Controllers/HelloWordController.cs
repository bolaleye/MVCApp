using Microsoft.AspNetCore.Mvc;
using FirstMVCApp.Models;

namespace FirstMVCApp.Controllers
{
    public class HelloWordController : Controller
    {
        private static List<DogViewModel> dogs = new();
        public IActionResult Index()
        {
            
            return View(dogs);
        }
        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
           
            dogs.Add(dogViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult News()
        {
            return View();
        }
    }
}
