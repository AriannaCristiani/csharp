using System;

namespace Asterischi
{
    class Program
    {
        static void Main(string[] args)
        {
            int righe;

            while (true)
            {
                Console.Write("indica un numero ('no' per uscire): ");
                string s = Console.ReadLine();

                if (s.ToLower() == "no")
                {
                    Console.WriteLine("Arrivederci!");
                    break;
                }

                righe = Convert.ToInt32(s);

                for (int r = 0; r <= righe; r++)
                {
                    for (int ast = 1; ast <= r; ast++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}