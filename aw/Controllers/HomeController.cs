using System.Web.Mvc;

namespace Aw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Headline = "After Work tävling";
            ViewBag.Message = "En simpel frågesport som testar era kunskaper.";
            return View();
        }
    }
}