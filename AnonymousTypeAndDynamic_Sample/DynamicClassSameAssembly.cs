using System;

namespace AnonymousTypeAndDynamic_Sample
{
    public class DynamicClassSameAssembly
    {
        public void ReceberLista(dynamic lista)
        {
            try
            {
                Console.WriteLine(@$"Recebendo uma lista anonima com dynamic vinda por parametro no mesmo assembly. 
                                     {lista.Produto} e {lista.Valor}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($@"Erro ao usar as propridades de uma lista anonima recebida por objeto dinamico no mesmo assembly
                                     {ex.Message}");
            }
        }
    }
}
