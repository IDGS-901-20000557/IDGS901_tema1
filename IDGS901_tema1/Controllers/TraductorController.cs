using IDGS901_tema1.Models;
using IDGS901_tema1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TraductorController : Controller
    {
        // GET: Traductor
        public ActionResult Registrar()
        {
            return View();
        }
        public ActionResult Traductor()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Traductor(traductor tra)
        {
            var arch = new LeerTraductorServices();
           Array arreglo = arch.Leerarchivo();
            string palabraduda = char.ToUpper(tra.espanniol[0]) + tra.espanniol.Substring(1).ToLower();
            if (tra.eleccion == "1")
            {
                foreach(string item in arreglo)
                {
                    string[] palabra = item.Split(',');
                  
                    if (palabra[0].Equals(palabraduda))
                    {
                        ViewBag.resultado = palabra[1];
                    }
                    else
                    {
                        ViewBag.resultado = "No se encontraron resultados";
                    }

                    }
            }
            else
            {
                foreach (string item in arreglo)
                {
                    string[] palabra = item.Split(',');

                    if (palabra[1].Equals(palabraduda))
                    {
                        ViewBag.resultado = palabra[0];
                    }
                    else
                    {
                        ViewBag.resultado = "No se encontraron resultados";
                    }

                }
            }

            return View();
        }

        [HttpPost]
        public ActionResult Registrar(traductor tra)
        {
            if(tra.eleccion=="1") {
                var op = new GuardarTraductorServices();
                op.GuardarTraductor(tra);
            }
            else
            {
                var arch = new LeerTraductorServices();
                ViewBag.Archivos = arch.Leerarchivo();
            }
           
            return View();
        }
    }
}