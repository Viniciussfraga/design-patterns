using AbstractFactoryWithAbstractClass.AbstractClass;
using AbstractFactoryWithAbstractClass.ConcretClass;
using AbstractFactoryWithAbstractClass.Enums;

namespace AbstractFactoryWithAbstractClass.Factorys
{
    public sealed class BoloFactory : MassasAbstractFactory
    {
        public override MassaBase CriarMassa(TipoMassa tipoMassa)
        {
            var tipoBolo = (TipoBolo)tipoMassa;

            switch (tipoBolo)
            {
                case TipoBolo.Chocolate:
                    return new BoloChocolate();
                case TipoBolo.Laranja:
                    return new BoloLaranja();
                default:
                    throw new ArgumentOutOfRangeException("Tipo não implementado");
            }
        }
    }
}
