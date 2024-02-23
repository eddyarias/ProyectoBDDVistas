using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.CLASES
{
    public class NumeroTelefono
    {
        public string NumeroTelefonico { get; set; }
        public string IdEmpleado { get; set; }
        public string IdTaller { get; set; }

        // Constructor con parámetros
        public NumeroTelefono(string numeroTelefonico, string idEmpleado, string idTaller)
        {
            NumeroTelefonico = numeroTelefonico;
            IdEmpleado = idEmpleado;
            IdTaller = idTaller;
        }
    }
}
