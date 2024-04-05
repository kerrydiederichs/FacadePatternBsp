using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternBsp.GenerateLogo
{

    internal static class ColorChanger
    {
        public static void SetBackground()
        {
            Console.BackgroundColor = ConsoleColor.White;
            var test = Console.WindowWidth;
            var test2 = Console.WindowHeight;
            string line = "";
            for (int i = 0; i < test; i++)
            {
                line += " ";
            }
            for (int i = 1; i < test2; i++)
            {
                Console.WriteLine(line);
            }
        }

        public static void SetForegroundMain() 
        { 
            Console.ForegroundColor = ConsoleColor.DarkBlue;
        }
        public static void SetForegroundSecond()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
        }


    }
}
