using MentorFrontToBack.DataAccessLayer;
using MentorFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentorFrontToBack.Controllers
{
    public class EventsPageController : Controller
    {
        private readonly AppDbContext _context;
        public EventsPageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<EventsPage> eventsPages = _context.eventsPages.ToList();
            return View(eventsPages);
        }
    }
}
