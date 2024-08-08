namespace SingletonStatic
{
    public sealed class Singleton
    {
        private static int contador = 0;
        private static readonly Singleton instance;
        private Singleton() {}
        static Singleton(){
            contador++;
            System.Console.WriteLine($"Instancia : {contador}");
            instance = new Singleton();
        }

        public static Singleton Instance{
            get { return instance; }
        }
    }
}