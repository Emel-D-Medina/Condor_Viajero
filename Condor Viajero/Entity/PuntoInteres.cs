using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET;

namespace Entity
{
    public class PuntoInteres
    {   
        public string Id { get; set; }
        public string Nombre {  get; set; }
        public PointLatLng Punto {  get; set; }

        public PuntoInteres() { }

        public PuntoInteres(string Id, string Nombre, PointLatLng Punto)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.Punto = Punto;
        }
    }
}
