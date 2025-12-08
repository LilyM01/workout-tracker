using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Models;

namespace WorkoutTracker.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateWorkout()
        {
            var model = new WorkoutModel();

            return View(model);
        }

        [HttpPost]
        public IActionResult CreateWorkout(WorkoutModel model)
        {
            /*
            if (ModelState.IsValid)
            {
                //save to database here
            } else {
                //catch error
            }*/

            return RedirectToAction("Workouts");
        }

        public IActionResult Workouts() 
        {
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
    }
}
