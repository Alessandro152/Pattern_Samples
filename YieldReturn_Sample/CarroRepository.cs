using System.Collections.Generic;

namespace YieldReturn_Sample
{
    public class CarroRepository
    {
        public IEnumerable<Carro> GetListaCarrosComIEnumerable()
            => ListaCarros();

        public IList<Carro> GetListaCarrosComIList()
            => ListaCarros();

        public List<Carro> GetListaCarrosComList()
            => ListaCarros();

        public ICollection<Carro> GetListaCarrosComICollection()
            => ListaCarros();

        public IEnumerable<Carro> GetListaCarroComYield()
        {
            foreach (var carro in ListaCarros())
            {
                yield return carro;
            }
        }

        private List<Carro> ListaCarros()
        {
            return new List<Carro>
            {
                new Carro{ Marca = "Volkswagen", Modelo = "Fusca", AnoFabricacao = 1977 },
                new Carro{ Marca = "Volkswagen", Modelo = "Brasilia", AnoFabricacao = 1977 },
                new Carro{ Marca = "Volkswagen", Modelo = "Passat", AnoFabricacao = 1979 },
                new Carro{ Marca = "Volkswagen", Modelo = "Virtus", AnoFabricacao = 2023 },
                new Carro{ Marca = "Ford", Modelo = "Belina", AnoFabricacao = 1980 },
                new Carro{ Marca = "Ford", Modelo = "Focus", AnoFabricacao = 2003 },
                new Carro{ Marca = "Chevrolet", Modelo = "Opala Comodoro", AnoFabricacao = 1988 },
                new Carro{ Marca = "Chevrolet", Modelo = "Marajó", AnoFabricacao = 1985 },
                new Carro{ Marca = "Fiat", Modelo = "Elba", AnoFabricacao = 1995 },
                new Carro{ Marca = "Fiat", Modelo = "Uno", AnoFabricacao = 2000 }
            };
        }
    }
}
