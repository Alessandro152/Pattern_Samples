namespace Builder_Sample
{
    public sealed class VolkswagenAssemblyBuilder : VehicleBuilder
    {
        private VolkswagenAssemblyBuilder()
        {
        }

        public static VolkswagenAssemblyBuilder Start(string motor, string cor, string rodas)
            => new VolkswagenAssemblyBuilder
            {
                Engine = motor,
                Color = cor,
                Wheels = rodas
            };

        public void Build()
        {
            AddColor();
            AddEngine();
            AddWheels();
        }
    }
}
