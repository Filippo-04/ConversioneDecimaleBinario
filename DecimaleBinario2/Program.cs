using System;

namespace DecimaleBinario2
{
    class Program
    {
        static void Main(string[] args)
        {
            int resto, numero, valorebase;
            string numeroconvertito = "";
            Console.WriteLine("inserisci la base in cui vuoi convertire:");
            valorebase = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("inserisci il numero da convertire:");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero > 0) ;
            {
                resto = numero % valorebase;
                if (resto == 15)
                {
                    numeroconvertito += "f";
                }
                else if(resto == 14)
                {
                    numeroconvertito += "e";
                }
                else if(resto == 13)
                {
                    numeroconvertito += "d";
                }
                else if(resto == 12)
                {
                    numeroconvertito += "c";
                }
                else if(resto == 11)
                {
                    numeroconvertito += "b";
                }
                else if(resto == 10)
                {
                    numeroconvertito += "a";
                }
                else
                {
                    numeroconvertito = Convert.ToString(resto) + numeroconvertito;
                }
                numero = numero / valorebase;
            }
            Console.WriteLine($"il numero binario é {numeroconvertito}");
            Console.ReadLine();
        }
    }
}
