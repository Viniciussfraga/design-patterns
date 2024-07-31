using FactoryMethod.FactoryMethod;
using FactoryMethod.SimpleFactory;

Console.WriteLine("====== Pizzaria ======\n");
Console.WriteLine("Informe o local (S)São Paulo (R)Rio de Janeiro");
var localEscolhido = Console.ReadLine();

Console.WriteLine("Escolha a pizza (M)Mussarela (C)Calabresa");
var pizzaEscolhida  = Console.ReadLine();

try
{
    PizzaFactoryMethod pizzaria = PizzaSimpleFactory.CriarPizzaria(localEscolhido);
    var pizza = pizzaria.MontaPizza(pizzaEscolhida);
    Console.WriteLine(pizza.Preparar());
    Console.WriteLine("\npizza concluida com sucesso");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.ReadLine();