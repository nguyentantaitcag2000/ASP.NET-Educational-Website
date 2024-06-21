using Microsoft.AspNetCore.Mvc;

namespace Shopping.Controllers
{
    public class ServiceController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
