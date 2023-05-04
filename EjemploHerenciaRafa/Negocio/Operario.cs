using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Operario : Empleado
    {
        public string Turno { get; set; }


        // ToString muestra: Tipo, Nombre, Turno y los dias de vacaciones

        public override string ToString()
        {

            return $"Operario. Nombre: {Nombre}  Turno:   Dias: ";
        }
    }
}