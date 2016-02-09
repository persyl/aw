using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Aw.Models;

namespace Aw.Controllers
{
    public class ResultController : Controller
    {
        // GET: ResultViewModel
        public ActionResult Index()
        {
            IDictionaryEnumerator enumerator = HttpRuntime.Cache.GetEnumerator();
            var viewModel = new ResultViewModel();
            viewModel.ShowResults = HttpRuntime.Cache["showResults"] != null ? bool.Parse(HttpRuntime.Cache["showResults"].ToString()) : false;
            viewModel.Results = new List<Result>();
            while (enumerator.MoveNext())
            {
                if (enumerator.Key.ToString().StartsWith("Deltagare"))
                {
                    var correctAnswers = 0;
                    var contestant = new Result();
                    contestant.Answers = new Dictionary<string, string>();
                    contestant.Contestant = enumerator.Key.ToString();

                    var quizAnswer = enumerator.Value as QuizAnswer;
                    var answerCount = 0;
                    if (quizAnswer != null && quizAnswer.Answers.Any())
                    {
                        foreach (var answer in quizAnswer.Answers)
                        {
                            var correctAltIdx = Utils.Quiz.questions[answerCount].correctAlternative;
                            string image;
                            if (Utils.Quiz.questions[answerCount].alternatives[correctAltIdx] == answer)
                            {
                                correctAnswers++;
                                image = "correct.png";
                            }
                            else
                            {
                                image = "wrong.png";
                            }
                            answerCount++;
                            contestant.Answers.Add(answer, image);
                        }
                        contestant.Total = correctAnswers;
                        viewModel.Results.Add(contestant);
                    }
                }
            }
            return View(viewModel);
        }

        public ActionResult On()
        {
            HttpRuntime.Cache["showResults"] = true;
            return Content("showResults = ON");
        }

        public ActionResult Off()
        {
            HttpRuntime.Cache["showResults"] = false;
            return Content("showResults = OFF");
        }
    }
}