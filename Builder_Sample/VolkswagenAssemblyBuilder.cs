using AbstractFactory_Sample;
using System;

namespace Builder_Sample
{
    public sealed class VolkswagenAssemblyBuilder : VehicleBuilder
    {
        private VolkswagenAssemblyBuilder()
        {
        }

        public static VolkswagenAssemblyBuilder Start(string motor, string cor, string rodas)
            => new VolkswagenAssemblyBuilder
            {
                Engine = motor,
                Color = cor,
                Wheels = rodas
            };

        public VolkswagenBuild Build()
            => new VolkswagenBuild(AddEngine(), AddColor(), AddWheels());

        protected override string AddColor()
        {
            //Alguma lógica para adicionar a cor ao veículo
            Console.WriteLine($"Pintando o veículo na cor {Color}");
            return Color;
        }

        protected override string AddEngine()
        {
            //Alguma lógica para adicionar o motor ao veículo
            Console.WriteLine($"Instalando o motor {Engine} ao veículo");
            return Engine;
        }

        protected override string AddWheels()
        {
            //Alguma lógica para adicionar as rodas ao veículo
            Console.WriteLine($"Instalando as rodas {Wheels} no veículo");
            return Wheels;
        }
    }
}
