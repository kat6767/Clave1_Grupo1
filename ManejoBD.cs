using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Clave1___Grupo1
{
    public class ManejoBD
    {
        /// <summary>
        /// Clase para el manejo general de la base de datos. Contiene procedimientos de abierto y cerrado de la conexión.
        /// </summary>
        /// <returns></returns>
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=veterinaria; uid=root; pwd=root");
            conexion.Open();

            return conexion;
        }
    }
}
