using AbstractFactory_Sample.Abstract;
using System;

namespace AbstractFactory_Sample
{
    public class Volkswagen : CarAssemblyBase
    {
        public Volkswagen() : base()
        {

        }

        public override void IniciarMontagemVeiculo(string modelo)
        {
            Console.WriteLine($"Iniciando a produção do {modelo}. A {nameof(Volkswagen)} agradece!!");
        }
    }
}
