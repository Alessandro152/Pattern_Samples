namespace Singleton_Sample
{
    public sealed class Singleton
    {
        private static Singleton _singleton;

        public static string Instancia { get; set; }

        public static Singleton GetInstance()
        {
            if(_singleton is null)
            {
                _singleton = new Singleton();
                Instancia = "criando nova instancia singleton";

                return _singleton;
            }

            Instancia = "utilizando mesma instancia singleton";
            return _singleton;
        }
    }
}
