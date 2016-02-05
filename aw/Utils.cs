using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Aw.Models;

namespace Aw
{
    public static class Utils
    {
        public static QuizQuestions Quiz = new QuizQuestions()
        {
            questions = new List<QuizQuestion>()
            {
                new QuizQuestion()
                {
                    question = "Testfråga 1",
                    alternatives = new List<string>() {"Testsvar 1", "Testsvar 2", "Testsvar 3"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Testfråga 2",
                    alternatives = new List<string>() {"Testsvar 2-1", "Testsvar 2-2", "Testsvar 2-3"},
                    correctAlternative = 2
                }
            }
        };
    }
}