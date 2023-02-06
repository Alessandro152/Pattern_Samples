using AbstractFactory_Sample.Interface;
using System.Threading.Tasks;

namespace AbstractFactory_Sample
{
    public class VeiculoFactory : IVeiculoFactory
    {
        public VeiculoFactory()
        {
        }

        /// <summary>
        /// Identifica a marca e cria a instancia para iniciar montagem do veículo
        /// </summary>
        /// <param name="marca"></param>
        /// <returns>Uma instância de marca de veículo para iniciar a montagem</returns>
        public Task<ICarAssemblyBase> CriarInstanciaMontagemVeiculo(string marca)
        {
            /*
             * No exemplo temos apenas um swtich criando a instância de uma marca a partir
             * do informado no início do programa.
             * 
             * Numa situação real, aqui caberiam lógicas de negócio para criação da instância.
             */

            ICarAssemblyBase result = null;

            switch (marca.ToLower())
            {
                case "volkswagen":
                    result = new Volkswagen();
                    break;
                case "ford":
                    result = new Ford();
                    break;
                case "fiat":
                    result = new Fiat();
                    break;  
                default:
                    break;
            }

            return Task.FromResult(result);
        }
    }
}
