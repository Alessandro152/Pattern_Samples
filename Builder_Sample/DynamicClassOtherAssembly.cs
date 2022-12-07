using System;

namespace Builder_Sample
{
    public class DynamicClassOtherAssembly
    {
        public void ReceberLista(dynamic lista)
        {
            try
            {
                Console.WriteLine(@$"Recebendo uma lista anonima com dynamic vinda por parametro de outro projeto. 
                                     {lista.Produto} e {lista.Valor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"Erro ao usar as propridades de uma lista anonima recebida por objeto dinamico vindo de outro projeto
                                     {ex.Message}");
            }
        }
    }
}
