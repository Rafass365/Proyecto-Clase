using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class Empleado
    {
        public string Nombre { get; set; }

        protected int DiasVacaciones; // Para que lo herede la clase hijo
                                       // Sí fuese private --> No lo here

        public void CalcularVacaciones()
        {
            DiasVacaciones += 25;
        }

        public override string ToString()
        {
            return $"[Empleado. Nombre: {Nombre}]";
        }

    }
}