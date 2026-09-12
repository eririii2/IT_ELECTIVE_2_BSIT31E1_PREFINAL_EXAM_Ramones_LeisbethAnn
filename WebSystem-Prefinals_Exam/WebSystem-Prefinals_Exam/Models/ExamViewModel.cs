using Microsoft.AspNetCore.Mvc;

namespace WebSystem_Prefinals_Exam.Models
{
    public class ExamViewModel : Controller
    {
        public string StudentName { get; set; } = "";
        public string ClassName { get; set; } = "";
        public string Section { get; set; } = "";

        public List<Question> Questions { get; set; } = new List<Question>();

        public int Score { get; set; }

        public int TotalQuestions => Questions.Count;

        public double Percentage
        {
            get
            {
                if (TotalQuestions == 0)
                    return 0;

                return (double)Score / TotalQuestions * 100;
            }
        }
    }

    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; } = "";

        public List<string> Choices { get; set; } = new List<string>();

        public string CorrectAnswer { get; set; } = "";

        public string SelectedAnswer { get; set; } = "";
    }
}
