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
        // GET: Result
        public ActionResult Index()
        {
            var currentAnswers = new StringBuilder();
            IDictionaryEnumerator enumerator = HttpRuntime.Cache.GetEnumerator();
            while (enumerator.MoveNext())
            {
                if (enumerator.Key.ToString().StartsWith("Deltagare"))
                {
                    currentAnswers.Append(string.Format("<h2>{0}</h2>", enumerator.Key));
                    var quizAnswer = enumerator.Value as QuizAnswer;
                    if (quizAnswer != null && quizAnswer.Answers.Any())
                    {
                        currentAnswers.Append("<ul>");
                        foreach (var answer in quizAnswer.Answers)
                        {
                            currentAnswers.Append(string.Format("<li>{0}</li>", answer));
                        }
                        currentAnswers.Append("</ul>");
                    }
                }
            }
            ViewBag.Answers = currentAnswers.ToString();
            return View();
        }
    }
}