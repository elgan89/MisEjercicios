using System;

class Program
{
    static void Main(string[] args)
    {
        string[] operacion = new string [5];
        operacion[0] = "Suma";
        operacion[1] = "Resta";
        operacion[2] = "Multiplicación";
        operacion[3] = "División";
        operacion[4] = "Error";
        int opusuario = 0;
        int resultado = 0;
        int numero1 = 0;
        int numero2 = 0;
        string respuestausuario = "";

        Console.WriteLine("Desea realizar, algun tipo de operacion (y/n)");
        respuestausuario = Console.ReadLine();
        while (respuestausuario == "y")
        {
            Console.WriteLine("ingresa el primer entero: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingresa el segundo entero: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            for (int op = 0; op <= 3; op++)
            {
                Console.WriteLine((op + 1) + "." + operacion[op]);
            }
            Console.WriteLine("seleccione una operacion: ");
            opusuario = Convert.ToInt32(Console.ReadLine());
            switch (opusuario)
            {
                case 1:
                   Console.WriteLine("usted seleciono una Suma");
                   resultado = numero1 + numero2;
                    break;
                case 2:
                    Console.WriteLine("usted seleciono una Resta");
                    resultado = numero1 - numero2;
                    break;
                case 3:
                    Console.WriteLine("usted seleciono una Multiplicasion");
                    resultado = numero1 * numero2;
                    break;
                case 4:
                    Console.WriteLine("usted seleciono una División");
                    resultado = numero1 / numero2;
                    break;
                case 5:
                    Console.WriteLine("su operacion no fue valida");
                    resultado = numero1 + numero2;
                    break;
            } 
            Console.WriteLine("el resultado es la operacion es" + resultado);
            Console.WriteLine("desea usted vovler hacer una operacion y/n");
            respuestausuario = Console.ReadLine();
                
        }
    }
}

