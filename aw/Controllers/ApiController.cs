using Aw.Models;
using System.Web.Mvc;

namespace Aw.Controllers
{
    public class ApiController:Controller
    {
        [HttpPost]
        public JsonResult Result(QuizAnswer data)
        {
            return Json(new { ServerResponse = $"Tack {data.Contestant}, dina svar är nu registrerade" }, JsonRequestBehavior.DenyGet);
        }
    }
}