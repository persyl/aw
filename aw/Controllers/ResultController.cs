using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

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
                if (!enumerator.Key.ToString().StartsWith("_"))
                {
                    currentAnswers.Append(enumerator.Key.ToString() + "<br />");
                }
            }
            ViewBag.Answers = currentAnswers.ToString();
            return View();
        }
    }
}