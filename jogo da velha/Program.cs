using System;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] tabuleiro = new string[3, 3];

            tabuleiro[0, 0] = "X";
            tabuleiro[0, 1] = "X";
            tabuleiro[0, 2] = "X";

            tabuleiro[1, 0] = "O";
            tabuleiro[1, 1] = "X";
            tabuleiro[1, 2] = "O";

            tabuleiro[2, 0] = "O";
            tabuleiro[2, 1] = "O";
            tabuleiro[2, 2] = "X";

            ImprimirTabuleiro(tabuleiro);

            string vencedor = VerificarVencedor(tabuleiro);
            if (vencedor != null)
            {
                Console.WriteLine($"O jogador '{vencedor}' venceu!");
            }
            else
            {
                Console.WriteLine("Nenhum vencedor.");
            }
        }

        static void ImprimirTabuleiro(string[,] tab)
        {
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(tab[i, j] + " | ");
                }
                Console.WriteLine();
            }
        }

        static string VerificarVencedor(string[,] tab)
        {
            for (int i = 0; i < 3; i++)
            {
                if (tab[i, 0] != null && tab[i, 0] == tab[i, 1] && tab[i, 1] == tab[i, 2])
                    return tab[i, 0];
            }

            for (int j = 0; j < 3; j++)
            {
                if (tab[0, j] != null && tab[0, j] == tab[1, j] && tab[1, j] == tab[2, j])
                    return tab[0, j];
            }

            if (tab[0, 0] != null && tab[0, 0] == tab[1, 1] && tab[1, 1] == tab[2, 2])
                return tab[0, 0];

            if (tab[0, 2] != null && tab[0, 2] == tab[1, 1] && tab[1, 1] == tab[2, 0])
                return tab[0, 2];

            return null;
        }
    }
}
