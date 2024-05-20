using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class Persona
    {
        public string Id { get; set; }
        protected string Nombre { get; set; }

        protected Persona() { }

        protected Persona(string Id,string nombre)
        {
            this.Id = Id;
            this.Nombre = nombre;
        }
    }
}
