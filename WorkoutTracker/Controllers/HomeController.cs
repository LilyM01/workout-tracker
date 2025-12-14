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

        public IActionResult LogIn(){

            return View();
        }

        [HttpPost]
        public IActionResult LogIn(LogInModel model) 
        {
            return RedirectToAction("Index");
        }

        public IActionResult CreateAccount()
        {

            return View();
        }

        [HttpPost]
        public IActionResult CreateAccount(CreateAccountModel model)
        {
            return RedirectToAction("Login");
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
