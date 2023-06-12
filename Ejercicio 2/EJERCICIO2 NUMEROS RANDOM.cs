using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        int[,] matriz = new int[5, 5];

        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                matriz[fila, columna] = random.Next(1, 10);
            }
        }
        int sumaDiagonalPrincipal = 0;
        for (int i = 0; i < 5; i++)
        {
            sumaDiagonalPrincipal += matriz[i, i];
        }

        int sumaDiagonalSecundaria = 0;
        for (int i = 0; i < 5; i++)
        {
            sumaDiagonalSecundaria += matriz[i, 4 - i];
        }

        Console.WriteLine("Suma diagonal principal: " + sumaDiagonalPrincipal);
        Console.WriteLine("Suma diagonal secundaria: " + sumaDiagonalSecundaria);

        Console.ReadLine();
    }
}