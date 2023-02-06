using System;

namespace AbstractFactory_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O objetivo deste projeto é contextualizar como funciona o padrão de projeto Factory, no caso, abstract factory.
               Através das interfaces, garantimos o contrato de criar uma instância de uma marca de veículo e assim iniciar a 
               montagem do mesmo.
                
               O atrativo do padrão factory é para situações onde temos a criação de "produtos" que possuem uma base em comum, neste caso
               um veículo.
            */

            //Informar marca
            Console.WriteLine("Informe a marca do veículo");
            var marca = Console.ReadLine();

            //Informar modelo
            Console.WriteLine("Informe o modelo do veículo");
            var modelo = Console.ReadLine();

            //Criar instancia da marca
            IVeiculoFactory factory = new VeiculoFactory();
            var produto = factory.CriarInstanciaMontagemVeiculo(marca).Result;

            if (produto is null)
            {
                Console.WriteLine("Marca não identificada");
                Environment.Exit(0);
            }

            //Iniciar produção do veículo
            produto.IniciarMontagemVeiculo(modelo);

            Console.ReadKey();
        }
    }
}
