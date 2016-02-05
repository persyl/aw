using Aw.Models;
using System.Web.Mvc;
using System.Web.Caching;
using System;
using System.Web;
using System.Collections.Generic;

namespace Aw.Controllers
{
    public class ApiController : Controller
    {
        [HttpPost]
        public JsonResult Result(QuizAnswer data)
        {
            HttpRuntime.Cache.Insert(string.Format("Deltagare: {0}", data.Contestant), data, null,
                DateTime.Now.AddHours(5), Cache.NoSlidingExpiration);
            return Json(new { ServerResponse = string.Format("Tack {0}, dina svar är nu registrerade.", data.Contestant) }, JsonRequestBehavior.DenyGet);
        }

        [HttpPost]
        public JsonResult Questions()
        {
            var quiz = new QuizQuestions();
            quiz.questions.Add(new QuizQuestion()
            {
                question = "Testfråga 1",
                alternatives = new List<string>() {"Testsvar 1", "Testsvar 2", "Testsvar 3"}
            });

            quiz.questions.Add(new QuizQuestion()
            {
                question = "Testfråga 2",
                alternatives = new List<string>() { "Testsvar 2-1", "Testsvar 2-2", "Testsvar 2-3" }
            });

            return Json(quiz, JsonRequestBehavior.DenyGet);
        }
    }
}