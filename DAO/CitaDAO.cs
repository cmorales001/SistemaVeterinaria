using SistemaVeterinaria1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaVeterinaria1.DAO
{
    internal class CitaDAO : ConexionBD
    {

        public void Insertar(CitaDTO cita)
        {
            /* metodo de conexion a la base de Datos para crear un nuevo registro de Cita
            sql contiene el nombre del procedimiento almacenado en la base de datos, que ejecuta
            un comando sql para crear un nuevo registro */
            string sql = "CrearCita";

            /*se crea una instancia SqlCommand llamada command, que se crea con el 
             constructor que recibe la sentencia sql a ejecutar , y la conexion a la base de datos 
             heredada de la clase padre ConexionBD
             */
            SqlCommand command = new SqlCommand(sql, base.conexionSql);
            
            // le asignamos el tipo procedimento almacenado a la instancia command
            command.CommandType = CommandType.StoredProcedure;
            // ingresamos los parametros que solicita el procedimiento almacenado para la crear de un nuevo registro
            command.Parameters.AddWithValue("@idCliente", cita.IdCliente);
            command.Parameters.AddWithValue("@fechaHora", cita.FechaHora);
            command.Parameters.AddWithValue("@veterinario", cita.Veterinario1);
            // se abre la conexion
            command.Connection.Open();
            //ejecutamos el comando a la base de datos , y este metodo devuelve un entero, referente al numero de filas afectadas, por el sql
            int resultado = command.ExecuteNonQuery();
            // se cierra la conexión
            command.Connection.Close();
            // se retorna el resultado 
           
        }


        public List<CitaDTO> SeleccionarporUsuario(int idCliente) 
        {
            // metodo Acceso usuario que retorna un objeto cliente para su acceso al sistema o verificar su existencia


            // se crea una lista de CitasDTO llamada citasCliente, para almacenar el resultado de la busqueda
            List<CitaDTO> citasCliente = new List<CitaDTO>();
            //sql contiene el nombre del procedimiento almacenado en la base de datos, que ejecuta un comando sql para buscar un citas por cliente
            String sql = "BuscarCitaCliente";
            /*se crea una instancia SqlCommand llamada command, que se crea con el 
             constructor que recibe la sentencia sql a ejecutar , y la conexion a la base de datos 
             heredada de la clase padre ConexionBD
             */
            SqlCommand command = new SqlCommand(sql, base.conexionSql);
            // le asignamos el tipo procedimento almacenado a la instancia command
            command.CommandType = CommandType.StoredProcedure;
            // ingresamos los parametros que solicita el procedimiento almacenado para la consulta sql, almacenada en el procedimiento almacenado
            command.Parameters.AddWithValue("@idCliente", idCliente);
            // se abre la conexion
            command.Connection.Open();
            // creamos una instancia de SqlDataReader
            SqlDataReader leerFilas = command.ExecuteReader();

            /* con el metodo Read() recorremos los registros que obtuvo el objeto command, almacenados
             en el datareader leerfilas, ya que si existen registros devuelve true , y si no false
             se aclara que solo enviara un registro ya que la busqueda es por medio de email,
             y esta propiedad tiene la restriccion de ser unica en la BDD*/

            while (leerFilas.Read())
            {
                CitaDTO cita = null;
                cita = new CitaDTO(leerFilas.GetInt32(0), leerFilas.GetInt32(1), leerFilas.GetDateTime(2), leerFilas.GetString(3));
                citasCliente.Add(cita);
            }
            // cerramos el objeto datareader
            leerFilas.Close();
            // cerramos la conexion a la base de datos
            command.Connection.Close();

            // y retornamos el cliente encontrado, si este existe devolvera un cliente, si no devolvera un objeto null
            return citasCliente;
        }

        

    }

   
}
