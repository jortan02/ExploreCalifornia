using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            return new ContentResult { Content = "Blog Posts" };
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int? id)
        {
            if (id == null)
            {
                return new ContentResult { Content = "null" };
            }
            return new ContentResult { Content = id.ToString() };
        }
    }
}
