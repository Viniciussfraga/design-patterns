using Builder.Product;

namespace Builder.Builder
{
    public abstract class ComputadorBuilder
    {
        Computador tipoComputador {get;}

        public abstract void BuidSO();
        public abstract void BuildDipositivos();
    }
}