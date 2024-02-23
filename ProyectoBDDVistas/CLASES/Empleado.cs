using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.CLASES
{
    public class Empleado
    {
        public string IdEmpleado { get; set; }
        public string IdTaller { get; set; }
        public string NumCedulaEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
        public decimal SalarioEmpleado { get; set; }
        public DateTime FechaInicioContratoEmpleado { get; set; }

        public Empleado(string idEmpleado, string idTaller, string numCedulaEmpleado, string nombreEmpleado, string apellidoEmpleado, decimal salarioEmpleado, DateTime fechaInicioContratoEmpleado)
        {
            IdEmpleado = idEmpleado;
            IdTaller = idTaller;
            NumCedulaEmpleado = numCedulaEmpleado;
            NombreEmpleado = nombreEmpleado;
            ApellidoEmpleado = apellidoEmpleado;
            SalarioEmpleado = salarioEmpleado;
            FechaInicioContratoEmpleado = fechaInicioContratoEmpleado;
        }
    }
}
