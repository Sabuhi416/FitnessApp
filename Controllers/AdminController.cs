using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult ManageUsers() => View();
        public IActionResult ManageWorkouts() => View();
    }
}