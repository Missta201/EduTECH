using Microsoft.AspNetCore.Mvc;

namespace EduTech.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
