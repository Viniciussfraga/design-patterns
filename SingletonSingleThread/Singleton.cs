namespace SingletonSingleThread
{
    public class Singleton
    {
        private static Singleton instace;
        private int numeroDeInstancias = 0;
        private Singleton(){
            Console.WriteLine("Instanciando dentro do construtor privado");
            numeroDeInstancias++;
            Console.WriteLine($"Número de instâncias = {numeroDeInstancias}");
        }

        public static Singleton Instance{
            get{
                 if(instace == null){
                    Console.WriteLine($"Criando a primeira instância");
                    instace = new Singleton();      
                 } 
                return instace;
            }
        }
    }
}