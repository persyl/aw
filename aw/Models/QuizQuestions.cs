using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aw.Models
{
    public class QuizQuestions
    {
        public List<QuizQuestion> questions { get; set; }
    }

    public class QuizQuestion
    {
        public string question { get; set; }
        public List<string> alternatives { get; set; }

        public int correctAlternative { get; set; }
    }
}