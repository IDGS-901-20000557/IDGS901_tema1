using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class NuevoController : Controller
    {
        // GET: Nuevo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult OperaBas(String n1, String n2, String bandera)
        {
            double res=0;
            if (bandera == "1") {
                res = Convert.ToInt16(n1) * Convert.ToInt16(n2);
            }else if (bandera == "2")
            {
                res = Convert.ToInt16(n1) / Convert.ToInt16(n2);
            }
            else if (bandera == "3")
            {
                res = Convert.ToInt16(n1) + Convert.ToInt16(n2);
            }
            else if (bandera == "4")
            {
                res = Convert.ToInt16(n1) - Convert.ToInt16(n2);
            }
            ViewBag.Res = res;
            return View();
        }

       

        public ActionResult Calculos(OperaBas opera, String bandera)
        {
            opera.decision(bandera);

            return View(opera);
        }

        public ActionResult MuestraPulques()
        {
            var pulquesService = new PulquesServices();

            var model = pulquesService.ObtenerPulque();


            return View(model);
        }
    }
}