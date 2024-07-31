namespace AbstractFactory
{
    public class FabricaHyundai : IMontadora
    {
        public ISedan CriarSedan()
        {
            return new Hb20Hyundai();
        }

        public ISuv CriarSuv()
        {
            return new CretaHyundai();
        }
    }
}
