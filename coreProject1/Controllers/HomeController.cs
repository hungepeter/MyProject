using Microsoft.AspNetCore.Mvc;

namespace coreProject1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.DateTime = System.DateTime.Now.ToString("yyyy/MM/dd");
            ViewBag.test = "test";


            return View();
        }
    }
}
