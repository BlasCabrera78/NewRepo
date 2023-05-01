using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEmails
{
    public class Gestor
    {
        public String Nombre { get; set; }
        public String Email { get; set; }
        public Mensaje mensaje { get; set; }
        
        public ArrayList BandejaEntrada;
        
        public ArrayList Enviados;

        public ArrayList Contactos;

        public Gestor (String Nombre, String Email)
        {
            this.Nombre = Nombre;
            this.Email = Email;
            BandejaEntrada = new ArrayList();
            Enviados = new ArrayList();
            Contactos = new ArrayList();
        }

        public void AñadirContactos(Gestor a) 
        {
            Contactos.Add(a);
        }

        public void EnviarMensaje(Gestor a, Mensaje msj)
        {
            Enviados.Add(msj);
            a.MensajeRecibido(msj);
        }

        public void MensajeRecibido(Mensaje msj) 
        {
            BandejaEntrada.Add(msj);
        }

        public void MostrarBandeja(ArrayList a) 
        {
            foreach (var Value in a) 
            {
                Console.WriteLine(Value);
            }
        }
    }
}
