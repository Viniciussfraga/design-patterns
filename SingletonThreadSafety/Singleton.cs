namespace SingletonThreadSafety
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static readonly object lockObject = new object();
        private static int contador = 0;
        private Singleton(){
            contador++;
            Console.WriteLine($"Instância {contador}");
        }

        public static Singleton Instance
        {
            get
            {
                if(instance == null){
                    lock(lockObject) // realiza o bloqueio da instância toda vez, e depois verifica se a instância já existe o que é muito oneroso.
                    {
                        if(instance == null)
                            instance = new Singleton();
                    }
                }
                return instance;
            }
        }
    }
}