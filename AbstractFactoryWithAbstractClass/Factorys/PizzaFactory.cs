using AbstractFactoryWithAbstractClass.AbstractClass;
using AbstractFactoryWithAbstractClass.ConcretClass;
using AbstractFactoryWithAbstractClass.Enums;

namespace AbstractFactoryWithAbstractClass.Factorys
{
    public class PizzaFactory : MassasAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoPizza = (TipoPizza)tipoMassa;

            switch (tipoPizza)
            {
                case TipoPizza.Mussarela:
                    return new PizzaMussarela();
                case TipoPizza.Calabresa:
                    return new PizzaCalabresa();
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
