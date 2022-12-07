using Builder_Sample;
using System;

namespace AnonymousTypeAndDynamic_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new
            {
                Produto = "Geladeira",
                Valor = 500m
            };

            /*Podemos usar um objeto anonimo como alternativa na criação de um objeto fortemente tipado.
             Entretanto, ao passar tal objeto via parametro e recebe-lo como dynamic, por este ser do tipo internal
             ele só terá acesso as propriedades se este objeto for usado na mesma classe ou em outra classe dentro do 
             mesmo assembly*/

            //Lista dynamic dentro da classe em que foi criada
            Console.WriteLine($@"Usando lista anonima na mesma classe em que foi criada. 
                                 {lista.Produto} e {lista.Valor}");

            //Lista anonima enviada como dynamic para uma classe externa de onde foi criada, porém no mesmo assembly (projeto).
            //Retornará os valores da lista
            var classeDynamicMesmoAssembly = new DynamicClassSameAssembly();
            classeDynamicMesmoAssembly.ReceberLista(lista);

            //Lista anonima enviada como dynamic para uma classe em outro assembly (projeto). Haverá exception
            var classeDynamic = new DynamicClassOtherAssembly();
            classeDynamic.ReceberLista(lista);

            Console.ReadKey();
        }
    }
}
