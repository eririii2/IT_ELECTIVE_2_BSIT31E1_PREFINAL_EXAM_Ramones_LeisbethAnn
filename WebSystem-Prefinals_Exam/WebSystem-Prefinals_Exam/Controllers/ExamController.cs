using Microsoft.AspNetCore.Mvc;
using WebSystem_Prefinals_Exam.Models;

namespace WebSystem_Prefinals_Exam.Controllers
{
    public class ExamController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new ExamViewModel();

            model.Questions = new List<Question>
            {
                new Question
                {
                    Id = 1,

                    Text = "What is the main problem solved by using a database instead of an in-memory collection?",

                    Choices = new List<string>
                    {
                        "A. It makes C# code shorter",
                        "B. It prevents the application from restarting",
                        "C. It allows data to persist after the application stops",
                        "D. It removes the need for MVC"
                    },

                    SelectedAnswer = "C"
                }
            };

            return View(model);
        }
    }
}