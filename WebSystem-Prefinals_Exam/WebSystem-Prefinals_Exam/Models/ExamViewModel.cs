using Microsoft.AspNetCore.Mvc;

namespace WebSystem_Prefinals_Exam.Models
{
    public class ExamViewModel
    {
        public string StudentName { get; set; } = "Leisbeth Ann B. Ramones";
        public string ClassName { get; set; } = "BSIT";
        public string Section { get; set; } = "31E1";

        public List<Question> Questions { get; set; } = new List<Question>();
    }

    public class Question
    {
        public int Id { get; set; }

        public string Text { get; set; } = "";

        public List<string> Choices { get; set; } = new List<string>();

        public string SelectedAnswer { get; set; } = "";
    }
}
