using System;

namespace AbstractFactory_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            /* O objetivo deste padrão de projeto é, através de interfaces, garantir o contrato de criar uma 
               "fábrica" que devolva um "produto", no caso, uma instância de uma marca de veículo e assim iniciar a 
               montagem do mesmo.
                
               O atrativo do padrão factory é para situações onde temos a criação de "produtos" que possuem uma base em comum, que neste caso,
               um veículo.
            */

            //Informar marca
            Console.WriteLine("Informe a marca do veículo");
            var marca = Console.ReadLine();

            //Informar modelo
            Console.WriteLine("Informe o modelo do veículo");
            var modelo = Console.ReadLine();

            //Informar cor
            Console.WriteLine("Informe a cor do veículo");
            var cor = Console.ReadLine();

            //Informar motor
            Console.WriteLine("Informe a motorização do veículo");
            var motor = Console.ReadLine();

            //Informar rodas
            Console.WriteLine("Informe as rodas do veículo");
            var rodas = Console.ReadLine();

            //Criar instancia da marca
            IVeiculoFactory factory = new VeiculoFactory();
            var produto = factory.CriarInstanciaMontagemVeiculo(marca);

            if (produto is null)
            {
                Console.WriteLine("Marca não identificada");
                Environment.Exit(0);
            }

            //Iniciar produção do veículo
            produto.IniciarMontagemVeiculo(modelo, cor, motor, rodas);

            Console.ReadKey();
        }
    }
}
