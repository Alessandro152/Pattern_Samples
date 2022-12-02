using System;

namespace AbstractFactory_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmailFactory factory = new EmailFactory();

            factory.GerarNotificacao(string.Empty, string.Empty);

            Console.WriteLine("Hello World!");
        }
    }
}
