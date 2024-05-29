using SingleTon;

class Program
{
    static void Main(string[] args)
    {
        SingletonLogger singletonLogger1 = new SingletonLogger();
        SingletonLogger singletonLogger2 = new SingletonLogger();

        singletonLogger1.Log("hello word");
        singletonLogger2.Log("hi word");

        Console.WriteLine(Object.ReferenceEquals(singletonLogger1, singletonLogger2));
        Console.WriteLine(string.Join(", ", singletonLogger1.LogMessages));
        Console.WriteLine(string.Join(", ", singletonLogger2.LogMessages));
    }
}