namespace Builder_Sample
{
    public abstract class VehicleBuilder
    {
        protected string Engine { get; set; }
        protected string Color { get; set; }
        protected string Wheels { get; set; }

        protected abstract string AddColor();
        protected abstract string AddEngine();
        protected abstract string AddWheels();
    }
}
