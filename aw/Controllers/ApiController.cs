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
            return Json(Utils.Quiz, JsonRequestBehavior.DenyGet);
        }
    }
}