using System;

namespace ConversioneDecimaleBinario
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto;
            Console.WriteLine("inserisci un numero da compilare:");
            num = int.Parse(Console.ReadLine());
            string binario = "";
            while (num > 0)
            {
                resto = num % 2;
                num = num / 2;
                binario = Convert.ToString(resto) + binario;
            }
            Console.WriteLine($"Il numero in binario è {binario}");
            Console.ReadLine();
        }
    }
}
