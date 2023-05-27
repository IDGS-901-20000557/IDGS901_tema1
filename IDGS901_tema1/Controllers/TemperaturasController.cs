using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TemperaturasController : Controller
    {
        // GET: Temperaturas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Resultados(Grados opera)
        {
            opera.Operacion();
            return View(opera);
        }

    }
}