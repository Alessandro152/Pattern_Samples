namespace Builder_Sample
{
    public sealed class Volkswagen
    {
        public Volkswagen(string motor, string cor, string rodas)
        {
            Motor = motor;
            Cor = cor;
            Rodas = rodas;
        }

        public string Modelo { get; private set; }
        public string Cor { get; private set; }
        public string Motor { get; private set; }
        public string Rodas { get; private set; }
    }
}
