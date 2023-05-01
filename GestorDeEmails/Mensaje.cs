using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEmails
{
    public class Mensaje
    {
        private String Asunto;
        private String Cuerpo;
        private Gestor Remitente;

        public Mensaje(String Asunto, String Cuerpo) 
        {
            this.Asunto = Asunto;   
            this.Cuerpo = Cuerpo;
        }

        public Mensaje(String Asunto, String Cuerpo, Gestor Remitente) 
        {
            this.Asunto= Asunto; 
            this.Cuerpo= Cuerpo;
            Remitente.MensajeRecibido(this);
        }

        override
        public String ToString()
        {
            return "El Asunto es: " + Asunto + "El cuerpo es " + Cuerpo;
        }
    }
}
