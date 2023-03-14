using SistemaVeterinaria1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaVeterinaria1.DAO
{
    internal class ClienteDAO : ConexionBD
    {

        public void Insertar(ClienteDTO cliente)
        {
            /* metodo de conexion a la base de Datos para crear un nuevo registro de Cliente
            sql es el nombre del procedimiento almacenado en la base de datos, que ejecuta
            un comando sql para crear un nuevo registro de cliente */
            string sql = "CrearCliente";

            /*se crea una instancia SqlCommand llamada command, que se crea con el 
             constructor que recibe la sentencia sql a ejecutar , y la conexion a la base de datos 
             heredada de la clase padre ConexionBD
             */
            SqlCommand command = new SqlCommand(sql, base.conexionSql);
            
            // le asignamos el tipo procedimento almacenado a la instancia command
            command.CommandType = CommandType.StoredProcedure;
            // ingresamos los parametros que solicita el procedimiento almacenado para la crear de un nuevo registro
            command.Parameters.AddWithValue("@nombres", cliente.Nombres);
            command.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            command.Parameters.AddWithValue("@email", cliente.Email);
            command.Parameters.AddWithValue("@password", cliente.Password);
            // se abre la conexion
            command.Connection.Open();
            //ejecutamos el comando a la base de datos , y este metodo devuelve un entero, referente al numero de filas afectadas, por el sql
            int resultado = command.ExecuteNonQuery();
            // se cierra la conexión
            command.Connection.Close();
            // se retorna el resultado 
           
        }


        public ClienteDTO SeleccionarUsuario(string email) 
        {
            // metodo Acceso usuario que retorna un objeto cliente para su acceso al sistema o verificar su existencia


            // se crea una instancia de Cliente DTO llamada clienteEncontrado, para almacenar el resultado de la busqueda de un cliente, para el registro o el ingreso
            ClienteDTO clienteEncontrado= null;
            //sql contiene el nombre del procedimiento almacenado en la base de datos, que ejecuta un comando sql para buscar un cliente por su email
            String sql = "AccesoCliente";
            /*se crea una instancia SqlCommand llamada command, que se crea con el 
             constructor que recibe la sentencia sql a ejecutar , y la conexion a la base de datos 
             heredada de la clase padre ConexionBD
             */
            SqlCommand command = new SqlCommand(sql, base.conexionSql);
            // le asignamos el tipo procedimento almacenado a la instancia command
            command.CommandType = CommandType.StoredProcedure;
            // ingresamos los parametros que solicita el procedimiento almacenado para la consulta sql, almacenada en el procedimiento almacenado
            command.Parameters.AddWithValue("@email", email);
            // se abre la conexion
            command.Connection.Open();
            // creamos una instancia de SqlDataReader
            SqlDataReader leerFilas = command.ExecuteReader();

            /* con el metodo Read() recorremos los registros que obtuvo el objeto command, almacenados
             en el datareader leerfilas, ya que si existen registros devuelve true , y si no false
             se aclara que solo enviara un registro ya que la busqueda es por medio de email,
             y esta propiedad tiene la restriccion de ser unica en la BDD*/
            if (leerFilas.Read()) {
                ClienteDTO cliente = new ClienteDTO(leerFilas.GetInt32(0), leerFilas.GetString(1), leerFilas.GetString(2), leerFilas.GetString(3), leerFilas.GetString(4));
                clienteEncontrado = cliente;
            }
            // cerramos el objeto datareader
            leerFilas.Close();
            // cerramos la conexion a la base de datos
            command.Connection.Close();

            // y retornamos el cliente encontrado, si este existe devolvera un cliente, si no devolvera un objeto null
            return clienteEncontrado;
        }

        public void Editar(ClienteDTO cliente)
        {
            // metodo de conexion a la base de Datos para crear un nuevo registro de Cliente

            /*sql es la variable que contiene el nombre ddel procedimiento almacenado en la base de datos,
            que ejecuta un comando sql para actualizar un registro de cliente*/
            string sql = "ActualizarCliente";

            /*se crea una instancia SqlCommand llamada command, que se crea con el 
             constructor que recibe la sentencia sql a ejecutar , y la conexion a la base de datos 
             heredada de la clase padre ConexionBD
             */
            SqlCommand command = new SqlCommand(sql, base.conexionSql);
            // le asignamos el tipo procedimento almacenado a la instancia command
            command.CommandType = CommandType.StoredProcedure;
            // ingresamos los parametros que solicita el procedimiento almacenado para la crear de un nuevo registro
            command.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
            command.Parameters.AddWithValue("@nombres", cliente.Nombres);
            command.Parameters.AddWithValue("@apellidos", cliente.Apellidos);
            command.Parameters.AddWithValue("@email", cliente.Email);
            command.Parameters.AddWithValue("@password", cliente.Password);
            // se abre la conexion
            command.Connection.Open();
            //ejecutamos el comando a la base de datos , y este metodo devuelve un entero, referente al numero de filas afectadas, por el sql
            int resultado = command.ExecuteNonQuery();
            // se cierra la conexión
            command.Connection.Close();
        }

    }

   
}
