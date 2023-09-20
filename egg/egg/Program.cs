internal class Program
{
    static void MyThreadChicken()
    {
        for (int i = 0; i < 100; i++)
            Console.WriteLine("Яйцо");
    }
    private static void Main(string[] args)
    {
        Thread chicken = new(MyThreadChicken);
        chicken.Start();
        for (int i = 0; i < 100; i++)
            Console.WriteLine("Курица");
        MyThreadAnswer(chicken);
    }
    static void MyThreadAnswer(Thread chicken)
    {

        bool ans = chicken.IsAlive;
        Console.WriteLine(ans ? "Спор Окончен. Победило Яйцо." : "Спор окончен. Победила Курица.");
    }
}