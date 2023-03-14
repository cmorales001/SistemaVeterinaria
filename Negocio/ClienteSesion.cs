using Newtonsoft.Json.Bson;
using SistemaVeterinaria1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVeterinaria1.Negocio
{
    internal class ClienteSesion
        // la Clase ClienteSesion cumple la funcion de simular una Sesion de Usuario
    {
        // se crean variables estaticas que contienen los datos del usuario, y los datos del chat.
        // son estaticas con el objetivo de tener la informacion sin necesidad de crear un nuevo objeto 
        private static int id;
        private static string apellidos;
        private static string email;
        private static string nombres;
        private static string veterinario;

        // arreglo que almacena el flujo de mensaje del chat
        // tambien es de contexto estatico
        private static List<String> contenedorChat = new List<string>();
        private static List<CitaDTO> registroCitas; 

        

        public static int Id { get => id; set => id = value; }
        public static string Email { get => email; set => email = value; }
        public static string Nombres { get => nombres; set => nombres = value; }
        public static string Apellidos { get => apellidos; set => apellidos = value; }
        public static List<string> ContenedorChat { get => contenedorChat; set => contenedorChat = value; }
        public static string Veterinario1 { get => veterinario; set => veterinario = value; }
        public static List<CitaDTO> RegistroCitas { get => registroCitas; set => registroCitas = value; }

        public static void EnviarMensaje(string mensaje)
            /*metodo estático que cumple la función de guardar los datos en el arreglo estatico contenedorChat 
             recibe un string obtenido desde la capa de vista*/
        {
            // adiciona los datos del emisor del mensaje y se procede a guardar en el arreglo
            string mensajeChat = ClienteSesion.Nombres +" "+ ClienteSesion.Apellidos + ":\n\n" + mensaje+ "\n\n";

            ClienteSesion.ContenedorChat.Add(mensajeChat);

            //se solicita una respuesta a la inteligencia artificial, se envia como parametro la pregunta
            
            ResponderMensaje(mensaje);
        }

        public static void ResponderMensaje(string pregunta)
            // este metodo solicita a la Api de OpenAi una respuesta a la pregunta del usuario

        {
            // almacena un nombre de veterinario obtenido de forma aleatoria
            
            // idioma de la respuesta
            string idioma = ", respuesta en español";
            // rol que se le otorga al chatbot
            string rol = "tu eres un veterinario profesional llamado "+ Veterinario1+" que responderias a la siguiente pregunta o conversación:" ;
            //la variable mensaje recibe la respuesta generada por la API de OpenAi, que devuelve la respuesta de Chatbot
            string mensaje = VeterinarioAI.callOpenAI(250,  rol + pregunta + idioma , "text-davinci-003", 0.7, 1, 0, 0);
            // se le agrega el emisor del mensaje
            string mensajeChat = ClienteSesion.Veterinario1+": " + mensaje+ "\n\n";
            // y se registra en la lista de mensajes
            ClienteSesion.ContenedorChat.Add(mensajeChat);
        }

        public static void BorrarChat() {
            ClienteSesion.ContenedorChat.Clear();
        }


        public static string Veterinario()
        // este metodo retorna aleatoriamente a un veterinario para realizar la conversación
        {
            List<string> veterinarios = new List<string>() { "Angelica Escobar" , "Cristian Morales", "Wilson Galeas"
            ,"Joel Taco","Leonardo Orbe"};

            // solicito un numero aleatorio a la clase Random
            Random rnd = new Random();
            int numeroAleatorio = rnd.Next(0, 5);

            // obtiene el veterinario de la lista, segun el número aleatorio
            string veterinario = veterinarios[numeroAleatorio];
            
            // retorna el nombre
            return (veterinario);
        }

    }
}
