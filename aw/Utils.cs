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
                    question = "Jag börjar med att helt enkelt undra vad bandet heter?",
                    alternatives = new List<string>() {"Basement Jaxx", "Chemical Brothers", "Fatboy Slim"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Per gillar ju gärna tyngre musik. Ett av hans absoluta favoritband är dessa...",
                    alternatives = new List<string>() { "Lamb of God", "Twelve Foot Ninja", "Meshuggah"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Bandet har ett namn som låter som endast en person. Vilken land kommer bandet ifrån?",
                    alternatives = new List<string>() {"Sverige", "Norge", "Danmark"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Per körde moped i denna musikvideo. Vad är artistens födelsenamn?",
                    alternatives = new List<string>() {"Ryan", "David", "Alessandro"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "På EN dag skrev sångaren i detta band en låt för en Hollywood-film. Låten spreds på nätet redan innan den släppts via en fildelningsmjukvara. Vilken var filmen?",
                    alternatives = new List<string>() {"Napster", "Mission Impossible II", "Spindlemannen"},
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
                    question = "Per växte även upp med följetången Falcon Crest på TV. En bitsk huvudperson spelades av Sarah Jane Mayfield, vad hette hennes rollfigur?",
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
                    question = "Petter är inte bara namnet på en tuff utvecklingschef på Bonnier News, det är också namnet på en grym rappare, men vilket år är denne rapparen Petter född?",
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
                    question = "Svensk reggae när den är som bäst. Sångaren kör solo i denna låt men vilket band brukar han köra med?",
                    alternatives = new List<string>() {"Robyn", "Hoffmaestro", "General Knas"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Vad heter detta svenska band som satte rapmetal på kartan?",
                    alternatives = new List<string>() {"Clawfinger", "Evergrey", "Bearfoot"},
                    correctAlternative = 0
                },
                new QuizQuestion()
                {
                    question = "Dynazty gör här en cover på en låt som framfördes av Anna Bergendahl i melodifestivalen 2010, den vann och hamnade i eurovision Song Contest 2010? I vilken stad?",
                    alternatives = new List<string>() {"Dublin", "Zagreb", "Oslo"},
                    correctAlternative = 2
                },
                new QuizQuestion()
                {
                    question = "Detta är en svensk världsartist utan dess like men vad man kanske inte känner till om hennes uppväxt är att hon...",
                    alternatives = new List<string>() {"Har bara 3 tår", "Växte upp i ett kringresande teatersällskap", "Är utbildad dykinstruktör"},
                    correctAlternative = 1
                },
                new QuizQuestion()
                {
                    question = "Vad heter bandet som framför denna fantastiska stillsamma ballad 'Bleed'?",
                    alternatives = new List<string>() { "Mitzvah", "Meshuggah", "Metalisha"},
                    correctAlternative = 1
                }
            }
        };
    }
}