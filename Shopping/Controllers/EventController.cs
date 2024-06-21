using Microsoft.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
