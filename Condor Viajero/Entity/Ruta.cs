using GMap.NET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Ruta
    {
        public string Id { get; set; }
        public string Nombre {  get; set; }
        public List<PointLatLng> PRuta {  get; set; }

        public Ruta() { }

        public Ruta(string Id, string Nombre, List<PointLatLng> PRuta)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.PRuta = PRuta;
        }

    }
}
