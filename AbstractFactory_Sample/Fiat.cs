using AbstractFactory_Sample.Abstract;
using System;

namespace AbstractFactory_Sample
{
    public class Fiat : CarAssemblyBase
    {
        public Fiat() : base()
        {

        }

        public override void IniciarMontagemVeiculo(string modelo)
            => Console.WriteLine($"Iniciando a produção do {modelo}. A {nameof(Fiat)} agradece!!");
    }
}
