using System;

    class Program
    {
        static void Main(string[] args)
        {
            Calculadora();
        }
        public static void Calculadora()
        {
            int Operacion = 0;
            Console.WriteLine("Ingresar la operacion: ");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Int32.TryParse(Console.ReadLine(), out Operacion);
            switch (Operacion)
                {
                case 1:
                     Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    FinPrograma();
                    break;
                }
            FinPrograma();
        }
        public static void Suma()
        {
            int Resultado = 0;
            int Num1 = 0;
            int Num2 = 0;
            Console.WriteLine("Ingresar el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out Num1);
           
            Console.WriteLine("Ingresar el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out Num2);
            Resultado = Num1 + Num2;
            Console.WriteLine("El resultado es: " + Resultado);
            Console.ReadLine();
        }
                
        public static void Resta()
        {
            int Resultado = 0;
            int Num1 = 0;
            int Num2 = 0;
            Console.WriteLine("Ingresar el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out Num1);
           
            Console.WriteLine("Ingresar el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out Num2);
            Resultado = Num1 - Num2;
            Console.WriteLine("El resultado es: " + Resultado);
            Console.ReadLine();
        }
                
        public static void Multiplicacion()
        {
            int Resultado = 0;
            int Num1 = 0;
            int Num2 = 0;
            Console.WriteLine("Ingresar el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out Num1);
           
            Console.WriteLine("Ingresar el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out Num2);
            Resultado = Num1 * Num2;
            Console.WriteLine("El resultado es: " + Resultado);
            Console.ReadLine();
        }
                
        public static void Division()
        {
            int Resultado = 0;
            int Num1 = 0;
            int Num2 = 0;
            Console.WriteLine("Ingresar el numero 1: ");
            Int32.TryParse(Console.ReadLine(), out Num1);
           
            Console.WriteLine("Ingresar el numero 2: ");
            Int32.TryParse(Console.ReadLine(), out Num2);
            Resultado = Num1 / Num2;
            Console.WriteLine("El resultado es: " + Resultado);
            Console.ReadLine();
        }
                
        public static void FinPrograma()
        {
            string Respuesta = "";
          
            Console.WriteLine("Desea hacer otra operacion:  (S/N)");
            Respuesta = Console.ReadLine();
            if(Respuesta == "S" )
                {
                    Calculadora();
                }
        }
    }

