using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clave1___Grupo1
{
    public class Usuario
    {
        public string nombreUsuario { get; set; }
        public string contraseña { get; set; }
        public string rol {  get; set; }

        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }

        public string Especialidad { get; set; }
    }

    /*
    public class Cliente:Usuario
    {
        public string Nombre { get; set; }
        public string Direccion {  get; set; }
        public int Telefono { get; set; }

    }


    public class Veterinario : Usuario
    {

    }
    */
}
