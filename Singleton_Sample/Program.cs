using System;

namespace Singleton_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Singleton.GetInstance();
            Console.WriteLine(Singleton.Instancia);

            Singleton.GetInstance();
            Console.WriteLine(Singleton.Instancia);

            Console.ReadKey();
        }
    }
}
