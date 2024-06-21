using Microsoft.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
