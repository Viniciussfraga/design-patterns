using FactoryMethod.ClassesDerivadas;
using FactoryMethod.FactoryMethod;
using FactoryMethod.Model;

namespace FactoryMethod.ConcreteCreator
{
    public class SPPizzaFactory : PizzaFactoryMethod
    {
        public SPPizzaFactory()
        {
            AdicionarInstanciasFactory();
        }
        protected override void AdicionarInstanciasFactory()
        {
            Instancias = new Dictionary<string, Func<Pizza>>()
            {
                { "M", () => new SPPizzaMussarela() },
                { "C", () => new SPPizzaCalabresa() }
            };
        }
    }
    //classe que herda da classe abstrata utilizada para criar a instancia do sabor da pizza já com o local
}
