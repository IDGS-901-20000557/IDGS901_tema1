using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application";
            ViewBag.Message2 = "Buans noches.";
            string nombre = "";
            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.Nombre = nombre;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}