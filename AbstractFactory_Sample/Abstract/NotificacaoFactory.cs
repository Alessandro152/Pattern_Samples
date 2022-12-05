using System;
using System.Threading.Tasks;

namespace AbstractFactory_Sample
{
    public abstract class NotificacaoFactory
    {
        public NotificacaoFactory()
        {

        }

        protected void GerarNotificacaoEmail(string origem, string destino)
        {
            Console.WriteLine("enviando email...");
            //Logica para enviar email
        }

        protected void GerarNotificacaoSms(string origem, string destino)
        {
            Console.WriteLine("enviando sms...");
            //Logica para enviar sms
        }

        protected void GerarNotificacaoWhatsapp(string origem, string destino)
        {
            Console.WriteLine("enviando mensagem via whatsapp");
            //Logica para enviar mensagem por whatsapp
        }
    }
}
