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
            do
            {
                byte cols = ReadOddByte();
                RenderTriangle(cols);

                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\nTryck tangent för ny beräkning - Esc avslutar");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        static byte ReadOddByte()
        {
            byte cols = 0;
            string input = null;
            bool startOver = true;

            do
            {
                Console.Write("Ange det udda antalet asterisker (max 79) i triangelns bas: ");
                try
                {
                    input = Console.ReadLine();
                    cols = Byte.Parse(input);
                    if (cols % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Det angivna värdet är inte udda!");
                        Console.ResetColor();
                    }
                    else if (cols < 1 || cols > 79)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(String.Format("Det angivna värdet '{0}' ligger inte mellan 1-79!", cols));
                        Console.ResetColor();
                    }
                    else
                    {
                        startOver = false;
                    }

                }
                catch (ArgumentOutOfRangeException outOfRange)
                {
                    
                    Console.WriteLine(outOfRange.Message);
                    
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("'{0}' kan inte tolkas som en korrekt inmatning!", input);
                    Console.ResetColor();
                }
            } while (startOver == true);

            return cols;
        }
        static void RenderTriangle(byte cols)
        {
            int iterator = 1;

            for (int k = (cols / 2) + 1; k > 0; k--)
            {
                for (int j = iterator; j < cols; j = j + 2)
                {
                    Console.Write(" ");
                }
                for (int i = 1; i <= iterator; i++)
                {
                    Console.Write("*");
                }
                iterator = iterator + 2;
                Console.WriteLine();
            }
            Console.WriteLine("KLAAR!");
        }
//Denna forloop producerar i minskande ordning, används till steg C?
                ////int iteratorAsterisk = 0;
                ////for (int j = iteratorAsterisk; j <= cols; j = j + 2)
                ////{
                    
                ////}
                ////iteratorAsterisk = iteratorAsterisk + 2;
                ////Console.WriteLine();
    }
}
