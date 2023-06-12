using System;

class Program
{
    static void Main()
    {
        byte opcion = 0;
        string[] proveedores = { "OCTAVIO", "CALEB", "ANTONI", "DIEGO", "CARLOS" };
        string[] ciudades = { "SAN JOSE", "HEREDIA ", "PUNTARENAS", "CARTAGO", "LIMON" };
        int[] numeroDeArticulos = { 15, 30, 35, 40, 45 };
        while (opcion != 5)
        {
            Console.WriteLine("Transacciones: \n1. Mostrar nombre de ciudad y número de artículos de un proveedor.\n2. Actualizar el nombre de la ciudad de un proveedor.  \n3. Actualizar el número de artículos de un proveedor. \n4. Incorporar un nuevo proveedor. \n5. Salir del programa. \n ");

            Console.WriteLine("Ingrese la opción deseada (1, 2, 3, 4 o 5):");
            opcion = Convert.ToByte(Console.ReadLine());
            Console.WriteLine();
     



            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el nombre del proveedor:");
                    string nombreProveedorA = Console.ReadLine();
                    int indiceProveedorA = Array.IndexOf(proveedores, nombreProveedorA);
                    if (indiceProveedorA != -1)
                    {
                        Console.WriteLine("Ciudad: " + ciudades[indiceProveedorA]);
                        Console.WriteLine("Número de artículos: " + numeroDeArticulos[indiceProveedorA]);
                    }
                    else
                    {
                        Console.WriteLine("Proveedor no encontrado.");
                    }
                    break;

                case 2:
                    Console.WriteLine("Ingrese el nombre del proveedor:");
                    string nombreProveedorB = Console.ReadLine();
                    int indiceProveedorB = Array.IndexOf(proveedores, nombreProveedorB);
                    if (indiceProveedorB != -1)
                    {
                        Console.WriteLine("Ingrese el nuevo nombre de la ciudad:");
                        string nombreciudada = Console.ReadLine();
                        ciudades[indiceProveedorB] = nombreciudada;
                        Console.WriteLine("Nombre de la ciudad actualizado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Proveedor no encontrado.");
                    }
                    break;

                case 3:
                    Console.WriteLine("Ingrese el nombre del proveedor:");
                    string nombreProveedorC = Console.ReadLine();
                    int indiceProveedorC = Array.IndexOf(proveedores, nombreProveedorC);
                    if (indiceProveedorC != -1)
                    {
                        Console.WriteLine("Ingrese la cantidad en la que aumenta o disminuye el número de artículos:");
                        int cambioArticulos = int.Parse(Console.ReadLine());
                        numeroDeArticulos[indiceProveedorC] += cambioArticulos;
                        Console.WriteLine("Número de artículos actualizado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Proveedor no encontrado.");
                    }
                    break;

                case 4:
                    Console.WriteLine("Ingrese el nombre del nuevo proveedor:");
                    string nuevoProveedor = Console.ReadLine();
                    Console.WriteLine("Ingrese el nombre de la ciudad del nuevo proveedor:");
                    string nuevaCiudad = Console.ReadLine();
                    Console.WriteLine("Ingrese el número de artículos que provee el nuevo proveedor:");
                    int nuevosArticulos = int.Parse(Console.ReadLine());

                    Array.Resize(ref proveedores, proveedores.Length + 1);
                    Array.Resize(ref ciudades, ciudades.Length + 1);
                    Array.Resize(ref numeroDeArticulos, numeroDeArticulos.Length + 1);

                    proveedores[proveedores.Length - 1] = nuevoProveedor;
                    ciudades[ciudades.Length - 1] = nuevaCiudad;
                    numeroDeArticulos[numeroDeArticulos.Length - 1] = nuevosArticulos;

                    Console.WriteLine("Proveedor agregado con éxito.");
                    break;

                case 5:
                    Console.WriteLine("El programa ha finalizado con éxito");
                    break;

               
            }
        }
    }
}
