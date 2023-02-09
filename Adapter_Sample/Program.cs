using System;

namespace Adapter_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * O objetivo deste padrão de projeto é conectar dois objetos não-compativeis. Ex.: projeto legado à um projeto novo
             * ou acessar o repositorio de leitura durante a manipulação do domínio em uma persistência.
             */
            var adapter = new VehicleAssemblyAdapter();
        }
    }
}
