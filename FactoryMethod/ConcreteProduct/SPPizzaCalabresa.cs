using FactoryMethod.Model;

namespace FactoryMethod.ClassesDerivadas
{
    public class SPPizzaCalabresa : Pizza
    {
        public SPPizzaCalabresa()
        {
            Nome = "Pizza de calabresa Paulista";
            Massa = "Massa fina crocante";
            Molho = "Molho de tomate italiano";
            Ingredientes.Add("Fatias de calabresa defumada especial");
            Ingredientes.Add("Queijo Parmessão italiano tradicional");
        }
    }
}
