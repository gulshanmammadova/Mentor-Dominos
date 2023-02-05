using MentorFrontToBack.DataAccessLayer;
using MentorFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentorFrontToBack.Controllers
{
    public class AboutPageController : Controller
    {
        private readonly AppDbContext _context;
        public AboutPageController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<AboutPages> aboutpages = _context.aboutpages.ToList();
            return View(aboutpages);
        }
    }
}
