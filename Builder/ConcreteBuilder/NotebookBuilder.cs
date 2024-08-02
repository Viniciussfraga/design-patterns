using Builder.Builder;
using Builder.Product;

namespace Builder.ConcreteBuilder
{
    public class NotebookBuilder : ComputadorBuilder
    {
        Computador computador;
        public Computador TipoComputador => computador;

        public NotebookBuilder()
        {
            computador = new Computador("Notebook");
        }
        public override void BuidSO()
        {
           Console.WriteLine("Build dispositivos no Notebook...");
        }

        public override void BuildDipositivos()
        {
            Console.WriteLine("Build SO no Notebook...");
        }
    }
}