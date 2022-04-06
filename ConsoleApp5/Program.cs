using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static string ShowColor()
        {
            
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            var colors = Console.ReadLine();
            switch (colors)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;
                case "cyan":
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;
                default:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Your color is yellow!");
                    break;
            }
            return colors;           

        }

        public static void Main(string[] args)
        {
            var favcolars = new string[3];
            for (int i = 0; i < favcolars.Length; i++)
            {
                favcolars[i] = ShowColor();
            }
            Console.WriteLine("Your favorite colors:");
            foreach (var favcolar in favcolars)
            {
                Console.WriteLine(favcolar);
            }
            
            Console.ReadKey();
        }
    }
}
