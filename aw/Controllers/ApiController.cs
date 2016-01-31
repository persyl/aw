using Aw.Models;
using System.Web.Mvc;

namespace Aw.Controllers
{
    public class ApiController : Controller
    {
        [HttpPost]
        public JsonResult Result(QuizAnswer data)
        {
            return Json(new { ServerResponse = string.Format("Tack {0}, dina svar är nu registrerade.", data.Contestant) }, JsonRequestBehavior.DenyGet);
        }
    }
}