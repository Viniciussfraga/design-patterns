using AbstractFactoryWithAbstractClass.Enums;

namespace AbstractFactoryWithAbstractClass.AbstractClass
{
    public abstract class Pizza : MassaBase
    {
        protected Pizza(TipoMassa tipoMassa, string nome) : base(tipoMassa, nome)
        {
        }
    }
}
