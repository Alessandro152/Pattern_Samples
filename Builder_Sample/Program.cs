using System;

namespace Builder_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var coffee = CoffeeBuilder.Start(new Coffee())
                                      .Build("expresso");

            Console.WriteLine($"Your coffee has been done!!");
            Console.ReadKey();
        }
    }
}
