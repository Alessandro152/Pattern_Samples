using AbstractFactory_Sample.Abstract;
using Adapter_Sample;
using System;

namespace AbstractFactory_Sample
{
    public class Volkswagen : CarAssemblyBase
    {
        private readonly VehicleAssemblyAdapter _adapter;

        public Volkswagen() : base()
        {
            _adapter = new VehicleAssemblyAdapter();
        }

        public string Modelo { get; private set; }
        public string Cor { get; private set; }
        public string Motor { get; private set; }
        public string Rodas { get; private set; }

        public override void IniciarMontagemVeiculo(string modelo, string cor, string motor, string rodas)
        {
            var result = _adapter.IniciarMontagemVolkswagen(modelo, cor, motor, rodas);

            new Volkswagen()
            {
                Modelo = result.Modelo,
                Cor = result.Cor,
                Motor = result.Motor,
                Rodas = result.Rodas
            };


            Console.WriteLine($"Iniciando a produção do {modelo}. A {nameof(Volkswagen)} agradece!!");
        }
    }
}
