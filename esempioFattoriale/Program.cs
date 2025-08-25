using System;

namespace esempioFattoriale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci un numero: ");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Il fattoriale di {n} è {Fattoriale(n)}");

            static int Fattoriale(int n)
            {
                if (n == 0)
                    return 1;
                else
                    return n * Fattoriale(n - 1);
            }
        }
    }
}