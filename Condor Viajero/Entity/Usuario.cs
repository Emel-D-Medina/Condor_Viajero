using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Usuario : Persona
    {
        public string CorreoElectronico {  get; set; }
        public string Contrasenia { get; set; }
        public string Rol { get; set; }

        public Usuario() { }

        public Usuario(string Id,string Nombre, string CorreoElectronico,  string Contrasenia, string Rol) : base (Id,Nombre)
        {
            this.CorreoElectronico = CorreoElectronico;
            this.Contrasenia = Contrasenia;
            this.Rol = Rol;
        }

        List<string> Roles = new List<string>() { "Administrador", "Usuario" };

        public void AsignarRol()
        {

        }
    }
}
