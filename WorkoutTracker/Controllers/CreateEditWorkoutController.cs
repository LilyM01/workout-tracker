using Microsoft.AspNetCore.Mvc;
using WorkoutTracker.Models;

namespace WorkoutTracker.Controllers
{
    public class CreateEditWorkoutController : Controller
    {
        /*public IActionResult Index()
        {
            return View();
        }*/

        [HttpGet]
        public IActionResult WorkoutForm()
        {
            //get database data here if not new workout

            //if new workout
            WorkoutModel model = new WorkoutModel();
            model.LiftSets = new List<LiftSet>();
            return View(model);
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public IActionResult WorkoutForm(WorkoutModel model)
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
    }
}
