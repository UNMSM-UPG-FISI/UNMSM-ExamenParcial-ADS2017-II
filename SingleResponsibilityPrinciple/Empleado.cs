using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }

        public bool Grabar (Empleado empleado)
        {
            //TODO: Codigo para grabar
            return true;
        }
    }
}
