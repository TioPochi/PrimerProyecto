using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 34, 7 , 83, 43, 98 },
            { 16, 37, 58, 49, 210 },
            { 13,62, 73, 16, 18 },
            { 76, 47, 38, 29, 60 },
            { 21, 62, 43, 45, 25 }
        };
        int sumaDiagonal1 = 0;
        for (int i = 0; i < 5; i++)
        {
            sumaDiagonal1 += matriz[i, i];
        }
        int sumaDiagonal2 = 0;
        for (int i = 0; i < 5; i++)
        {
            sumaDiagonal2 += matriz[i, 4 - i];
        }
        Console.WriteLine("La suma de la diagonal principal es : " + sumaDiagonal1);
        Console.WriteLine("La suma diagonal secundaria es : " + sumaDiagonal2);

        Console.ReadLine();
    }
}