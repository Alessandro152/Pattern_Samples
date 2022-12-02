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
            //Logica para enviar email
        }

        protected void GerarNotificacaoSms(string origem, string destino)
        {
            //Logica para enviar sms
        }

        protected void GerarNotificacaoWhatsapp(string origem, string destino)
        {
            //Logica para enviar mensagem por whatsapp
        }
    }
}
