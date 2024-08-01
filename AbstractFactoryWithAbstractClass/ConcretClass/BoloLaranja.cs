using AbstractFactoryWithAbstractClass.AbstractClass;
using AbstractFactoryWithAbstractClass.Enums;

namespace AbstractFactoryWithAbstractClass.ConcretClass
{
    public class BoloLaranja : Bolo
    {
        public BoloLaranja() : base(TipoMassa.Bolo, "Bolo Laranja")
        {
            Ingredientes.Add("Com cobertura de calda de laranja");
        }
    }
}
