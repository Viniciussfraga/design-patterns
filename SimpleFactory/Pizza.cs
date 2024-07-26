namespace SimpleFactory
{
    public abstract class Pizza
    {
        public string Nome { get; set; }
        public void Assar(int tempo)
        {
            Console.WriteLine($"Pizza de {Nome} assando por {tempo} min.");
        }

        public void Embalar()
        {
            Console.WriteLine($"Embalando pizza de {Nome}.");
        }

        public void Preparar()
        {
            Console.WriteLine($"Preparando pizza de {Nome}.");
        }
    }
}
