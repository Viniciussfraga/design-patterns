using FactoryMethod.Model;

namespace FactoryMethod.FactoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        public Dictionary<string, Func<Pizza>> Instancias;
        public Pizza MontaPizza(string tipo)
        {
            Pizza pizza = CriarPizza(tipo);
            return pizza;
        }

        protected Pizza CriarPizza(string tipo)
        {
            var factory = Instancias[tipo];
            return factory();
        }
        protected abstract void AdicionarInstanciasFactory();
    }
}
