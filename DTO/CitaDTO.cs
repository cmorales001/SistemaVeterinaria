using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria1.DTO
{
    internal class CitaDTO
    {
        private int idCita;
        private int idCliente;
        private DateTime fechaHora;
        private string Veterinario;

        public CitaDTO(int idCita, int idCliente, DateTime fechaHora, string veterinario1)
        {
            IdCita = idCita;
            IdCliente = idCliente;
            FechaHora = fechaHora;
            Veterinario1 = veterinario1;
        }

        public CitaDTO(int idCliente, DateTime fechaHora, string veterinario1)
        {
            IdCliente = idCliente;
            FechaHora = fechaHora;
            Veterinario1 = veterinario1;
        }

        public int IdCita { get => idCita; set => idCita = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public DateTime FechaHora { get => fechaHora; set => fechaHora = value; }
        public string Veterinario1 { get => Veterinario; set => Veterinario = value; }

        public override string ToString()
        {
            return "[Fecha y Hora de la Solicitud:" + this.FechaHora + "] " + " [Veterinario:" + this.Veterinario + "]";
        }
    }

}
