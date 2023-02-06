using AbstractFactory_Sample.Interface;
using System.Threading.Tasks;

namespace AbstractFactory_Sample
{
    public interface IFactory
    {
        Task<ICarAssemblyBase> CriarInstanciaMontagemVeiculo(string marca);
    }
}
