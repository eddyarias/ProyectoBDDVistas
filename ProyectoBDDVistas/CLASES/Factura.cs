using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.CLASES
{
    public class Factura
    {
        public string IdFactura { get; set; }
        public string NumMatriculaVehiculo { get; set; }
        public string IdReparacion { get; set; }
        public string IdTaller { get; set; }
        public DateTime FechaEmisionFactura { get; set; }
        public decimal SubtotalFactura { get; set; }
        public decimal IvaFactura { get; set; }
        public decimal TotalFactura { get; set; }

        public Factura(string idFactura, string numMatriculaVehiculo, string idReparacion, string idTaller, DateTime fechaEmisionFactura, decimal subtotalFactura, decimal ivaFactura, decimal totalFactura)
        {
            IdFactura = idFactura;
            NumMatriculaVehiculo = numMatriculaVehiculo;
            IdReparacion = idReparacion;
            IdTaller = idTaller;
            FechaEmisionFactura = fechaEmisionFactura;
            SubtotalFactura = subtotalFactura;
            IvaFactura = ivaFactura;
            TotalFactura = totalFactura;
        }
    }
}
