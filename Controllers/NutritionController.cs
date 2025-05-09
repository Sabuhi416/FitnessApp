using Microsoft.AspNetCore.Mvc;

public class NutritionController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult CreatePlan()
    {
        return View();
    }

    public IActionResult TrackMacros()
    {
        return View();
    }

    public IActionResult Recipes()
    {
        return View();
    }
}