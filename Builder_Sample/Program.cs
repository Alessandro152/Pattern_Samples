using System;

namespace Builder_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Método builder utilizado quando já temos um objeto complexo criado e vamos adicionar itens a ele
            */
            var result = VolkswagenAssemblyBuilder.Start("1600", "L102", "Standard").Build();

            Console.WriteLine($"Pronto! Seu veículo com motor {result.Motor}, de cor {result.Cor} e rodas {result.Rodas} está disponível.");
        }
    }
}
