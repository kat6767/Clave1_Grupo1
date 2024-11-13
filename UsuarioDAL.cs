using Org.BouncyCastle.Asn1.X509.SigI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Clave1___Grupo1
{
    /// <summary>
    /// Clase para el manejo de usuarios en la base de datos
    /// </summary>
    public class UsuarioDAL
    {
        public static int AgregarUsuario(Usuario usuario)
        {
            int retorna = 0;

            using (MySqlConnection conexion = ManejoBD.ObtenerConexion())
            {
                //query para crear un nuevo usuario
                string query = "INSERT INTO usuario (NombreUsuario, Contraseña, Rol) VALUES ('" + usuario.nombreUsuario + "', '" + usuario.contraseña + "', '" + usuario.rol + "')";
                MySqlCommand comando = new MySqlCommand(query, conexion);

                retorna = comando.ExecuteNonQuery();

                //variable para obtener el registro que se acaba de insertar
                int usuarioId = (int)comando.LastInsertedId;

                //insertamos el nuevo usuario en tablas hijas
                if (usuario.rol == "Cliente")
                {
                    string queryCliente = "UPDATE cliente SET Nombre = '"+usuario.Nombre+"', Direccion = '"+usuario.Direccion+"', Telefono = "+usuario.Telefono+" WHERE UsuarioID = @UsuarioID";
                    MySqlCommand comandoCliente = new MySqlCommand(queryCliente, conexion); 
                    comandoCliente.Parameters.AddWithValue("@UsuarioID", usuarioId);

                    comandoCliente.ExecuteNonQuery();

                }//si es del tipo veterinario, lo añadimos a la tabla correspondiente
                else if (usuario.rol == "Veterinario")
                {
                    string queryVeterinario = "UPDATE veterinario SET Nombre = '" + usuario.Nombre + "',  Especialidad = '" + usuario.Especialidad + "' WHERE UsuarioID = @UsuarioID";
                    MySqlCommand comandoVeterinario = new MySqlCommand(queryVeterinario, conexion);
                    comandoVeterinario.Parameters.AddWithValue("@UsuarioID", usuarioId);

                    comandoVeterinario.ExecuteNonQuery();
                }

                conexion.Close();
            }
                       
                return retorna;

        }

    }
}
