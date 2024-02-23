using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.CLASES
{

    public class Reparacion
    {
        public string NumMatriculaVehiculo { get; set; }
        public string IdReparacion { get; set; }
        public string IdTaller { get; set; }
        public string TipoReparacion { get; set; }
        public DateTime FechaReparacion { get; set; }
        public string ObservacionesReparacion { get; set; }
        public decimal PrecioReparacion { get; set; }

        public Reparacion(string numMatriculaVehiculo, string idReparacion, string idTaller, string tipoReparacion, DateTime fechaReparacion, string observacionesReparacion, decimal precioReparacion)
        {
            NumMatriculaVehiculo = numMatriculaVehiculo;
            IdReparacion = idReparacion;
            IdTaller = idTaller;
            TipoReparacion = tipoReparacion;
            FechaReparacion = fechaReparacion;
            ObservacionesReparacion = observacionesReparacion;
            PrecioReparacion = precioReparacion;

        }
    }
}
