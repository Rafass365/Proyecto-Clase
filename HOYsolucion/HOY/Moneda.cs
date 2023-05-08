using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clase_R
{
    internal class Moneda

    {
        private string Nombre;     //Atributo -> Siempre private (Visible únicamente por los metodos de la misma clase
        private double Tasa;
        
        

        public Moneda(string nombre, double tasa)
        {
            this.Nombre = nombre;
            this.Tasa = tasa;
        }

        public Moneda(string nombre)
        {
            this.Nombre = nombre;
            
        }

        public Moneda()
        {
        }
    }
}

