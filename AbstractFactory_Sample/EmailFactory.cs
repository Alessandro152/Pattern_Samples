using System.Threading.Tasks;

namespace AbstractFactory_Sample
{
    public class EmailFactory : NotificacaoFactory, IEmailFactory
    {
        public EmailFactory()
        {

        }

        public Task GerarNotificacao(string origem, string destino)
        {
            GerarNotificacaoEmail(origem, destino);

            return Task.CompletedTask;
        }
    }
}
