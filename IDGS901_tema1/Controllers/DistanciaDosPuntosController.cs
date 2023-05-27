using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class DistanciaDosPuntosController : Controller
    {
        // GET: DisttanciaDosPuntos
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Calculos(DistanciaDosPuntos opera)
        {
            opera.Operacion();
            return View(opera);
        }
    }
}