using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternBsp.GenerateLogo
{
    internal static class Writer
    {
        static int height = Console.WindowHeight / 2 - 3;
        static int startPositionD = Console.BufferWidth / 2 - 36 - 2;
        static int startPositionE = Console.BufferWidth / 2 - 24 - 2;
        static int startPositionV = Console.BufferWidth / 2 - 12 - 2;
        static int startPositionW = Console.BufferWidth / 2 -2;
        static int startPositiona = Console.BufferWidth / 2 +10 ;
        static int startPositionr = Console.BufferWidth / 2 + 10 + 10  ;
        static int startPositione = Console.BufferWidth / 2 + 10 + 10 +10 ;



        public static void writeV()
        {
            Console.SetCursorPosition(startPositionV, height);
            for (int i = 0; i < 3; i++)
            {
                Console.SetCursorPosition(startPositionV, height + i);
                Console.Write("██");
                Console.SetCursorPosition(startPositionV + 8, height + i);
                Console.Write("██");
            }
            var position = Console.GetCursorPosition();
            Console.SetCursorPosition(startPositionV + 2, position.Top + 1);
            Console.Write("██");
            position = Console.GetCursorPosition();
            Console.SetCursorPosition(startPositionV + 2 + 4, position.Top);
            Console.Write("██");
            position = Console.GetCursorPosition();
            Console.SetCursorPosition(startPositionV + 2 + 2, position.Top + 1);
            Console.Write("██");
        }

        public static void writeE()
        {
            Console.SetCursorPosition(startPositionE, height);
            Console.Write("██████████");
            Console.SetCursorPosition(startPositionE, height + 1);
            Console.Write("██");
            Console.SetCursorPosition(startPositionE, height + 2);
            Console.Write("██████████");
            Console.SetCursorPosition(startPositionE, height + 3);
            Console.Write("██");
           
            Console.SetCursorPosition(startPositionE, height + 4);
            Console.Write("██████████");
        }

        public static void writeD()
        {
            Console.SetCursorPosition(startPositionD, height);
            Console.Write("████████");
            for (int i = 0; i < 3; i++)
            {
                var position = Console.GetCursorPosition();
                Console.SetCursorPosition(startPositionD, position.Top + 1);
                Console.Write("██");
                position = Console.GetCursorPosition();
                Console.SetCursorPosition(startPositionD + 8, position.Top);
                Console.Write("██");
            }
            var position1 = Console.GetCursorPosition();
            Console.SetCursorPosition(startPositionD, position1.Top + 1);
            Console.Write("████████");
        }

        public static void writeW()
        {
            Console.SetCursorPosition(startPositionW, height+0);
            Console.Write("██      ██");
            Console.SetCursorPosition(startPositionW, height+1);
            Console.Write("██      ██");
            Console.SetCursorPosition(startPositionW, height + 2);
            Console.Write("██      ██");
            Console.SetCursorPosition(startPositionW, height + 3);
            Console.Write("██  ██  ██");
            Console.SetCursorPosition(startPositionW, height + 4);
            Console.Write("  ██  ██");
        }

        public static void writea()
        {
            Console.SetCursorPosition(startPositiona, height+0);
            Console.Write("  ████    ");
            Console.SetCursorPosition(startPositiona, height+1);
            Console.Write("      ██  ");
            Console.SetCursorPosition(startPositiona, height +2);
            Console.Write("  ██████  ");
            Console.SetCursorPosition(startPositiona, height + 3);
            Console.Write("██    ██  ");
            Console.SetCursorPosition(startPositiona, height + 4);
            Console.Write("  ██████");
        }
        public static void writer()
        {
            Console.SetCursorPosition(startPositionr, height + 0);
            Console.Write("██  ████  ");
            Console.SetCursorPosition(startPositionr, height + 1);
            Console.Write("████");
            Console.SetCursorPosition(startPositionr, height + 2);
            Console.Write("██");
            Console.SetCursorPosition(startPositionr, height + 3);
            Console.Write("██");
            Console.SetCursorPosition(startPositionr, height + 4);
            Console.Write("██");
        }

        public static void writee()
        {
            Console.SetCursorPosition(startPositione, height + 0);
            Console.Write("  ██████  ");
            Console.SetCursorPosition(startPositione, height + 1);
            Console.Write("██      ██");
            Console.SetCursorPosition(startPositione, height + 2);
            Console.Write("██████████");
            Console.SetCursorPosition(startPositione, height + 3);
            Console.Write("██");
            Console.SetCursorPosition(startPositione, height + 4);
            Console.Write("  ████████");
        }
    }
}
