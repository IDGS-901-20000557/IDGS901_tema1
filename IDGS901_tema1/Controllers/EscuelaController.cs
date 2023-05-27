using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class EscuelaController : Controller
    {
        // GET: Escuela
        public ViewResult Index()
        {
            //return Content("<H1>IDGS901-DWI</H1>");
         
            return View();
        }

        public JsonResult About() {
            var pulque = new Pulques()
            {
                producto = "pulque",
                descripcion = "Mango",
                litros = 20,
                producccion = new DateTime(2023, 12, 4)
            };
        return Json(pulque, JsonRequestBehavior.AllowGet);
        }

        public RedirectResult About1()
        {
            return Redirect("https://google.com.mx");
        }

        public RedirectToRouteResult About2() {
            TempData["Nombre"] = "Alumno: Ana";
            return RedirectToAction("Informacion");
        }    

        public ActionResult Informacion() {
          
            ViewBag.Grupo = "IDGS901";
            ViewData["Materia"] ="Materia";

            string nombre = "";
            if (TempData.ContainsKey("Nombre"))
            {
                nombre = TempData["Nombre"] as string;
            }
            ViewBag.Nombre=nombre;

        return View();
        }
    }
}