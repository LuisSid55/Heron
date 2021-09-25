using System;

namespace Heron
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, semi, lA, lB, lC;
            Console.WriteLine("\n---Heron---");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\nDigite as 3 medidas do triangulo");
            Console.ResetColor();
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nLado A: ");
            lA = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            Console.Write("Lado B: ");
            lB = Convert.ToDouble(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("Lado C: ");
            lC = Convert.ToDouble(Console.ReadLine());
            Console.ResetColor();

            semi = (lA + lB + lC) / 2;
            area = Math.Sqrt(semi * (semi - lA) * (semi - lB) * (semi - lC));

            Console.WriteLine("\n---Resultados---");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"\nSemiperímetro: {semi}");
            Console.ResetColor();
            Console.WriteLine($"Area: {area}\n");
        }
    }
}
