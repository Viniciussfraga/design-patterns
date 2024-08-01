using AbstractFactoryWithAbstractClass.AbstractClass;
using AbstractFactoryWithAbstractClass.Enums;
using AbstractFactoryWithAbstractClass.Factorys;

//obtem fábricas
var boloFactory = MassasAbstractFactory.CriarFabricaMassas(TipoMassa.Bolo);
var pizzaFactory = MassasAbstractFactory.CriarFabricaMassas(TipoMassa.Pizza);

//cria os objetos com base no tipo : bolo
var boloChocolate = boloFactory.CriarMassa((TipoMassa)TipoBolo.Chocolate);
var boloLaranja = boloFactory.CriarMassa((TipoMassa)TipoBolo.Laranja);

//cria os objetos com base no tipo : pizza
var pizzaMussarela = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Mussarela);
var pizzaCalabresa = pizzaFactory.CriarMassa((TipoMassa)TipoPizza.Calabresa);

ExibeDetalhes(boloChocolate);
ExibeDetalhes(boloLaranja);
ExibeDetalhes(pizzaMussarela);
ExibeDetalhes(pizzaCalabresa);

Console.ReadLine();

static void ExibeDetalhes(MassaBase massaBase)
{
    Console.WriteLine($"Tipo : {massaBase.TipoMassa}");
    Console.WriteLine(massaBase.Nome);
    Console.WriteLine(massaBase.Ingredientes[0].ToString());
    Console.WriteLine("\n");
}