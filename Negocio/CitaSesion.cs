using SistemaVeterinaria1.DAO;
using SistemaVeterinaria1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVeterinaria1.Negocio
{
    internal class CitaSesion
    {
        public string CrearRegistroCita()
        {
            string resultado = "";
            
            // obtengo la última cita registrada en la base de datos
            CitaDTO ultimaCita = ObtenerUltimaCita();
            // en esta variable se determina el tiempo de espera del usuario, para poder solicitar una nueva cita
            double esperaPorCita = 0;
            // diferenciaMinutos almacena la diferencia de tiempo entre citas recientes 
            double diferenciaMinutos;
            // obtengo la hora actual del momento en que se solicita una nueva cita
            DateTime fechaHoraActual = DateTime.Now;
            
            if (ultimaCita != null)
            {
               
                // obtengo la diferencia en minutos entre la hora actual y la hora de la última cita
               diferenciaMinutos = (fechaHoraActual - ultimaCita.FechaHora).TotalMinutes;
                
            }
            else 
            {
                // si es la primera cita del usuario, la diferencia de minutos es mayor al tiempo de espera, para generar una nueva cita
                  diferenciaMinutos =esperaPorCita+1;
            }


            // si la diferencia en minutos es mayor a 2, permite la creación de una nueva cita
            if (diferenciaMinutos > esperaPorCita) {
                // creo una instancia de clase Dao de Cita para guardar el registro en la base de datos
                CitaDAO citaDao = new CitaDAO();

                //creo un objeto de tipo cita DTO para guardarlo en la base de datos
                CitaDTO cita = new CitaDTO(ClienteSesion.Id, fechaHoraActual, ClienteSesion.Veterinario1);

                // se inserta en la base de datos con ayuda de la capa dao
                citaDao.Insertar(cita);
                
            }
            else
            {
               resultado= "Espera un mínimo de "+esperaPorCita+" min desde la última Cita para solicitar una nueva";
                
            }

            return resultado;
        }

        public string BuscarCitaCliente() 
            // este metodo retorna un mensaje a la vista o envia el registro a la sesiondel Cliente
        {
            // devolvera una respuesta de acuerdo al caso, de existir registros o no
            string resultado = "";
            CitaDAO citaDao = new CitaDAO();
            // se almacena en una lista de las citas
            List<CitaDTO> citasCliente = citaDao.SeleccionarporUsuario(ClienteSesion.Id);
            if (citasCliente.Count==0)
            {
                resultado= "No existe registro de Citas";
                // si no tiene registros se mostrara este mensaje en la vista
            }
            else {
                // si tiene registros se almacena la lista en la clase ClienteSesion
                ClienteSesion.RegistroCitas = citasCliente;
                
            }
            return resultado;
        }
        private CitaDTO ObtenerUltimaCita()
        {
            // obtengo la lista de citas desde la capaDao
            CitaDAO citaDao = new CitaDAO();
            List<CitaDTO> citasCliente = citaDao.SeleccionarporUsuario(ClienteSesion.Id);

            // si el cliente cuenta con un registro de citas devuelve, la ultima cita solicitada
            if (citasCliente.Count != 0) {
                // obtengo la ultima cita en los registros del usuario
                CitaDTO ultimaCita = citasCliente.Last();
                return ultimaCita;
            }
            // si no retorna nulo 
            return null;
            
        }

    }
}
