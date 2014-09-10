using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2_ritaMedAsterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int colum = 0; colum < 25; colum++)
            {
                int switchColor = colum % 3; // Modulus kör först 0 % 3 = 0, 1 % 3 = 1, 2 % 3 = 2. Eftersom heltalet är minder än vad jag kör modulus mot så blir det alltid det talet jag kör modulus mot.
                switch (switchColor)
                { 
                    case 0:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
                if (colum % 2 == 0)
                {
                    Console.Write(" ");
                }

                for (int row = 0; row < 39; row++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }
        }
    }
}
