using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    public class FitnessPlanController : Controller
    {
        public IActionResult List() => View();
        public IActionResult Details(int id) => View();
    }
}