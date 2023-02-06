using AbstractFactory_Sample.Abstract;
using System;

namespace AbstractFactory_Sample
{
    public class Ford : CarAssemblyBase
    {
        public Ford() : base()
        {

        }

        public override void IniciarMontagemVeiculo(string modelo)
            => Console.WriteLine($"Iniciando a produção do {modelo}. A {nameof(Ford)} agradece!!");
    }
}
