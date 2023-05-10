using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Clase_R
{
    public class Moneda : Metodos
    {
        public string Nombre;    //Atributo -> Siempre private (Visible únicamente por los metodos de la misma clase
        public string Letra;
        public double Tasa;



        public Moneda(string nombre, double tasa)
        {
            this.Nombre = nombre;
            this.Tasa = tasa;
        }

        public Moneda(string nombre, string letra)
        {
            this.Nombre = nombre;
            this.Letra = letra;
        }

        public Moneda()
        {
        }
    }
}

