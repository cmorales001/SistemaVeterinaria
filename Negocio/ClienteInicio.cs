using SistemaVeterinaria1.DTO;
using SistemaVeterinaria1.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using static System.Collections.Specialized.BitVector32;
using System.Text.RegularExpressions;

namespace SistemaVeterinaria1.Negocio
{
    internal class ClienteInicio
    {

        public string ClienteRegistro(ClienteDTO cliente, string comprobacionPw)
        {
            /* el metodo ClienteSRegistro , se encarga de la creacion de un nuevo registro de cliente,
             revisando que todos los parametros sean correctos, incluso si ya existe un usuario
            esto con el objetivo de controlar el ingreso de parametros independientemente de la vista*/

            // se crea un instancia de ClienteDao para la conexion a la BDD e insertar el nuevo registro
            ClienteDAO cliDao = new ClienteDAO();
            
            // se crea un variable que devolera un mensaje a la interfaz grafica segun cada caso
            string respuesta = "";

            // el if comprueba que los parametros para el registro no se encuentren vacios o nulos, para proceder al registro
            if (string.IsNullOrEmpty(cliente.Nombres) || string.IsNullOrEmpty(cliente.Apellidos) || string.IsNullOrEmpty(cliente.Email) 
                || string.IsNullOrEmpty(cliente.Password) || string.IsNullOrEmpty(comprobacionPw))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                // si todos los parametros estan llenos y no nulos se ejecuta el siguiente bloque
                if (cliente.Password == comprobacionPw)
                    // el if comprueba que la contraseña ingresada sea correcta
                {
                    if (cliDao.SeleccionarUsuario(cliente.Email)!= null)
                        /* el if comprueba que el cliente no se encuentre ya registrado, 
                         * ya que el metodo Acceso usuario devuelve la consulta
                         *y si este devuelve un cliente, significa que no puede registrar con ese email, ya que es unico*/
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        // si el usuario no existe entonces, encripta la contraseña del usuario y ejecuta el registro en la BDD con el metodo insertar de cliente Dao
                        cliente.Password = GenerarSHA1(cliente.Password);
                        cliDao.Insertar(cliente);
                    }
                }
                else
                {
                    // si las contraseñas no coinciden devuelve el siguiente mensaje
                    respuesta = "Las contraseña no coinciden";
                }
            }

            // finalmente retorna el resultado segun corresponda
            return respuesta;

        }



        public string ClienteLogin(string email, string password)
        {
            //se crea una instancia de Cliente Dao para utilizar las operacion CRUD
            ClienteDAO cliDao = new ClienteDAO();
            //se crea una variable respuesta que sera retornada a la interfaz gráfica
            string respuesta = "";
            // creo una variable ClienteDTO llamada Cliente Encontrado para almacenar el Cliente a ingresar
            ClienteDTO ClienteEncontrado = null;


            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                // por medio del if se comprueba que los campos no esten vacios
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
                // si estan llenos se ejecutan las siguientes operaciones
            {
                // buscamos el cliente por medio del del metodo AccesoUsuario del objeto ClienteDao, que retorna un cliente si existe o retorna null si no
                ClienteEncontrado = cliDao.SeleccionarUsuario(email);
                
                if (ClienteEncontrado == null)
                    // si no existe retorna el siguiente mensaje a la vista
                {
                    respuesta = "El usuario no existe";
                }
                else
                    // si el cliente existe hace la siguiente comprobación
                {
                    if (ClienteEncontrado.Password != GenerarSHA1(password))
                        /* encripta la contraseña ingresada en la interfaz para verificar si coincide con el registro de la BDD, 
                         si esta no coincide devuelve el mensaje*/
                    {
                        respuesta = "La contraseña no coincide con el registro";
                    }
                    else
                        /* si las contraseñas coinciden entonces envian los parametros del cliente a la clase Cliente Sesion,
                         que albergara la sesion una vez comprobadas las credenciales */
                    {   
                        ClienteSesion.Id = ClienteEncontrado.IdCliente;
                        ClienteSesion.Email = email;
                        ClienteSesion.Nombres = ClienteEncontrado.Nombres;
                        ClienteSesion.Apellidos = ClienteEncontrado.Apellidos;
                    }
                }
            }
            return respuesta;
        }

        public string ClienteEditar(ClienteDTO cliente, string comprobacionPw, string passwordActual)
        {
            // el metodo ClienteEditar , se encarga de la modificación de un registro de un cliente,
            

            // se crea un instancia de ClienteDao para la conexion a la BDD y actualizar el registro
            ClienteDAO cliDao = new ClienteDAO();

            // se crea una variable que devolvera un mensaje a la interfaz grafica segun cada caso
            string respuesta = "";

            // el if comprueba que la contraseña actual no este vacia
            if (string.IsNullOrEmpty(passwordActual))
            {
                respuesta = "Debe Ingresar su contraseña Actual";
            }
            else
            {
                if (cliente.Password == comprobacionPw)
                // el if comprueba que la nueva contraseña ingresada sea correcta, haciendo una comprobación, en caso de ser actualizada
                {
                    // obtengo el objeto del usuario a actualizar desde la capa Dao
                    ClienteDTO ClienteEdit = cliDao.SeleccionarUsuario(ClienteSesion.Email);
                    //guardo la contraseña extraida de la base de datos
                    string passwordAct = ClienteEdit.Password;
                    //se encripta la contraseña ingresada en el form, y se compara con el registro de la bdd
                    if (GenerarSHA1(passwordActual) != passwordAct)
                    
                    {
                        // si la contraseña no coincide genera el siguiente mensaje
                        respuesta = "Tu contraseña actual no coincide";
                    }
                    else
                    {

                        // si se ingresaron nuevos datos, se los almacena en el objeto a actualizar, solo en el caso de no estan vacios
                        // se encripta la nueva  contraseña del usuario y ejecuta el registro en la BDD con el metodo editar de cliente Dao
                        if (!string.IsNullOrEmpty(cliente.Nombres))
                        {
                            ClienteEdit.Nombres = cliente.Nombres;
                        }
                        if (!string.IsNullOrEmpty(cliente.Apellidos))
                        {
                            ClienteEdit.Apellidos = cliente.Apellidos;
                        }
                        if (!string.IsNullOrEmpty(cliente.Email))
                        {
                            ClienteEdit.Email = cliente.Email;
                        }
                        if (!string.IsNullOrEmpty(cliente.Password))
                        {
                            ClienteEdit.Password = GenerarSHA1(cliente.Password);
                        }


                        cliDao.Editar(ClienteEdit);
                    }
                }
                else
                {
                    // si las contraseñas no coinciden devuelve el siguiente mensaje
                    respuesta = "Las contraseña nuevas no coinciden";
                }
            }

            // finalmente retorna el resultado segun corresponda
            return respuesta;

        }

        public bool RevisarEmail(string email)
        // método para comprobar que un email cumple con los parametros (texto)@(texto).(texto)
        {
            /*
             *  la clase System.Text.RegularExpressions.Regex es parte de las librerías de .NET Framework de Microsoft. 
             * y se utiliza para trabajar con expresiones regulares en C#
             */
            bool isValid = Regex.IsMatch(email, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            if (isValid)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string GenerarSHA1(string cadena)
        // metodo que encripta la contraseña usando del algoritmo sha1
        {
            //Codifica la cadena en bytes
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            // Crea un objeto para calcular el hash
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            //calcula el hash
            result = sha.ComputeHash(data);

            //construye una cadena con los bytes del hash
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                // si el byte es menor a 16 se agrega un 0 antes de el valor hexadecimal
                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }

        
    }

    
}
