//Eliecer chavarro torres

using System;
namespace operadores_logicos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 0;
            string genero = "";
            int Dinero;
            string tarjeta = "";
            Console.WriteLine("por favor, ingrese la edad: ");
            Int32.TryParse(Console.ReadLine(), out edad);
            Console.WriteLine("por favor, ingresar genero: h/m)");
            genero = Console.ReadLine();

            if (edad > 18 && genero == "M")
            {
                Console.WriteLine(" Bienvenidos");
            }
            else
            {
            Console.WriteLine("lo sentimos no cumples con los requisitos");
            }
            {
                Console.WriteLine("costo del producto: $25000");
                Console.WriteLine("por favor, ingresas el monton que desea pagar: ");
                Int32.TryParse(Console.ReadLine(), out Dinero);
                Console.WriteLine("cuantas con alguna trajeta: (s/n)");
                tarjeta = Console.ReadLine();

                if (tarjeta = "S") 
                Console.ReadLine();
            }
        }
    }
}
