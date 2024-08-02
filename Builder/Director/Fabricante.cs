using Builder.Builder;

namespace Builder.Director
{
    public class Fabricante
    {
        public void Build(ComputadorBuilder cb){
            cb.BuildDipositivos();
            cb.BuidSO();
        }
    }
}