using AbstractFactory_Sample.Abstract;
using Builder_Sample;
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

            new VolkswagenAssemblyBuilder("1600", "L102", "standard").Build();
        }
    }
}
