using AbstractFactoryWithAbstractClass.AbstractClass;
using AbstractFactoryWithAbstractClass.Enums;

namespace AbstractFactoryWithAbstractClass.ConcretClass
{
    public class BoloChocolate : Bolo
    {
        public BoloChocolate() : base(TipoMassa.Bolo, "Bolo Chocolate")
        {
            Ingredientes.Add("Com cobertura de chocolate Nestle");
        }
    }
}
