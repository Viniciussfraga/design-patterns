using FactoryMethod.ConcreteCreator;
using FactoryMethod.FactoryMethod;

namespace FactoryMethod.SimpleFactory
{
    public class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria;
            switch (local)
            {
                case "S":
                    pizzaria = new SPPizzaFactory();
                    break;
                case "R":
                    pizzaria = new RJPizzaFactory();
                    break;
                default:
                    throw new NotImplementedException($"A pizzaria {local} não existe.");
            }
            return pizzaria;
        }
    }

    //classe usada para escolher a instancia do factoryMethod q vai ser utilizado
}
