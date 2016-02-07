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
                    question = "Per och sambon Sofia flyttade just hit till denna adress, men var runt Fridhemsplan bodde de innan?",
                    alternatives = new List<string>() {"Sankt Göransgatan 23", "Drottningholmsvägen 4", "Fridhemsgatan 8"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Vad heter sångaren i detta kända hårdrocksband?",
                    alternatives = new List<string>() {"James Hetfield", "Angus Young", "Axl Rose"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Claes-Göran Hederström vann melodifestivalen med denna låt. Vilket år?",
                    alternatives = new List<string>() {"1968", "1972", "1978"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Per har varit med i musikvideon till denna låt. Vad heter artisten?",
                    alternatives = new List<string>() {"Avicii", "Sebastian Ingrosso", "Alesso"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Vad heter artisten?",
                    alternatives = new List<string>() {"Judas Priest", "Accept", "Iron Maiden"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Denna svenska artist var med i melodifestivalen 2011. Vad kallar han sig?",
                    alternatives = new List<string>() {"The Moniker", "The Trooper", "The Saint"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Denna vackra låt är en cover av ett band som är Pers sambo Sofias favoriter. Vad heter bandet?",
                    alternatives = new List<string>() {"Cardigans", "Kent", "Soundtrack of our lives"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Vem har skrivit låten?",
                    alternatives = new List<string>() {"Bruce Springsteen", "Whitney Houston", "Dolly Parton"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Detta är ett svenskt band som Per är uppväxt med och absolut älskar. De gjorde även ett samarbete med Just D - vad heter bandet?",
                    alternatives = new List<string>() {"Clawfinger", "Black Ingvars", "Entombed"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Ett band till som bara måste få plats i denna musiktävling enligt Per är Faith No More. Vad heter låten?",
                    alternatives = new List<string>() {"Slow down", "Easy", "Leaving"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Vilken TV-serie kommer denna låt ifrån?",
                    alternatives = new List<string>() {"Dynasty", "Falcon Crest", "Dallas"},
                    correctAlternative = 2
                }
            }
        };
    }
}