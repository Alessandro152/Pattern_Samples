namespace Builder_Sample
{
    public class VolkswagenAssemblyBuilder : VehicleBuilder
    {
        public VolkswagenAssemblyBuilder(string motor,
                                         string cor,
                                         string rodas)
        {
            Start(motor, cor, rodas);
        }

        public void Build()
        {
            AddColor();
            AddEngine();
            AddWheels();
        }
    }
}
