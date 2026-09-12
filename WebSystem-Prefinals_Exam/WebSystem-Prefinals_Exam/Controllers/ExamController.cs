using Microsoft.AspNetCore.Mvc;

namespace WebSystem_Prefinals_Exam.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
