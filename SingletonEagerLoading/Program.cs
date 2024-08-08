using SingletonStatic;

Parallel.Invoke(
    () => AcessoThread1(),
    () => AcessoThread2()
);

Console.ReadLine();

static void AcessoThread2()
{
    Singleton s1 = Singleton.Instance;
    Console.WriteLine("Thread 1");
}

static void AcessoThread1()
{
    Singleton s2 = Singleton.Instance;
    Console.WriteLine("Thread 2");
}
