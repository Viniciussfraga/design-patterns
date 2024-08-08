namespace SingletonStatic
{
    public sealed class Singleton
    {
        //eager loading
        private static readonly Lazy<Singleton> instanceLock = new Lazy<Singleton>( () => new Singleton() );
        private static int contador = 0;
        private Singleton() {
            contador++;
            Console.WriteLine($"Instancia : {contador}");
        }
        public static Singleton Instance{
            get { return instanceLock.Value; }
        }
    }
}