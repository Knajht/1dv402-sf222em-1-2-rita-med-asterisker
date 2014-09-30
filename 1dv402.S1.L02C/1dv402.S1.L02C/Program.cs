using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strings = _1dv402.S1.L02C.Properties.Strings;

namespace _1dv402.S1.L02A
{
    class Program
    {
        static void Main(string[] args)
        {
            const byte maxValue = 41;

            do
            {
                byte cols = ReadOddByte(Strings.DiamondSize_Prompt, maxValue);
                RenderDiamond(cols);


            } while (IsContinuing() == true);
        }
        static byte ReadOddByte(string prompt = null, byte maxValue = 255)
        {
            byte cols = 0;
            string input = null;
            bool startOver = true;

            do
            {
                Console.Write(prompt, maxValue);
                try
                {
                    input = Console.ReadLine();
                    cols = Byte.Parse(input);
                    if (cols < 1 || cols > 79)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(String.Format(Strings.OutOfRange_Error, cols));
                        Console.ResetColor();
                    }
                    else if (cols % 2 == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(Strings.NotOdd_Error);
                        Console.ResetColor();
                    }
                    else
                    {
                        startOver = false;
                    }

                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(Strings.IncorrectInput_Error, input);
                    Console.ResetColor();
                }
            } while (startOver == true);

            return cols;
        }
        static void RenderDiamond(byte cols)
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
        }
        static bool IsContinuing()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Strings.Continue_Prompt);
            Console.ResetColor();
            return Console.ReadKey(true).Key != ConsoleKey.Escape;
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
