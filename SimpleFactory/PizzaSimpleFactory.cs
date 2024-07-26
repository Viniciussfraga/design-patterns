namespace SimpleFactory
{
    public class PizzaSimpleFactory
    {
        public static Pizza CriarPizza(string tipo)
        {
            Pizza pizza;
            switch (tipo.ToLower())
            {
                case "calabresa":
                    pizza = new PizzaCalabresa();
                    break;
                case "mussarela":
                    pizza = new PizzaMussarela();
                    break;
                default: throw new NotImplementedException("Sabor inexistente!");
            }
            return pizza;
        }
    }
}
