using System;

namespace ArrayQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[5, 5];

            int counter = 0;

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    ++counter;
                    arr[r, c] = (c == 0) ? 0 : counter;
                }
            }

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write($"{arr[r, c]} ");
                }
                Console.Write("\n");
            }


        }
    }
}