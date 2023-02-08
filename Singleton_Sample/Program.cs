using System;

namespace Singleton_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O objetivo deste padrão de projeto é criar uma única instância a ser utilizada durante o runtime
             * da aplicação e, ao finalizá-la, ser descartada
             */
            Singleton.GetInstance();
            Console.WriteLine(Singleton.Instancia);

            Singleton.GetInstance();
            Console.WriteLine(Singleton.Instancia);

            Console.ReadKey();
        }
    }
}
