namespace Cronometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();   
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundo");
            Console.WriteLine("M - Minuto");
            Console.WriteLine("0 - Sair");
            Console.Write("Quanto tempo deseja contar? ");

            string resposta = Console.ReadLine().ToLower();            
            char tipo = char.Parse(resposta.Substring(resposta.Length - 1, 1));
            int tempoTotal = int.Parse(resposta.Substring(0, resposta.Length - 1));
            int mulplicador = 1;

            if (tipo == 'm')
            {
                mulplicador = 60;
            }

            if (tempoTotal == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(tempoTotal * mulplicador);

            Console.ReadKey();
        }

        static void Start(int tempoTotal)
        {
            int tempoAtual = 0;

            while (tempoAtual != tempoTotal)
            {
                Console.Clear();
                tempoAtual++;
                Console.WriteLine(tempoAtual);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado!");
            Thread.Sleep(2500);
            Menu();
        }        

        static void PreStart(int tempoTotal)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(1500);

            Start(tempoTotal);
        }
    }
}
