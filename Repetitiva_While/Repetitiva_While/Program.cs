using System;

class Program
{
    static void Main(string[] args)
    {
        string NombreUsuario = "";
        Console.Write("por favor, ingresar tu nombre: ");
        NombreUsuario = Console.ReadLine();

        //Estructura repetitiva para preguntar por el nombre
        while (NombreUsuario != "FIN")
        {
        Console.WriteLine("Bienvenido, sr(a) " + NombreUsuario + ".");
        Console.WriteLine("");
        Console.WriteLine("por favor, ingresa tu nombre: ");
        NombreUsuario = Console.ReadLine();
        }
        {
            Console.WriteLine("Fin del programa");
                
        }
    }
}