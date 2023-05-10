using Proyecto_Clase_R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HOY
{
    public class Tasa
    {
        public Moneda MonedaOrigen { get; set; }
        public Moneda MonedaDestino  { get; set; }
        public double TasaConversion { get; set; }

        public Tasa(Moneda monedaOrigen, Moneda monedaDestino, double tasaConversion) 
        {
            MonedaOrigen = monedaOrigen;
            MonedaDestino = monedaDestino;
            TasaConversion = tasaConversion;
        }
        public Tasa() { }
        
    }
}
