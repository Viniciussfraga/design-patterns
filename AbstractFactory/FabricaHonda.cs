namespace AbstractFactory
{
    public class FabricaHonda : IMontadora
    {
        public ISedan CriarSedan()
        {
            return new HondaCivic();
        }

        public ISuv CriarSuv()
        {
           return new HondaCrv();
        }
    }
}
