using Microsoft.AspNetCore.Mvc;

namespace EduTech.Controllers
{
    public class DashboardController : Controller
    {
        [Route("dashboard")]
        public IActionResult Page()
        {
            ViewData["Title"] = "Dashboard";
            return View("Page");
        }
    }
}
