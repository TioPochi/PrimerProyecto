using System;
class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        Random rnd = new Random();
        for (int fila = 0; fila < 5; fila++)
        {
            for (int columna = 0; columna < 5; columna++)
            {
                matriz[fila, columna] = rnd.Next(1, 100);
            }
        }
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