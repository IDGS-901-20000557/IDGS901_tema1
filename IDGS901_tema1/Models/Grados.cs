using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IDGS901_tema1.Models
{
    public class Grados
    {
        public float Temperatura { get; set; }
        public String Eleccion { get; set; }
        public double Res { get; set; }

        public void Operacion()
        {
            var elecy = this.Eleccion;
            if (this.Eleccion =="1")
            {
                this.Res = (this.Temperatura * 9 / 5) + 32;
            }else if (this.Eleccion == "2")
            {
                this.Res = (this.Temperatura - 32) * 5 / 9;
            }
           

        }

    }
}