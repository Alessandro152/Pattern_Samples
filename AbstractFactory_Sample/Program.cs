using System;

namespace AbstractFactory_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            INotificacaoFactory emailNotificacao = new EmailFactory();

            emailNotificacao.GerarNotificacao(string.Empty, string.Empty);

            INotificacaoFactory smsNotificacao = new SmsFactory();

            smsNotificacao.GerarNotificacao(string.Empty, string.Empty);

            Console.ReadKey();
        }
    }
}
