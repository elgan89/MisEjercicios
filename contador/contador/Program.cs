using System;

class Program
{
    static void Main(string[] args)
    {
        string NombreProducto = "";
        int NumeroProducto = 1;
        Console.Write("por favor, ingrese Nombre del Producto: ");
        NombreProducto = Console.ReadLine();

        //Productos para supermercado
        while (NombreProducto != "FIN")
        {
            Console.WriteLine("Producto Numero " + NumeroProducto);
            Console.WriteLine("Nombre del Producto. " + NombreProducto + ".");
            Console.WriteLine("");
            Console.WriteLine("por favor, ingresa Nombre del Producto: ");
            NombreProducto = Console.ReadLine();
            NumeroProducto += 1;
        }
        {
            Console.WriteLine("Fin del programa");

        }   
    }
}
