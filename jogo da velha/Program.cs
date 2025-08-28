﻿string[,] matriz = new string[3, 3];
string players = "X";
List<string> indexNumero = new List<string> {};
int rounds = 1;
int index = 1;

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        matriz[i, j] = index.ToString();
        indexNumero.Add(index.ToString());
        index++;
    }
}

while (rounds <= 9)
{
    Console.Clear();
    Console.WriteLine("Jogo da Velha\n");

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        Console.Write("   ");
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            string val = matriz[i, j];
            if (val == "X")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (val == "O")
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($" {val} ");
            Console.ResetColor();

            if (j < 2) Console.Write("|");
        }
        Console.WriteLine();
        if (i < 2)
            Console.WriteLine("-----+--+------");
    }

    Console.WriteLine($"\nRodada {rounds} - Jogador: {players}");
    Console.Write("Escolha uma posição (1-9): ");
    string jogada = Console.ReadLine();

    while (!indexNumero.Contains(jogada))
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("Jogada inválida! Tente novamente: ");
        Console.ResetColor();
        jogada = Console.ReadLine();
    }

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            if (jogada == matriz[i, j] && indexNumero.Contains(jogada))
            {
                matriz[i, j] = players;
                indexNumero.Remove(jogada);
            }
        }
    }

    if ((matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2]) ||
        (matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0]) ||

        (matriz[0, 0] == matriz[0, 1] && matriz[0, 1] == matriz[0, 2]) ||
        (matriz[1, 0] == matriz[1, 1] && matriz[1, 1] == matriz[1, 2]) ||
        (matriz[2, 0] == matriz[2, 1] && matriz[2, 1] == matriz[2, 2]) ||

        (matriz[0, 0] == matriz[1, 0] && matriz[1, 0] == matriz[2, 0]) ||
        (matriz[0, 1] == matriz[1, 1] && matriz[1, 1] == matriz[2, 1]) ||
        (matriz[0, 2] == matriz[1, 2] && matriz[1, 2] == matriz[2, 2]))
    {
        Console.Clear();
        Console.WriteLine("Jogo da velha\n");

        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            Console.Write("   ");
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                string val = matriz[i, j];
                if (val == "X")
                    Console.ForegroundColor = ConsoleColor.Red;
                else if (val == "O")
                    Console.ForegroundColor = ConsoleColor.Blue;
                else
                    Console.ForegroundColor = ConsoleColor.Gray;

                Console.Write($" {val} ");
                Console.ResetColor();

                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2)
                Console.WriteLine(" -----+--+------");
        }

        Console.WriteLine($"\n Jogador {players} venceu!");
        break;
    }

    players = (players == "X") ? "O" : "X";
    rounds++;
}

if (rounds > 9)
{
    Console.Clear();
    Console.WriteLine("Jogo da Velha\n");

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        Console.Write("   ");
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            string val = matriz[i, j];
            if (val == "X")
                Console.ForegroundColor = ConsoleColor.Red;
            else if (val == "O")
                Console.ForegroundColor = ConsoleColor.Blue;
            else
                Console.ForegroundColor = ConsoleColor.Gray;

            Console.Write($" {val} ");
            Console.ResetColor();

            if (j < 2) Console.Write("|");
        }
        Console.WriteLine();
        if (i < 2)
            Console.WriteLine("-----+--+------");
    }

    Console.WriteLine("Empate!");
}