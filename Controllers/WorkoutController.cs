using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    public class WorkoutController : Controller
    {
        public IActionResult List() => View();
        public IActionResult Details(int id) => View();
        public IActionResult Create() => View();
        public IActionResult Edit(int id) => View();
    }
}