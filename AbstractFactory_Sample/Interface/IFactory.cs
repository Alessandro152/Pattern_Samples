using AbstractFactory_Sample.Interface;

namespace AbstractFactory_Sample
{
    public interface IFactory
    {
        ICarAssemblyBase CriarInstanciaMontagemVeiculo(string marca);
    }
}
