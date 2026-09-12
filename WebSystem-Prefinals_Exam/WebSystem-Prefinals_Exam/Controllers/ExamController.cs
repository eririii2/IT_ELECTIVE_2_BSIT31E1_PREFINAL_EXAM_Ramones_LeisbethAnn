using Microsoft.AspNetCore.Mvc;
using WebSystem_Prefinals_Exam.Models;

namespace WebSystem_Prefinals_Exam.Controllers
{
    public class ExamController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = CreateExam();

            return View(model);
        }

        [HttpPost]
        public IActionResult Submit(ExamViewModel model)
        {
            var exam = CreateExam();

            int score = 0;

            for (int i = 0; i < exam.Questions.Count; i++)
            {
                if (model.Questions != null &&
                    model.Questions.Count > i)
                {
                    exam.Questions[i].SelectedAnswer =
                        model.Questions[i].SelectedAnswer;
                }

                if (exam.Questions[i].SelectedAnswer ==
                    exam.Questions[i].CorrectAnswer)
                {
                    score++;
                }
            }

            exam.StudentName = model.StudentName;
            exam.ClassName = model.ClassName;
            exam.Section = model.Section;
            exam.Score = score;

            return View("Results", exam);
        }

            private ExamViewModel CreateExam()
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
                    CorrectAnswer = "C"
                }
            };
            return model;
        }
    }
}

