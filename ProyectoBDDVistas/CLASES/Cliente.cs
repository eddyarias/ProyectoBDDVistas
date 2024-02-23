using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.CLASES
{
    public class Cliente
    {
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string IdTaller { get; set; }
        public string NumCedulaCliente { get; set; }
        public string DireccionCliente { get; set; }

        public Cliente(string nombreCliente, string apellidoCliente, string idTaller, string numCedulaCliente, string direccionCliente)
        {
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            IdTaller = idTaller;
            NumCedulaCliente = numCedulaCliente;
            DireccionCliente = direccionCliente;
        }
    }
}
