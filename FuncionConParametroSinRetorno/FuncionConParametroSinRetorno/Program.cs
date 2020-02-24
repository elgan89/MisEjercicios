using System;
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre = "";
            string Apellido = "";
            Console.Write("Por favor, ingresar su Nombre: ");
            Nombre = Console.ReadLine();
            Console.Write("Por favor, ingresar su Apellido: ");
            Apellido = Console.ReadLine();

            MostrarMensaje(Nombre, Apellido);
        }
        public static void MostrarMensaje(String NombreUsuario, string ApellidoUsuario)
        {
            Console.WriteLine("Bienvenido, sr(a). " + NombreUsuario + " " + ApellidoUsuario);
            Console.ReadLine();

        }
    }
    