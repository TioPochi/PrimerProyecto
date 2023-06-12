using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[,]
        {
            { 13, 56, 53, 87, 12 },
            { 6,36, 65, 3, 14 },
            { 16, 72, 43, 54, 52 },
            { 36, 57, 48, 29, 76 },
            { 31, 26, 63, 34, 98 }
        };
        Console.WriteLine("Matriz:");
        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                Console.Write(matriz[fila, columna] + "\t");
            }
            Console.WriteLine();
        }
        int sumaEsquinas = matriz[0, 0] + matriz[0, 4] + matriz[4, 0] + matriz[4, 4];
        Console.WriteLine("La suma de los valores de las esquinas es de : " + sumaEsquinas);
    }
}