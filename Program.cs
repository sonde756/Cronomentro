using System.Threading;

internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Start(int time)
        {
            int currentTime = 0;

        while(currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }

        Console.Clear();
        Console.WriteLine("Finalizado, reiniciando");Thread.Sleep(2000);
                Menu();

    }


    static void Menu(){
        Console.Clear();
        Console.WriteLine("10m = minutos ou 60s = 60 segundos");
        Console.WriteLine("S = Segundos");
        Console.WriteLine("M = Minutos");
        Console.WriteLine("0 = Sair");

        string data = Console.ReadLine().ToLower();
        char type = char.Parse(data.Substring(data.Length-1,1));
        int time = int.Parse(data.Substring(0, data.Length - 1));
        int multiplicador = 1;

        if(type == 'm')
            multiplicador = 60;
        if(time == 0)
            System.Environment.Exit(0);
        Start(time * multiplicador);







    }
}