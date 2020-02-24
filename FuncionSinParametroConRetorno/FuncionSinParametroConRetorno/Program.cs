using System;

    class Program
    {
        static decimal PrecioProducto = 0;
        static decimal PrecioProductoConIva = 0;
        static int CategoriaProducto = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("por favor, ingresar el costo del producto");
            decimal.TryParse(Console.ReadLine(), out PrecioProducto);
            Console.WriteLine("por favor, ingresar la categoria del porducto");
            Int32.TryParse(Console.ReadLine(), out CategoriaProducto);
            if (CategoriaProducto == 1)
                {
                PrecioProductoConIva = Porcentaje5();
                Console.WriteLine("El Precio del Producto " + "con Iva es: {0:c}", PrecioProductoConIva);
                }
            if (CategoriaProducto == 2)
            {
                PrecioProductoConIva = Porcentaje3();
                Console.WriteLine("El Precio del Producto " + "con Iva es: {0:c}", PrecioProductoConIva);
            }
            if (CategoriaProducto == 3)
            {
                PrecioProductoConIva = Porcentaje9();
                Console.WriteLine("El Precio del Producto " + "con Iva es: {0:c}", PrecioProductoConIva);
            }
                Console.ReadLine();
                }
                public static decimal Porcentaje5()
                {
                decimal aux = 0.05M;
                PrecioProducto += PrecioProducto * aux;
                return PrecioProducto;
                }
                public static decimal Porcentaje3()
                {
                    decimal aux = 0.10M;
                    PrecioProducto += PrecioProducto * aux;
                    return PrecioProducto;
                }
                public static decimal Porcentaje9()
                {
                    decimal aux = 0.19M;
                    PrecioProducto += PrecioProducto * aux;
                    return PrecioProducto;
                }
            
        
    }

