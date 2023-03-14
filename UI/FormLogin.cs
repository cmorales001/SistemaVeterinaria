using SistemaVeterinaria1.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace SistemaVeterinaria1.UI
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // llamo a los atributos textbox del form
            //.Text recoge lo que este dentro de los textbox
            string email = this.textEmail.Text;
            string password = this.textPassword.Text;

            // try catch para el control de errores
            try
            {
                  // se instancia la clase de ClienteInicio se nombra inicio, esta contiene los metodos 
                  // para gestionar la informacion(capa de negocio)
                 ClienteInicio inicio = new ClienteInicio();
                // llamo el metodo login de la capa de negocio
                if (inicio.RevisarEmail(email))
                {
                    
                    string respuesta = inicio.ClienteLogin(email, password);
                    if (respuesta.Length > 0)
                    {
                        // devuelvo un mensaje al  usuario por medio de objeto MessageBox
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // se crea un instancia del form de inicio de sesion
                        FormInicioSesion fis = new FormInicioSesion();
                        //le asigno que sea visible
                        fis.Visible = true;
                        // al form actual le asigno que no sea visible
                        this.Visible = false;
                    }
                }
                else 
                {
                    MessageBox.Show("Ingrese una diréccion de correo electrónico valido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                  
                
                
            }
            catch (Exception exce)
            {
                // este es el mensaje que regresa en caso de error
                MessageBox.Show(exce.Message);
            }
        }

        

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            // instancio el form de registro llamado FormReg1
            FormReg1 fr = new FormReg1();
            // le asigno el estado de visible
            fr.Visible = true;
            // le asigno el estado de no visible
            this.Visible = false;

        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            // metodo para detener el programa al cerrar el formulario
            Application.Exit();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
   
        }
    }
}
