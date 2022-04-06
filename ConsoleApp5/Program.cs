using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        //static string ShowColor()
        //{
        //    Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        //    var colors = Console.ReadLine();
        //    switch (colors)
        //    {
        //        case "red":
        //            Console.BackgroundColor = ConsoleColor.Red;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is red!");
        //            break;

        //        case "green":
        //            Console.BackgroundColor = ConsoleColor.Green;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is green!");
        //            break;
        //        case "cyan":
        //            Console.BackgroundColor = ConsoleColor.Cyan;
        //            Console.ForegroundColor = ConsoleColor.Black;

        //            Console.WriteLine("Your color is cyan!");
        //            break;
        //        default:
        //            Console.BackgroundColor = ConsoleColor.Yellow;
        //            Console.ForegroundColor = ConsoleColor.Red;

        //            Console.WriteLine("Your color is yellow!");
        //            break;
        //    }
        //    return colors;

        //}

        static int[] GetArrayFromConsole()
        {
            var result = new int[5];
            int t = 0;
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива номер {i + 1}");
                result[i] = Convert.ToInt32(Console.ReadLine());                              
            }
            for (int j = 0; j < result.Length; j++)
            {
                for (int i = j+1; i < result.Length; i++)
                    if(result[j] > result[i])
                {
                    t = result[j];
                    result[j] = result[i];
                    result[i] = t;
                }
            }
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.WriteLine(result[3]);


            return result;
        }

        public static void Main(string[] args)
        {
            //var favcolars = new string[3];
            //for (int i = 0; i < favcolars.Length; i++)
            //{
            //    favcolars[i] = ShowColor();
            //}
            //Console.WriteLine("Your favorite colors:");
            //foreach (var favcolar in favcolars)
            //{
            //    Console.WriteLine(favcolar);
            //}

            GetArrayFromConsole();

            Console.ReadKey();
        }
    }
}
