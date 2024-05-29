using System.Diagnostics;

namespace JOGODAMEMÓRIA
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] jogo = new int[4, 4];
            int[,] tela = new int[4, 4];

            //Para criar números aleatórios
            Random gerador = new Random();
            Stopwatch tempo = new Stopwatch();

            for (int i = 1; i <= 8; i++) //Atribui os pares de números às posições
            {
                int lin, col;
                for (int j = 0; j < 2; j++)
                {
                    do
                    {
                        lin = gerador.Next(0, 4);
                        col = gerador.Next(0, 4);

                    } while (jogo[lin, col] != 0);
                    jogo[lin, col] = i;
                }
            }
            tempo.Start();
            int acertos = 0, erros = 0;
            do
            {

                Console.Write("   ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}  ", j + 1);
                }
                Console.WriteLine("\n-------------------");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("{0} |", i + 1);
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" {0} |", tela[i, j]);
                    }
                    Console.WriteLine("\n");

                }
                Console.WriteLine();



                int lin1, col1;
                do
                {
                    do
                    {
                        Console.WriteLine("Escolha uma linha para jogar [1, 4]: ");
                        lin1 = int.Parse(Console.ReadLine());

                    } while (lin1 < 1 || lin1 > 4);

                    do
                    {
                        Console.WriteLine("Escolha uma coluna para jogar [1, 4]: ");
                        col1 = int.Parse(Console.ReadLine());

                    } while (col1 < 1 || col1 > 4);


                    lin1--;
                    col1--;

                    if (tela[lin1, col1] != 0)
                        Console.WriteLine("você já escolheu essa posição!");
                } while (tela[lin1, col1] != 0);


                tela[lin1, col1] = jogo[lin1, col1];

                Console.Write("   ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}  ", j + 1);
                }
                Console.WriteLine("\n-------------------");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("{0} |", i + 1);
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" {0} |", tela[i, j]);
                    }
                    Console.WriteLine("\n");

                }
                Console.WriteLine();



                int lin2, col2;
                do
                {
                    do
                    {
                        Console.WriteLine("Escolha uma linha para jogar [1, 4]: ");
                        lin2 = int.Parse(Console.ReadLine());

                    } while (lin2 < 1 || lin2 > 4);

                    do
                    {
                        Console.WriteLine("Escolha uma coluna para jogar [1, 4]: ");
                        col2 = int.Parse(Console.ReadLine());

                    } while (col2 < 1 || col2 > 4);

                    lin2--;
                    col2--;

                    if (tela[lin2, col2] != 0)
                        Console.WriteLine("você já escolheu essa posição!");
                } while (tela[lin2, col2] != 0);


                tela[lin2, col2] = jogo[lin2, col2];

                Console.Write("   ");
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(" {0}  ", j + 1);
                }
                Console.WriteLine("\n-------------------");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write("{0} |", i + 1);
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(" {0} |", tela[i, j]);
                    }
                    Console.WriteLine("\n");

                }
                Console.WriteLine();


                if (jogo[lin1, col1] != jogo[lin2, col2])
                {
                    erros++;
                    tela[lin1, col1] = 0;
                    tela[lin2, col2] = 0;

                }
                else
                {
                    acertos++;

                }
                if (acertos < 8)
                {
                    Console.WriteLine("Deseja continuar jogando? \n\n*DIGITE 0 PARA SAIR \n*DIGITE 1 PARA CONTINUAR ");
                    int opc = int.Parse(Console.ReadLine());

                    if (opc == 0)
                        break;
                }

            } while (acertos < 8);
            tempo.Stop();
            Console.WriteLine("contagem de erros:{0} ", erros);
            Console.WriteLine("Tempo decorrido: " + tempo.Elapsed);
        }
    }
}























































































































































































































































































