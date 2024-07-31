using FactoryMethod.Model;

namespace FactoryMethod.ClassesDerivadas
{
    public class RJPizzaMussarela : Pizza
    {
        public RJPizzaMussarela()
        {

            Nome = "Pizza de Mussarela Carioca";
            Massa = "Massa fina crocante Carioca";
            Molho = "Molho de tomate italiano Carioca";
            Ingredientes.Add("Azeitona Carioca");
            Ingredientes.Add("Queijo Parmessão italiano tradicional Carioca");
        }
    }
}
