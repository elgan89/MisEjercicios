//Eliecer chavarro torres

using System;

class Program
{
    static void Main(string[] args)
    {
        int NumeroNotas = 0;
        Console.WriteLine("===NOTAS===");
        Console.WriteLine("Ingresar el numero de Notas: ");
        Int32.TryParse(Console.ReadLine(), out NumeroNotas);
        string Resultado = CalcularNotas(NumeroNotas);
    }
        
    public static string CalcularNotas(int NumeroNotas)
    {
        decimal Notas = 0;
        decimal SumaNotas = 0;
        for (int i = 1; i <= NumeroNotas; i++)
        {
            Console.Write("Ingresar la  nota N. " + i);
            decimal.TryParse(Console.ReadLine(), out Notas);
            SumaNotas += Notas / NumeroNotas;
        }
        Console.WriteLine("El promedio es igual  a: {0:f2}", SumaNotas);

            if(SumaNotas>6)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
                Console.ReadLine();
        return "";
    }
        
}

