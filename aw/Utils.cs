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
                    question = "Per har varit utvecklare på Dagens industri i 3 omgångar. När var första gången?",
                    alternatives = new List<string>() {"Aug 1999 som konsult", "Sep 2000 som anställd", "Aug 2000 som konsult"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Per gillar ju gärna tyngre musik. Ett av hans absoluta favoritband är dessa...",
                    alternatives = new List<string>() { "Lamb of God", "Twelve Foot Ninja", "Meshuggah"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Per brygger eget öl hemma i köket som ni tyvärr ej får smaka ikväll. Vad brukar han kalla den?",
                    alternatives = new List<string>() {"PIPA", "LIPA", "KIPA"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Per har varit med i musikvideon till denna låt. Vad heter artisten?",
                    alternatives = new List<string>() {"Avicii", "Sebastian Ingrosso", "Alesso"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Vad hette chefredaktören på Dagens industri under tiden som all utveckling var förlagd på bolaget Bink?",
                    alternatives = new List<string>() {"Christer Mårdbrandt", "Linus Pålsson", "Peter Fellman"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "The Moniker var med i melodifestivalen 2011. Vad heter han egentligen?",
                    alternatives = new List<string>() {"Daniel Karlsson", "Linus Svensson", "Håkan Åström"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Depeche Mode är ett coolt synthband jag är uppvuxen med. Vad heter denna låt?",
                    alternatives = new List<string>() {"Wrong", "Personal Jesus", "Suffer Well"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Per växte upp med denna följetång Falcon Crest på TV. En bitsk huvudperson spelades av Sarah Jane Mayfield, vad hette hennes rollfigur?",
                    alternatives = new List<string>() {"Annie Field", "Stephanie Lawrence", "Angela Channing"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Per växte upp även med denna följetång på TV. Vad hette denna TV-serie?",
                    alternatives = new List<string>() {"Knight Rider", "Automan", "Action man"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Artisten som sjunger heter Stefan Andersson och låten ingår i konceptalbumet Teaterkungen. Men med vilket låt blev han mest känd?",
                    alternatives = new List<string>() {"Follow your leader", "Catch the Moon", "Nothing remains"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Petter är inte bara namnet på en tuff utvecklingschef, det är också namnet på en grym rappare, men vilket år är rapparen Petter född?",
                    alternatives = new List<string>() {"1979", "1974", "1971"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Denna grymma sångerska var med i TV-programmet Så Mycket Bättre och förnyade denna gamla bit. Vad heter hon?",
                    alternatives = new List<string>() {"Sabina Ddumba", "Felicia Andersson", "Aurora De Luz"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Vad heter albumet där denna Avicii-låt finns med på?",
                    alternatives = new List<string>() {"Lonely Together", "Stories", "True"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Nirvana och Smells Like Teen Spirit, men hur såg albumet omslag ut?",
                    alternatives = new List<string>() {"Ett svartvitt foto med en munk som bränner upp sig", "En bebis i en pool med en dollarsedel", "En översminkad kvinna som skjuter i sig heroin"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Ju Mer Dom Spottar heter denna svängiga bit. Han kallar sig Kapten Röd men vad heter han egentligen?",
                    alternatives = new List<string>() {"Björn Axel Tage Nilsson", "Sven Anders Karlsson", "Örjan Danielsson"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Svensk reggae när den är som bäst. Kaliffa Karlsson kör solo i denna låt men vilket band brukar han köra med?",
                    alternatives = new List<string>() {"Robyn", "Hoffmaestro", "General Knas"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Vad heter bandet?",
                    alternatives = new List<string>() {"Weezer", "Oasis", "Limal"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Dynazty gör här en cover på en låt som framfördes av Anna Bergendahl i melodifestivalen 2010, den vann och hamnade i eurovision Song Contest 2010? I vilken stad?",
                    alternatives = new List<string>() {"Dubling", "Zagreb", "Oslo"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Robyn är en svensk världsartist utan dess like men vad man kanske inte känner till om hennes uppväxt är att hon...",
                    alternatives = new List<string>() {"Har bara 3 tår", "Växte upp i ett kringresande teatersällskap", "Är utbildad dykinstruktör"},
                    correctAlternative = 1
                }
            }
        };
    }
}