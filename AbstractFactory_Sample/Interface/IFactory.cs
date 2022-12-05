using System.Threading.Tasks;

namespace AbstractFactory_Sample
{
    public interface IFactory
    {
        Task GerarNotificacao(string origem, string destino);
    }
}
