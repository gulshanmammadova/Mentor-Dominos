using Microsoft.AspNetCore.Mvc;

namespace MentorFrontToBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
