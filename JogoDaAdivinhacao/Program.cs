namespace JogoDaAdivinhacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExibirLogotipo();
            LogicaJogo();
        }

        static void ExibirLogotipo()
        {
            Console.WriteLine(@"
                 ██╗ ██████╗  ██████╗  ██████╗     ██████╗  █████╗      █████╗ ██████╗ ██╗██╗   ██╗██╗███╗   ██╗██╗  ██╗ █████╗  ██████╗ █████╗  ██████╗ 
                 ██║██╔═══██╗██╔════╝ ██╔═══██╗    ██╔══██╗██╔══██╗    ██╔══██╗██╔══██╗██║██║   ██║██║████╗  ██║██║  ██║██╔══██╗██╔════╝██╔══██╗██╔═══██╗
                 ██║██║   ██║██║  ███╗██║   ██║    ██║  ██║███████║    ███████║██║  ██║██║██║   ██║██║██╔██╗ ██║███████║███████║██║     ███████║██║   ██║
            ██   ██║██║   ██║██║   ██║██║   ██║    ██║  ██║██╔══██║    ██╔══██║██║  ██║██║╚██╗ ██╔╝██║██║╚██╗██║██╔══██║██╔══██║██║     ██╔══██║██║   ██║
            ╚█████╔╝╚██████╔╝╚██████╔╝╚██████╔╝    ██████╔╝██║  ██║    ██║  ██║██████╔╝██║ ╚████╔╝ ██║██║ ╚████║██║  ██║██║  ██║╚██████╗██║  ██║╚██████╔╝
            ╚════╝  ╚═════╝  ╚═════╝  ╚═════╝     ╚═════╝ ╚═╝  ╚═╝    ╚═╝  ╚═╝╚═════╝ ╚═╝  ╚═══╝  ╚═╝╚═╝  ╚═══╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚═════╝╚═╝  ╚═╝ ╚═════╝ 
             ");
        }

        static void LogicaJogo()
        {
            Random Aleatorio = new Random();
            int x, r;
            r = Aleatorio.Next(1, 101);
            
            do
            {
                
                Console.WriteLine("Digite um numero entre 1 a 100");
                x = int.Parse(Console.ReadLine());
                if (x == r)
                {
                    Console.Clear();
                    Console.WriteLine("Parabens voce acertou o numero secreto!");
                    break;
                }
                else if (x > r)
                {
                    Console.Clear();
                    Console.WriteLine("O numero {0} é maior que o numero secreto", x);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("O numero {0} é menor que o numero secreto", x);
                }
                

            } while (true);

            Console.WriteLine("O jogo acabou. Você acertou o número secreto!");

        }
    }
}
