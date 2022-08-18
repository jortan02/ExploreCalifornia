using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult { Content = "Home" };
        }
    }
}
