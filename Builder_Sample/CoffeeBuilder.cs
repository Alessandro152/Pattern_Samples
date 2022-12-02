using System;

namespace Builder_Sample
{
    sealed class CoffeeBuilder
    {
        private static Coffee _coffee;
        private static CoffeeBuilder _coffeeBuilder;

        public CoffeeBuilder()
        {

        }

        public static CoffeeBuilder Start(Coffee coffee)
        {
            _coffee = coffee;
            _coffeeBuilder = new CoffeeBuilder();

            return _coffeeBuilder;
        }

        public Coffee Build(string type)
        {
            Console.WriteLine($"Coffee is type of {type} will be prepared");
            Console.WriteLine("Add suggar to your coffee");

            return _coffee;
        }
    }
}
