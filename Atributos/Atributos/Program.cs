using System;

    class Program
    {
        static void Main(string[] args)
        {
            Aprendiz apSena = new Aprendiz();
            apSena.Nombres = "Eliecer";
            apSena.Apellidos = "Chavarro Torres";
            apSena.Direccion = "Carrera 5 N. 8-45";
            Saludo(apSena);
        }
        private static void Saludo(Aprendiz apSena)
        {
            Console.WriteLine("Bienvendo, sr(a) " + apSena.Nombres);
            Console.WriteLine("Su Direccion es " + apSena.Direccion);
            Console.ReadLine();
        }
    }

