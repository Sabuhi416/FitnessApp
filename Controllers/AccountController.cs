using Microsoft.AspNetCore.Mvc;

namespace FitnessApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login() => View();
        public IActionResult Register() => View();
    }
}