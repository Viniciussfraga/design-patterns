using AbstractFactoryWithAbstractClass.AbstractClass;
using AbstractFactoryWithAbstractClass.Enums;

namespace AbstractFactoryWithAbstractClass.ConcretClass
{
    public class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base(TipoMassa.Pizza, "Pizza Mussarela")
        {
            Ingredientes.Add("Queijo mussarela gratinado e molho de tomate");
        }
    }
}
