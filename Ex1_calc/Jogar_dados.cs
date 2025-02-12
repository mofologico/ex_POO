class Jogar_dados
{
    public static void Executar()
    {
        int JogarDado()
        {
            return new Random().Next(1, 7);
        }
        Console.WriteLine("\nNome do primeiro jogador");
        string nome_jogador1 = Console.ReadLine();

        Console.WriteLine("\nNome do segundo jogador");
        string nome_jogador2 = Console.ReadLine();

        int pontuacao_jogador1 = 0;
        int pontuacao_jogador2 = 0;

        for (int rodada = 1; rodada <= 3; rodada++)
        {
            Console.ReadKey();

            int dado_da_rodada_jogador1 = JogarDado();
            int dado_da_rodada_jogador2 = JogarDado();

            if (dado_da_rodada_jogador1 > dado_da_rodada_jogador2)
            {
                Console.WriteLine("\n{0} tirou o número {1} e {2} tirou o número {3} na {4} rodada, {5} ganhou um ponto.", nome_jogador1, dado_da_rodada_jogador1, nome_jogador2, dado_da_rodada_jogador2, rodada, nome_jogador1);
                pontuacao_jogador1 += 1;
            }
            else if (dado_da_rodada_jogador2 > dado_da_rodada_jogador1)
            {
                Console.WriteLine("\n{0} tirou o número {1} e {2} tirou o número {3} na {4} rodada, {5} ganhou um ponto.", nome_jogador1, dado_da_rodada_jogador1, nome_jogador2, dado_da_rodada_jogador2, rodada, nome_jogador2);
                pontuacao_jogador2 += 1;
            }
            else
            {
                Console.WriteLine("\n{0} tirou o número {1} e {2} tirou o número {3} na {4} rodada, empate.", nome_jogador1, dado_da_rodada_jogador1, nome_jogador2, dado_da_rodada_jogador2, rodada);
            }
        }
        if (pontuacao_jogador1 > pontuacao_jogador2)
        {
            Console.WriteLine("{0} Ganhou o jogo com {1} pontos.", nome_jogador1, pontuacao_jogador1);
        }
        else if (pontuacao_jogador2 > pontuacao_jogador1)
        {
            Console.WriteLine("{0} Ganhou o jogo com {1} pontos.", nome_jogador2, pontuacao_jogador2);
        }
        else
        {
            Console.WriteLine("O jogo terminou em empate!");
        }

        Console.WriteLine(" ");
    }
}