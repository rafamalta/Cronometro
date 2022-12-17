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
            Console.WriteLine("Quanto tempo deseja contar?");

            string resposta = Console.ReadLine().ToLower();            
            char tipo = char.Parse(resposta.Substring(resposta.Length - 1, 1));
            Console.WriteLine(resposta);
            Console.WriteLine(tipo);

            Console.ReadKey();
        }

        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
        }        
    }
}
