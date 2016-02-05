using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aw.Models
{
    public class QuizQuestions
    {
        public QuizQuestions()
        {
            questions = new List<QuizQuestion>();
        }
        public List<QuizQuestion> questions { get; set; }
    }

    public class QuizQuestion
    {
        public string question { get; set; }
        public List<string> alternatives { get; set; }
    }
}