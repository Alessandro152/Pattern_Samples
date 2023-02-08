using System;

namespace Builder_Sample
{
    public abstract class VehicleBuilder
    {
        protected string Engine { get; set; }
        protected string Color { get; set; }
        protected string Wheels { get; set; }

        protected void AddColor()
            => Console.WriteLine($"Pintando o carro com a cor {Color}");

        protected void AddEngine()
            => Console.WriteLine($"Equipando o carro com o motor {Engine}");

        protected void AddWheels()
            => Console.WriteLine($"Instalando as rodas {Wheels}");
    }
}
