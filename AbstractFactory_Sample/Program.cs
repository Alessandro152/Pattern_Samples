using System;

namespace AbstractFactory_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmailFactory factory = new EmailFactory();

            factory.GerarNotificacao(string.Empty, string.Empty);

            ISmsFactory factory1 = new SmsFactory();

            factory1.GerarNotificacao(string.Empty, string.Empty);

            Console.ReadKey();
        }
    }
}
