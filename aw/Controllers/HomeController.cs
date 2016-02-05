using System.Web.Mvc;

namespace Aw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Headline = "ABC 123 TEST";
            return View();
        }
    }
}