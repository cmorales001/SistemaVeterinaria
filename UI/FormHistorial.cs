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
    public partial class FormHistorial : Form
    {
        public FormHistorial()
        {
            InitializeComponent();
            
            try
            {
                // al momento de ingresar al formulario de Historial de citas
                // se crea una istancia de la logica de las Citas
                CitaSesion citaSesion = new CitaSesion();
                // y se rellena el registro de las citas, dependiendo del contenido se envia un mensaje desde la capa de negocio
                string respuesta = citaSesion.BuscarCitaCliente();
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    // foreach para recorrer los datos de la lista de citas
                    foreach (CitaDTO cita in ClienteSesion.RegistroCitas)
                    {
                        this.listCitas.Items.Add(cita);
                    }
                }
                
            }
            catch (Exception exc) {

                MessageBox.Show(exc.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            // boton para regresar a la pantalla principal asignandola como visible y como no visible el formulario de citas
            FormInicioSesion fis = new FormInicioSesion();
            fis.Visible = true;
            this.Visible = false;

        }
    }
}
