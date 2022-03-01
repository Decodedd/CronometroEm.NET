namespace Cronometro
{
    public class Funcoes
    {
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("Qual tipo de contagem deseja?");
            Console.WriteLine("C - Ordem Crescente");
            Console.WriteLine("D - Ordem Decrescente");
            Console.WriteLine("X - Sair");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Escolha uma opção:");

            char tipoContagem = char.Parse(Console.ReadLine().ToLower());

            if (tipoContagem == 'x')
            {
                Console.WriteLine("Programa Encerrado.");
                System.Environment.Exit(0);
            }

            if (tipoContagem == 'c' || tipoContagem == 'd')
            {
                Console.Clear();
                Console.WriteLine("Agora digite o tempo em minutos ou segundos seguindo o exemplo:");
                Console.WriteLine("10s - se quiser contar 10 segundos");
                Console.WriteLine("2m  - se quiser contar 2 minutos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("------------------");
                Console.WriteLine("Entre com o valor:");

                string dados = Console.ReadLine().ToLower();

                if (dados.Substring(0, 1) == "0")
                {
                    Console.WriteLine("Program Encerrado.");
                    System.Environment.Exit(0);
                }

                char tipo = char.Parse(dados.Substring(dados.Length - 1, 1));
                int tempo = int.Parse(dados.Substring(0, dados.Length - 1));
                int multiplicador = 1;

                if (tipo == 's')
                    PreIniciar(tempo * multiplicador, tipoContagem);

                else if (tipo == 'm')
                {
                    multiplicador = 60;
                    PreIniciar(tempo * multiplicador, tipoContagem);
                }

                else
                {
                    Console.WriteLine("Entrada Inválida.");
                    Thread.Sleep(2000);
                    Menu();
                }
            }

            else
            {
                Console.WriteLine("Entrada Inválida.");
                Thread.Sleep(2000);
                Menu();
            }
        }
        public void PreIniciar(int tempo, char tipoContagem)
        {
            Console.Clear();
            Console.WriteLine("Preparado?");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Inciando...");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Go!");
            Thread.Sleep(1000);

            IniciarContagem(tempo, tipoContagem);

        }
        public void IniciarContagem(int tempo, char tipoContagem)
        {
            int tempoAtual = 0;

            if (tipoContagem == 'c')
            {
                while (tempoAtual != tempo)
                {
                    tempoAtual++;
                    Console.Clear();
                    Console.Write(tempoAtual);
                    Thread.Sleep(1000);
                }
            }

            else
            {
                while (tempo > 0)
                {
                    Console.Clear();
                    Console.Write(tempo);
                    Thread.Sleep(1000);
                    tempo--;
                }
            }

            Console.Clear();
            Console.WriteLine("Fim!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}