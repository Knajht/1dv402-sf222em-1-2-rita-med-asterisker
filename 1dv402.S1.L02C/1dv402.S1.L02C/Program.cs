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
            const byte maxValue = 79;

            do
            {
                byte maxCount = ReadOddByte(Strings.DiamondSize_Prompt, maxValue);
                RenderDiamond(maxCount);
            } while (IsContinuing() == true);
        }
        static byte ReadOddByte(string prompt = null, byte maxValue = 255)
        {
            int cols = 0;
            string input = null;
            bool startOver = true;

            do
            {
                Console.Write(prompt, maxValue);
                try
                {
                    input = Console.ReadLine();
                    cols = int.Parse(input);
                    if (cols < 1 || cols > maxValue)
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine(String.Format(Strings.OutOfRange_Error, cols, maxValue));
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
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(Strings.IncorrectInput_Error, input);
                    Console.ResetColor();
                }
            } while (startOver == true);

            return (byte)cols;
        }
        static void RenderDiamond(byte maxCount)
        {
            int asteriskCount = 1;
            
            for (int i = 0; i < maxCount; i++)
            {
//Skrev denna metod för att det kändes som det lättaste sättet. Eftersom det står i uppgiftsbeskrivningen att man ska använda "for"-satser finns en sådan nedanför.
                //if(i < (maxCount + 1) / 2)
                //{
                //    RenderRow(maxCount, asteriskCount);
                //}
                //else
                //{
                //    RenderRow(maxCount, (maxCount - (asteriskCount % maxCount)));
                //}
                //asteriskCount = asteriskCount + 2;
                //Console.WriteLine();

//Första For-loop-versionen. Känns klumpig men hittar tyvärr inget smartare sätt.
                for (int j = i; j == i && j < (maxCount + 1) / 2; j++)
                {
                    RenderRow(maxCount, asteriskCount);
                }
                for (int j = i; j == i && j < maxCount && j >= (maxCount + 1) / 2; j++)
                {
                    RenderRow(maxCount, (maxCount - (asteriskCount % maxCount)));
                }
                asteriskCount = asteriskCount + 2;
                Console.WriteLine();
            }
        }
        static void RenderRow(int maxCount, int asteriskCount)
        {
            for (int i = 0; i < (maxCount / 2) - (asteriskCount / 2); i++)
			{
                Console.Write(" ");
			}
            for (int i = 0; i < asteriskCount; i++)
            {
                Console.Write("*");
            }
        }
        static bool IsContinuing()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(Strings.Continue_Prompt);
            Console.ResetColor();
            return Console.ReadKey(true).Key != ConsoleKey.Escape;
        }
    }
}
