using Proyecto_Clase_R;
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

        public Moneda(string nombre, string letra)
        {
            this.Nombre = nombre;
            this.Letra = letra;
        }
        public Moneda(string nombre)
        {
            this.Nombre = nombre;

        }
        public Moneda(){}
        public static List<Moneda> crearListaMonedasInicial(List<Moneda> listaMonedas)
        {
            /*List<Moneda> listaMonedas = new List<Moneda>();*/     // Crea una lista de Monedas
            Moneda euro = new Moneda("Euro", "e");              // Crea una Moneda nueva
            listaMonedas.Add(euro);                             // Añadimos la moneda a la lista de monedas creada
            Moneda dolar = new Moneda("Dolar", "d");
            listaMonedas.Add(dolar);
            Moneda libra = new Moneda("Libra", "l");
            listaMonedas.Add(libra);
            return (listaMonedas);
        }
    }
}

