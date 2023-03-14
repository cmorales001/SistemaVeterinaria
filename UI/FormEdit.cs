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
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnCambiar_Click(object sender, EventArgs e)
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
                string passwordActual = this.textPasswordActual.Text;
                bool revisarEmail = false;

                // Se hace una instancia de la Clase ClienteInicio que contiene al logica del negocio
                ClienteInicio edit = new ClienteInicio();
                //Se crea una instancia de tipo Cliente que sera enviado a la Capa de Negocio para ser Registrado
                ClienteDTO clienteRegistro = new ClienteDTO(nombres, apellidos, email, password);

                // condicional para comprobar si el email tiene la estructura correcta en caso de querer realizar cambios
                if (String.IsNullOrEmpty(email))
                {
                   // si el email esta vacio devuelve true para acceder a la actualizacion
                    revisarEmail = true;

                }
                else 
                {
                    // metodo revisarEmail revisa que la estructura sea correcta y devuleve true o false según el caso
                    revisarEmail = edit.RevisarEmail(email);
                }
                
                if (revisarEmail)
                {
                    /* enviamos al metodo ClienteRegistro perteneciente a la instancia reg creada anteriormente
                     en el que se envia como paramatros el cliente a registrar y la comprobacion de la contraseña */
                    String respuesta = edit.ClienteEditar(clienteRegistro, comPassword, passwordActual);

                    /* el Metodo retorna una respuesta, en el caso existir problemas como controseña diferente, 
                     o si el usuario ya existe, devolvera una cadena con un mensaje, que sera reflejado*/
                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // si no existen inconvenientes, y el metodo se ejecuto correctamente regresa la cadena vacia, se notifica que se registro con exito
                        MessageBox.Show("Cambios registrados con Exito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            FormInicioSesion fis = new FormInicioSesion();
            fis.Visible = true;
            this.Visible = false;
        }
    }
}
