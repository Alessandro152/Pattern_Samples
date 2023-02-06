using AbstractFactory_Sample.Interface;

namespace AbstractFactory_Sample.Abstract
{
    public abstract class CarAssemblyBase : ICarAssemblyBase
    {
        public abstract void IniciarMontagemVeiculo(string destino);
    }
}
