using FactoryMethod.Model;

namespace FactoryMethod.ClassesDerivadas
{
    public class RJPizzaCalabresa : Pizza
    {
        public RJPizzaCalabresa()
        {

            Nome = "Pizza de calabresa Carioca";
            Massa = "Massa fina crocante Carioca";
            Molho = "Molho de tomate italiano Carioca";
            Ingredientes.Add("Fatias de calabresa defumada especial Carioca");
            Ingredientes.Add("Queijo Parmessão italiano tradicional Carioca");
        }
    }
}
