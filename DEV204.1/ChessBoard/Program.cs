using System;
using System.Linq;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            // Used a nested loop
            // Used a decision structure to flip row output
            // Output is correct per above image
            bool done = false;
            while (!done)
            {
                for (var i = 0; i < 8; i++)
                {
                    Console.WriteLine(i % 2 == 0
                        ? string.Concat(Enumerable.Repeat("XO", 4))
                        : string.Concat(Enumerable.Repeat("OX", 4)));
                }

                done = true;
            }
        }
    }
}