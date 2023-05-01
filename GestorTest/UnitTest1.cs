using GestorDeEmails;
namespace GestorTest
{
    public class UnitTest1
    {
        [Fact]
        public void PruebaEnvio()
        {
            Gestor gestor = new Gestor("Carlos", "MegaBobo@gmail.com");
            Contacto Nico = new Contacto("Nico", "Nico@Gmail.com");
            Mensaje msj = new Mensaje("Hablar de la vida", "Que onda tu vida mi rey?");
            gestor.AñadirContactos(Nico);
            gestor.EnviarMensaje(Nico, msj);
            Assert.Equal(1, Nico.BandejaEntrada.Count);
        }
    }
}