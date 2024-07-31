namespace AbstractFactory
{
    public interface IMontadora
    {
        ISuv CriarSuv();
        ISedan CriarSedan();
    }
}
