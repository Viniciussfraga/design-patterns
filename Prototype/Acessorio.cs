namespace Prototype
{
    public class Acessorio : ICloneable
    {
        public string Nome { get; set; }

        public object Clone()
        {
            return (Acessorio)this.MemberwiseClone();
        }
    }
}