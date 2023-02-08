namespace Builder_Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Método builder utilizado quando já temos um objeto complexo criado e vamos adicionar itens à ele
            */
            VolkswagenAssemblyBuilder.Start("1600", "L102", "standard").Build();
        }
    }
}
