using AbstractFactoryWithAbstractClass.AbstractClass;
using AbstractFactoryWithAbstractClass.Enums;

namespace AbstractFactoryWithAbstractClass.ConcretClass
{
    public class PizzaCalabresa : Pizza
    {
        public PizzaCalabresa() : base(TipoMassa.Pizza, "Pizza Calabresa")
        {
            Ingredientes.Add("Calabresa em cubos e tomates em cubos");
        }
    }
}
