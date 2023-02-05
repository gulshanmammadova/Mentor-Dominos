using MentorFrontToBack.DataAccessLayer;
using MentorFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentorFrontToBack.Controllers
{
    public class TeachersController : Controller
    {
        private readonly AppDbContext _context;
        public TeachersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Teachers> teachers = _context.teachers.ToList();
            return View(teachers);
        }
    }
}
