using Aw.Models;
using System.Web.Mvc;

namespace Aw.Controllers
{
    public class ApiController:Controller
    {
        [HttpGet]
        public JsonResult Result()
        {
            var res = new QuizResult() { Contestant = "Per Lundkvist" };
            return Json(res, JsonRequestBehavior.AllowGet);
        }
    }
}