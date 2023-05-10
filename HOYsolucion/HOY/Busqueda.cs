using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace Proyecto_Clase_R
{
    public class Busqueda
    {
        public Moneda monedaOrigen{ get; set; }
        public Moneda monedaDestino{ get; set; }
        public double cantidad{ get; set; }
        public double tasa{ get; set; }

        public Usuario Usuario
        {
            get => default;
            set
            {
            }
        }


        //public void crearBusqueda(Moneda monedaOrigen, Moneda monedaDestino)
        //{
        //    this.monedaOrigen = monedaOrigen;
        //    this.monedaDestino = monedaDestino;

        //}
        public Busqueda()
        {

        }

    }

    

    
}