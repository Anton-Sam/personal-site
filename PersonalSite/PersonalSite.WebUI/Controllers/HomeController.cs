using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.WebUI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
