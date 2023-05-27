using IDGS901_tema1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Services
{
    public class PulquesServices
    {
        public List<Pulques> ObtenerPulque()
        {
            var pulques1 = new Pulques()
            {
                producto = "Pulque1",
                descripcion = "Piña de Mango",
                litros = 10,
                producccion = new DateTime(2023, 12, 5)

            };

            var pulques2 = new Pulques()
            {
                producto = "Pulque2",
                descripcion = "Frutos rojos",
                litros = 10,
                producccion = new DateTime(2023, 11, 10)

            };


            return new List<Pulques> { pulques1, pulques2};
        }
    }
}