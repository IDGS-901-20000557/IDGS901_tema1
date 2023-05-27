using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class GuardarTraductorServices
    {
        public void GuardarTraductor(traductor tra)
        {
            var esp = tra.espanniol;
            var ing = tra.ingles;
            string espResultado = char.ToUpper(esp[0]) + esp.Substring(1).ToLower();
            string ingResultado = char.ToUpper(ing[0]) + ing.Substring(1).ToLower();
            var datos = espResultado + "," + ingResultado + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/DatosTrad.txt");
            File.AppendAllText(archivo, datos);

        }
    }
}