using MentorFrontToBack.DataAccessLayer;
using MentorFrontToBack.Models;
using Microsoft.AspNetCore.Mvc;

namespace MentorFrontToBack.Controllers
{
    public class CoursesController : Controller
    {
        private readonly AppDbContext _context;
        public CoursesController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
         List<Courses> courses = _context.courses.ToList();
            return View(courses);
        }
    }
}
