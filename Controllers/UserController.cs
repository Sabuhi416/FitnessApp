using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Dashboard() => View();
        public IActionResult Profile() => View();
    }
}