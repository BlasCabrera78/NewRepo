using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorDeEmails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gestor gestor = new Gestor("Carlos", "MegaBobo@gmail.com");
            Contacto Nico = new Contacto("Nico", "Nico@Gmail.com");
            Mensaje msj = new Mensaje("Hablar de la vida", "Que onda tu vida mi rey?");
            gestor.AñadirContactos(Nico);
            gestor.EnviarMensaje(Nico, msj);
            Nico.MostrarBandeja(Nico.BandejaEntrada);
        }
    }
}
