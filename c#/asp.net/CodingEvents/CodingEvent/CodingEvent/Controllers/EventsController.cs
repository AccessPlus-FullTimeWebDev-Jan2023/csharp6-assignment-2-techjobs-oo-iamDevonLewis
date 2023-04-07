using CodingEvent.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingEvent.Controllers
{
    public class EventsController : Controller
    {
        static private List<Event> Events = new List<Event>();
//GET: /<Controller>/
        public IActionResult Index()
        {
            ViewBag.events = Events;
            return View();
        }

        [HttpGet("Events/Add")]
        public IActionResult NewEvent()
        {
            return View();
        }

        [HttpPost]
        [Route("/Add")]
        public IActionResult NewEvent(string name, string desc)
        {
            Events.Add(new Event(name, desc));

            return Redirect("/Events");
        }
    }
}
