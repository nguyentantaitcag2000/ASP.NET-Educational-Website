using Microsoft.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
