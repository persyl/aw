﻿using System.Web.Mvc;

namespace Aw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Headline = "After Work tävling";
            return View();
        }
    }
}