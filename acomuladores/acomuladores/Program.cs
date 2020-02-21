using System;

class Program
    {
    static void Main(string[] args)
        {
        string respuesta = "";
        int numeroProducto = 0;
        int cantidadproducto = 0;
        int compraProducto = 0;
        int precioproducto = 0;
        Console.WriteLine("Desea agregar productos al carrito? s/w: ");
        respuesta = Console.ReadLine();

        while (respuesta =="s")
        {
            numeroProducto++;
            compraProducto += compraProducto;
            Console.WriteLine("productor N." + numeroProducto + ": ");
            numeroProducto = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresar la cantidad de productos " );
             cantidadproducto= Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Ingrese el precio del producto ");
             precioproducto = Convert.ToInt32(Console.ReadLine());

             precioproducto = numeroProducto * cantidadproducto;
            Console.WriteLine("Desea agregar mas productos al carrito? S/W: ");
            respuesta = Console.ReadLine();
        }
        Console.WriteLine("valor total de la factura: " + compraProducto);
        Console.ReadLine();
        }
    }   