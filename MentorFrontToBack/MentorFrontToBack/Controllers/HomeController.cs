using MentorFrontToBack.DataAccessLayer;
using MentorFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentorFrontToBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context; 
        }

        public IActionResult Index()
        {   
            List<Home>homes=_context.homes.ToList();
            return View(homes);
        }
    }
}
