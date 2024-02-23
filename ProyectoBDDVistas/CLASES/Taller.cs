using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBDDVistas.CLASES
{
    public class Taller
    {
        public string IdTaller { get; set; }
        public string IdDirector { get; set; }
        public string NomTaller { get; set; }
        public string LocalidadTaller { get; set; }

        public Taller(string idTaller, string idDirector, string nomTaller, string localidadTaller)
        {
            IdTaller = idTaller;
            IdDirector = idDirector;
            NomTaller = nomTaller;
            LocalidadTaller = localidadTaller;
        }
    }
}
