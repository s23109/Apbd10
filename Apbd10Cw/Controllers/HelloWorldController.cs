using Microsoft.AspNetCore.Mvc;

namespace Apbd10Cw.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
