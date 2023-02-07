using System;

namespace Builder_Sample
{
    public abstract class VehicleBuilder
    {
        protected string Engine { get; private set; }
        protected string Color { get; private set; }
        protected string Wheels { get; private set; }

        protected void Start(string motor,
                             string cor,
                             string rodas)
        {
            Engine = motor;
            Color = cor;
            Wheels = rodas;
        }

        protected void AddColor()
            => Console.WriteLine($"Pintando o carro com a cor {Color}");

        protected void AddEngine()
            => Console.WriteLine($"Equipando o carro com o motor {Engine}");

        protected void AddWheels()
            => Console.WriteLine($"Instalando as rodas {Wheels}");
    }
}
