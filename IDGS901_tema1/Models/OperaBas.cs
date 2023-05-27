using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace IDGS901_tema1.Models
{
    public class OperaBas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Res { get; set; }

        public int bandera { get; set; }

        public void Suma()
        {
            this.Res = this.Num1 + this.Num2;
          
        }
        public void Multiplicacion()
        {
            this.Res = this.Num1 * this.Num2;

        }
        public void Dividir()
        {
            this.Res = this.Num1 / this.Num2;

        }
        public void Resta()
        {
            this.Res = this.Num1 - this.Num2;

        }

        public void decision(String bandera)
        {
            
            if (bandera == "1")
            {

                Multiplicacion();
            }
            else if (bandera == "2")
            {
                Dividir();
            }
            else if (bandera == "3")
            {
                Suma();
            }
            else if (bandera == "4")
            {
                Resta();
            }
        }
    }
}