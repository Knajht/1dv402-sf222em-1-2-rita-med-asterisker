using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S1.L02A
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 0; j < 25; j++)
            {
                switch (j % 3)
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

                if(j % 2 == 1)
                {
                Console.Write(" ");
                }

                for (int i = 0; i < 39; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
