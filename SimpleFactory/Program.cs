using SimpleFactory;

Pizza pizzaMussarela = PizzaSimpleFactory.CriarPizza("mussarela");
pizzaMussarela.Preparar();
pizzaMussarela.Assar(15);
pizzaMussarela.Embalar();

Pizza pizzaCalabresa = PizzaSimpleFactory.CriarPizza("Calabresa");
pizzaCalabresa.Preparar();
pizzaCalabresa.Assar(20);
pizzaCalabresa.Embalar();

Console.ReadLine();

