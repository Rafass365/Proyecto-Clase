using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Administrativo : Empleado
    {
        public Administrativo() { }
        public string Plazaparking { get; set; }

        
        public override string ToString()
        {

            return $"Administrativo. Nombre: {Nombre}  Plaza: {Plazaparking}   Dias:{DiasVacaciones} ";
        }

    }

}
