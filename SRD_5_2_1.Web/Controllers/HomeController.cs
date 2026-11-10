using Microsoft.AspNetCore.Mvc;

namespace SRD_5_2_1.Web;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}