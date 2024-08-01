using AbstractFactoryWithAbstractClass.Enums;

namespace AbstractFactoryWithAbstractClass.AbstractClass
{
    public abstract class Bolo : MassaBase
    {
        protected Bolo(TipoMassa tipoMassa, string nome) : base(tipoMassa, nome)
        {
        }
    }
}
