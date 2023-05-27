using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class GuardarServices
    {
        public void GuardarArchivo(Maestros maes)
        {
            var mat = maes.matricula;
            var nom = maes.nombre;
            var ape = maes.apaterno;
            var ama = maes.amaterno;
            var email = maes.email;
            var datos = mat + "," + nom + "," + ape + "," + ama + "," + email + "," + Environment.NewLine;
            var archivo = HttpContext.Current.Server.MapPath("~/App_Data/Datos.txt");
            //File.WriteAllText(archivo, datos);
            File.AppendAllText(archivo, datos);

        }
    }
}