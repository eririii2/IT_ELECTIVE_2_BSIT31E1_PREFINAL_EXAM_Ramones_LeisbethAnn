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
                },

                new Question
                {
                    Id = 2,

                    Text = "Which approach is being used when an existing database is used to generate EF Core entity classes?",

                    Choices = new List<string>
                    {
                        "A. Code-First",
                        "B. Database-First",
                        "C. Model-First",
                        "D. Controller-First"
                    },

                    SelectedAnswer = "B"
                },

                new Question
                {
                    Id = 3,
                    Text = "What is the primary purpose of Entity Framework Core?",
                    Choices = new List<string>
                    {
                        "A. To create HTML pages automatically",
                        "B. To replace the MVC Controller",
                        "C. To map objects in code to relational database data",
                        "D. To replace the C# compiler"
                    },
                    SelectedAnswer = "C"
                },

                new Question
                {
                    Id = 4,
                    Text = "Which EF Core component is primarily responsible for communicating with the database?",
                    Choices = new List<string>
                    {
                        "A. DbContext",
                        "B. DbSetView",
                        "C. ControllerContext",
                        "D. RazorContext"
                    },
                    SelectedAnswer = "A"
                }
            };

            return View(model);
        }
    }
}