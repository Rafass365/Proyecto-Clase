using Proyecto_Clase_R;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Proyecto_Clase_R
{
    public class Tasa
    {
        public Moneda MonedaOrigen { get; set; }
        public Moneda MonedaDestino { get; set; }
        public double TasaConversion { get; set; }

        public Tasa(Moneda monedaOrigen, Moneda monedaDestino, double tasaConversion)
        {
            MonedaOrigen = monedaOrigen;
            MonedaDestino = monedaDestino;
            TasaConversion = tasaConversion;
        }
        public Tasa(Moneda monedaOrigen, Moneda monedaDestino)
        {
            MonedaOrigen = monedaOrigen;
            MonedaDestino = monedaDestino;
            TasaConversion = 0;
        }
        public Tasa() { }

        public static List<Tasa> crearListaTasaInicial(List<Moneda> listaMonedas, List<Tasa> listaTasas)
        {                                                                           // Tasa == Factor de conversion entre dos monedas
            foreach (var moneda1 in listaMonedas)
            {
                foreach (var moneda2 in listaMonedas)
                {
                    if (moneda1 == moneda2)
                    {
                        Tasa ee = new Tasa(moneda1, moneda2, 1.0);                  // Creamos una lista de tasa (Dos monedas y su factor de conversion entre ambas
                        listaTasas.Add(ee);                                         // Añadimos esa relacion a la lista de tasas de conversión
                    }

                    if (moneda1.Nombre == "euro" && moneda2.Nombre == "dolar")
                    {
                        Tasa ed = new Tasa(moneda1, moneda2, 1.1);
                        listaTasas.Add(ed);
                    }
                    if (moneda1.Nombre == "euro" && moneda2.Nombre == "libra")
                    {
                        Tasa el = new Tasa(moneda1, moneda2, 0.8);
                        listaTasas.Add(el);
                    }
                    if (moneda1.Nombre == "dolar" && moneda2.Nombre == "euro")
                    {
                        Tasa de = new Tasa(moneda1, moneda2, 0.91);
                        listaTasas.Add(de);
                    }
                    if (moneda1.Nombre == "dolar" && moneda2.Nombre == "libra")
                    {
                        Tasa dl = new Tasa(moneda1, moneda2, 0.7);
                        listaTasas.Add(dl);
                    }
                    if (moneda1.Nombre == "libra" && moneda2.Nombre == "euro")
                    {
                        Tasa le = new Tasa(moneda1, moneda2, 1.25);
                        listaTasas.Add(le);
                    }
                    if (moneda1.Nombre == "libra" && moneda2.Nombre == "dolar")
                    {
                        Tasa ld = new Tasa(moneda1, moneda2, 1.14);
                        listaTasas.Add(ld);
                    }
                }
            }
            return (listaTasas);
        }

        public static double obtenerTasa(List<Tasa> listaTasa, Moneda monedaOrigen, Moneda monedaDestino)
        {
            double tasa = 0;

            foreach (var objeto in listaTasa)

            {
                if ((objeto.MonedaOrigen.Nombre == monedaOrigen.Nombre) && (objeto.MonedaDestino.Nombre == monedaDestino.Nombre))
                {
                    tasa = (objeto.TasaConversion);
                }
                else
                {
                    return (0);
                }
            }
            return (tasa);
        }
    }
}
