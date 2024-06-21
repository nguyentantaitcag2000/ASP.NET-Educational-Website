using Microsoft.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
