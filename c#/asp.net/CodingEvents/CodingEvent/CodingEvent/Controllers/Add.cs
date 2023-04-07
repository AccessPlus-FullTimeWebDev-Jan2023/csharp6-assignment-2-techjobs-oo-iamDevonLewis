using Microsoft.AspNetCore.Mvc;

namespace CodingEvent.Controllers
{
    public class Add : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create()
        {
            return View();
        }
    }
}
