using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TiendaController : Controller
    {
        // GET: Tienda
        public ActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Claudio",
                Edad = 21,
                Empleado = false,
                Nacimiento = new DateTime(2002,02,26)
            };
            ViewBag.Persona = persona;
            return View();
        }

        public ActionResult Registar() {
            var persona = new Persona();
            return View(persona);

        }

        public ActionResult Registar2(Grados opera)
        {
            var persona = new Persona();
            return View(persona);

        }
    }
}