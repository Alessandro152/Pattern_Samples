using Builder_Sample;

namespace Adapter_Sample
{
    public class VehicleAssemblyAdapter
    {
        public VehicleAssemblyAdapter()
        {
            
        }

        public VolkswagenBuild IniciarMontagemVolkswagen(string modelo, string cor, string motor, string rodas)
            => VolkswagenAssemblyBuilder.Start(motor, cor, rodas).Build();
    }
}
