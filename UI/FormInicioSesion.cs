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
    public partial class FormInicioSesion : Form
    {
        public FormInicioSesion()
        {
            InitializeComponent();
            // inicia un Label que contiene una bienvenida la usuario que ingresa al sistema 
            this.labelUser.Text= "Bienvenido:  " + ClienteSesion.Nombres + " " + ClienteSesion.Apellidos;
            this.richTextChat.Visible = false;
            this.textMensaje.Visible = false;
            this.btnEnviar.Visible = false;
            this.btnFinalizarChat.Visible = false;
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormInicioSesion_Load(object sender, EventArgs e)
        {

        }

        private void FormInicioSesion_FormClosed(object sender, FormClosedEventArgs e)

        {
            // metodo para detener el programa al cerrar el formulario
            //Application.Exit();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // metodo para cerrar sesion, close() cierra el formulario
            this.Close();
            // metodo para regresar al Login
            // crea una instancia del formulario Login
            FormLogin fl = new FormLogin();
            // desplega la ventana de login
            fl.Visible = true;

            // borro los datos dela sesion a cerrar con la creacion de un nuevo objeto ClienteSesion
            ClienteSesion.Email = "";
            ClienteSesion.Apellidos = "";
            ClienteSesion.Id = 0;
        }

        private void smEditarPerfil_Click(object sender, EventArgs e)
        {
            // se crea una instancia de form edit
            FormEdit fe = new FormEdit();
            // se la hace visible
            fe.Visible=true;
            // y se hace no visible el form actual
            this.Visible = false;

        }

        private void btnCita_Click(object sender, EventArgs e)
        {

            try
            {
                CitaSesion citaSession = new CitaSesion();

                // se asigna un veterinario de manera aleatoria
                ClienteSesion.Veterinario1 = ClienteSesion.Veterinario();
                // se registra la cita en la base de Datos con el metodo almacenado en la logica de negocio
                String respuesta = citaSession.CrearRegistroCita();
                if (respuesta == "")
                {
                    // este boton desplega los componentes necesarios para comenzar el chat
                    this.richTextChat.Visible = true;
                    this.btnEnviar.Visible = true;
                    this.textMensaje.Visible = true;
                    this.btnCita.Visible = false;
                    this.lblCita.Visible = false;
                    this.btnFinalizarChat.Visible = true;
                    // se agrega un texto de Bienvenida al desplegar el chat
                    this.richTextChat.AppendText("Hola " + ClienteSesion.Nombres
                        + ", un gusto atenderte te comunicas con: " + ClienteSesion.Veterinario1 + "\n\n");
                    
                }
                else
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void listChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            try
            {
                // se obtiene el texto del usuario
                string mensaje = this.textMensaje.Text;
                if (!string.IsNullOrEmpty(mensaje))// se verifica que no este vacio, para evitar el spam
                {
 
                    // agrego el mensaje a la lista de chat, en la clase InicioSesion
                    ClienteSesion.EnviarMensaje(mensaje);
                    // limpio el richText para no mostrar de nuevo los mensajes anteriores
                    richTextChat.Clear();
                    // actualizo la lista de mensajes en pantalla
                    richTextChat.AppendText(string.Join(Environment.NewLine, ClienteSesion.ContenedorChat));

                    // Limpiar el textbox
                    this.textMensaje.Clear();

                    // se desplaza hasta el ultimo mensaje automaticamente
                    richTextChat.ScrollToCaret();
                }
                else
                {
                    MessageBox.Show("Ingresa un texto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                
            }
            catch (Exception exce)
            {
                MessageBox.Show(exce.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnFinalizarChat_Click(object sender, EventArgs e)
        {
            // este boton oculta los componentes necesarios al finalizar el chat
            this.richTextChat.Visible = false;
            this.btnEnviar.Visible = false;
            this.textMensaje.Visible = false;
            this.btnCita.Visible = true;
            this.lblCita.Visible = true;
            this.btnFinalizarChat.Visible = false;
            ClienteSesion.Veterinario1 = "";
            ClienteSesion.BorrarChat();
        }

        private void smHistorialCitas_Click(object sender, EventArgs e)
        {
           
            FormHistorial fh = new FormHistorial();
            fh.Visible = true;
            this.Visible = false;

        }
    }
}
