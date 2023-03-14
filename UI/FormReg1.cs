using SistemaVeterinaria1.DTO;
using SistemaVeterinaria1.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinaria1.UI
{
    public partial class FormReg1 : Form
    {
        public FormReg1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Encapsulamos en un try catch para controlar errores a la hora de ejecutar
            try
            {
                //Extraemos los datos Insertados por el usuario en los TextBox
                string nombres = this.textNombres.Text;
                string apellidos = this.textApellidos.Text;
                string email = this.textEmail.Text;
                string password = this.textPassword.Text;
                string comPassword = this.textComPassword.Text;


                // Se hace una instancia de la Clase ClienteInicio que contiene al logica del negocio
                ClienteInicio reg = new ClienteInicio();
                //Se crea una instancia de tipo Cliente que sera enviado a la Capa de Negocio para ser Registrado
                ClienteDTO clienteRegistro = new ClienteDTO(nombres, apellidos, email, password);
                

                if (reg.RevisarEmail(email))
                    /* mediante el if consultamos con el método revisarEmail, que se encuentra en la clase de la lógica  Cliente
                     del negocio ClienteInicio*/
                {
                    /* enviamos al metodo ClienteRegistro perteneciente a la instancia reg creada anteriormente
                     en el que se envia como paramatros el cliente a registrar y la comprobacion de la contraseña */
                    String respuesta = reg.ClienteRegistro(clienteRegistro, comPassword);

                    // el Metodo retorna una respuesta, en el caso existir problemas como controseña diferente, 
                    // o si el usuario ya existe, devolvera una cadena con un mensaje, que sera reflejado
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // si no existen inconvenientes, y el metodo se ejecuto correctamente regresa la cadena vacia, se notifica que se registro con exito
                        MessageBox.Show("Usuario Registrado con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // se redirige al form de inicioSesion
                        FormLogin fl = new FormLogin();
                        fl.Visible = true;
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese una diréccion de correo electrónico valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception exc)
            {
                // en el caso de existir algun error, sera notificado por medio de un mensaje

                MessageBox.Show(exc.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // crea una instancia del formulario Login
            FormLogin fl = new FormLogin();
            // desplega la ventana de login
            fl.Visible = true;
            // cierra el formulario actual
            this.Visible = false;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // metodo para detener el programa al cerrar el formulario
            Application.Exit();
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
