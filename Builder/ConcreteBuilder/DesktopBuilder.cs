using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    public class DesktopBuilder : ComputadorBuilder
    {
        Computador computador;
        public Computador TipoComputador => computador;

        public DesktopBuilder()
        {
            computador = new Computador("Desktop");
        }
        public override void BuidSO()
        {
           Console.WriteLine("Build dispositivos no Desktop...");
        }

        public override void BuildDipositivos()
        {
            Console.WriteLine("Build SO no Desktop...");
        }
    }
}