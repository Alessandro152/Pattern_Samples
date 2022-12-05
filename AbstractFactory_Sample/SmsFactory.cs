using System.Threading.Tasks;

namespace AbstractFactory_Sample
{
    public class SmsFactory : NotificacaoFactory, INotificacaoFactory
    {
        public SmsFactory()
        {

        }

        public Task GerarNotificacao(string origem, string destino)
        {
            GerarNotificacaoSms(origem, destino);

            return Task.CompletedTask;
        }
    }
}
