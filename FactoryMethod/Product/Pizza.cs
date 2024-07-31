using System.Collections;
using System.Text;

namespace FactoryMethod.Model
{
    public abstract class Pizza
    {
        protected string Nome { get; set; }
        protected string Massa { get; set; }
        protected string Molho { get; set; }
        protected ArrayList Ingredientes = new();

        public string Preparar()
        {
            StringBuilder sb = new();
            sb.Append($"Preparando {Nome} \n");
            sb.Append($"{Massa} \n");
            sb.Append($"{Molho} \n");
            sb.Append($"Ingredientes:\n");

            foreach (var ingrediente in Ingredientes)
            {
                sb.Append($"\t{ingrediente}\n");
            }

            sb.Append(Cozinhar());
            sb.Append(Fatiar());
            sb.Append(Embalar());
            return sb.ToString();
        }

        private string Cozinhar()
        {
            return "Cozinhar por 25 minutos a 350º \n";
        }
        private string Fatiar()
        {
            return $"Fatiando pizza de {Nome}";
        }

        private string Embalar()
        {
            return $"Embalando pizza de {Nome}";
        }
    }
}
