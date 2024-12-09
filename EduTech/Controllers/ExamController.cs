using Microsoft.AspNetCore.Mvc;

namespace EduTech.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult ExamResults()
        {
            ViewData["Title"] = "Tra cứu điểm / Kết quả học tập EduTECH";
            return View("ExamResults");
        }
    }
}
