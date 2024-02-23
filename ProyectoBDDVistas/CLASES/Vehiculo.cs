using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.CLASES
{
    public class Vehiculo
    {
        public string NumMatriculaVehiculo { get; set; }
        public string IdTaller { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public DateTime FechaCompraVehiculo { get; set; }

        // Constructor sin parámetros
        public Vehiculo() { }

        // Constructor con parámetros
        public Vehiculo(string numMatriculaVehiculo, string idTaller, string nombreCliente, string apellidoCliente, DateTime fechaCompraVehiculo)
        {
            NumMatriculaVehiculo = numMatriculaVehiculo;
            IdTaller = idTaller;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            FechaCompraVehiculo = fechaCompraVehiculo;
        }
    }
}
