using FactoryMethod.Model;

namespace FactoryMethod.ClassesDerivadas
{
    public class SPPizzaMussarela : Pizza
    {
        public SPPizzaMussarela()
        {
            Nome = "Pizza de mussarela Paulista";
            Massa = "Massa fina crocante paulista";
            Molho = "Molho de tomate italiano paulista";
            Ingredientes.Add("Queijo Parmessão");
            Ingredientes.Add("Azeitonas Verdes");
        }
    }
}
