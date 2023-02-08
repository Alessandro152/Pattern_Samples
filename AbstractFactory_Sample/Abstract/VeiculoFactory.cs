using AbstractFactory_Sample.Interface;

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
        public ICarAssemblyBase CriarInstanciaMontagemVeiculo(string marca)
        {
            /*
             * No exemplo temos apenas um swtich criando a instância de uma marca a partir
             * do informado no início do programa.
             * 
             * Numa situação real, aqui caberiam lógicas de negócio para criação da instância.
             */

            ICarAssemblyBase instancia = null;

            switch (marca.ToLower())
            {
                case "volkswagen":
                    instancia = new Volkswagen();
                    break;
                case "ford":
                    instancia = new Ford();
                    break;
                case "fiat":
                    instancia = new Fiat();
                    break;  
                default:
                    break;
            }

            return instancia;
        }
    }
}
