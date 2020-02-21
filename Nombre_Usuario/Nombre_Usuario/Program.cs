using System;

    class Program
    {
        static void Main(string[] args)
        {
            string NombreUsurio = "";

            Console.WriteLine("Por favor, ingresar tu nombre: " );
            NombreUsurio = Console.ReadLine();

            Console.WriteLine("Bienvenido(a), " + NombreUsurio + ".");
            Console.ReadLine();

        }
    }

