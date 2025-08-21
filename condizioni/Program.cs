using System;

namespace Condizioni
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Scrivi qualcosa:");
            string s = Console.ReadLine();

            if (s == "primo")
            {
                Console.WriteLine("Hai scritto primo!");
            }
            else if (s == "secondo")
            {
                Console.WriteLine("Hai scritto secondo!");
            }
            else
            {
                Console.WriteLine($"Hai scritto {s}!");


                switch (s)
                {
                    case "primo":
                        Console.WriteLine("Hai scritto primo!");
                        break;
                    case "secondo":
                        Console.WriteLine("Hai scritto secondo!");
                        break;
                    default:
                        Console.WriteLine($"Hai scritto {s}!");
                        break;
                }
            }
        }
    }
}