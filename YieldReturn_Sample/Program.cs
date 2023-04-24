using System;
using System.Linq;

namespace YieldReturn_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new CarroRepository();

            var ienumerable = repo.GetListaCarrosComIEnumerable();
            foreach (var item in ienumerable.Where(x => x.Marca == "Volkswagen"))
            {
                Console.WriteLine($"Carro {item.Modelo} ano {item.AnoFabricacao}");
            }

            var ilist = repo.GetListaCarrosComIList();
            foreach (var item in ilist.Where(x => x.Marca == "Volkswagen"))
            {
                Console.WriteLine($"Carro {item.Modelo} ano {item.AnoFabricacao}");
            }

            var list = repo.GetListaCarrosComList();
            foreach (var item in list.Where(x => x.Marca == "Volkswagen"))
            {
                Console.WriteLine($"Carro {item.Modelo} ano {item.AnoFabricacao}");
            }

            var icollection = repo.GetListaCarrosComICollection();
            foreach (var item in icollection.Where(x => x.Marca == "Volkswagen"))
            {
                Console.WriteLine($"Carro {item.Modelo} ano {item.AnoFabricacao}");
            }

            var yieldreturn = repo.GetListaCarroComYield();
            foreach (var item in yieldreturn.Where(x => x.Marca == "Volkswagen"))
            {
                Console.WriteLine($"Carro {item.Modelo} ano {item.AnoFabricacao}");
            }

            Console.ReadKey();
        }
    }
}
