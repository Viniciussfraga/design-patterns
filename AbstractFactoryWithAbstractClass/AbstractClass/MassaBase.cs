using AbstractFactoryWithAbstractClass.Enums;
using System.Collections;

namespace AbstractFactoryWithAbstractClass.AbstractClass
{
    public abstract class MassaBase
    {
        public TipoMassa TipoMassa { get; set; }
        public string Nome {  get; set; }
        public ArrayList Ingredientes = new();

        protected MassaBase(TipoMassa tipoMassa, string nome)
        {
            TipoMassa = tipoMassa;
            Nome = nome;
        }
    }
}
