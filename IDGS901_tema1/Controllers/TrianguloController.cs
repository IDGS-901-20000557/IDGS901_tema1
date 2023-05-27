using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS901_tema1.Controllers
{
    public class TrianguloController : Controller
    {
        // GET: Triangulo
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Triangulo triangulo)
        {
            double ladon1 = Math.Sqrt(Math.Pow((triangulo.x2 - triangulo.x1), 2) + Math.Pow((triangulo.y2 - triangulo.y1), 2));
            double ladon2 = Math.Sqrt(Math.Pow((triangulo.x3 - triangulo.x2), 2) + Math.Pow((triangulo.y3 - triangulo.y2), 2));
            double ladon3 = Math.Sqrt(Math.Pow((triangulo.x1 - triangulo.x3), 2) + Math.Pow((triangulo.y1 - triangulo.y3), 2));
            double lado1 = Math.Round(ladon1, 2);
            double lado2 = Math.Round(ladon2, 2);
            double lado3 = Math.Round(ladon3, 2);
            if (lado1 + lado2 > lado3 &&
                lado1 + lado3 > lado2 && 
                lado2 + lado3 > lado1)
            {
                if (lado1== lado2 && 
                    lado1 == lado3)
                {
                    ViewBag.tipo = "equilátero";
                    ViewBag.area = (Math.Pow(lado1, 2) * Math.Sqrt(3)) / 4;

                }
                else if (lado1 == lado2 || lado1 == lado3 ||
                          lado2 == lado3)
                {
                    double baseTriangulo = 0;
                    double ladocongruente = 0;

                    if (lado1 != lado2 && lado1 != lado3)
                    {
                         baseTriangulo = lado1;
                        ladocongruente= lado2;
                    }
                    else if (lado2 != lado1 && lado2 != lado3)
                    {
                         baseTriangulo = lado2;
                        ladocongruente = lado3;

                    }
                    else if (lado3 != lado1 && lado3 != lado2)
                    {
                         baseTriangulo = lado3;
                        ladocongruente = lado1;

                    }
                    else { 
                    }
                    double altura = Math.Sqrt(Math.Pow(ladocongruente, 2) - (Math.Pow(baseTriangulo, 2) / 4));
                    ViewBag.area = (baseTriangulo * altura) / 2;
                    ViewBag.tipo = "isósceles";
                }
                else
                {
                    double semiperimetro = (lado1 + lado2 + lado3) / 2;
                    ViewBag.area = Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));
                    ViewBag.tipo = "escaleno";
                }
                ViewBag.bandera = "0";
            }
            else
            {
                ViewBag.bandera = "1";//No es un triangulo
            }
           
            return View();

        }
    }
}