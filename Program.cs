using FacadePatternBsp.GenerateLogo;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class Program
{
    private static void Main(string[] args)
    {
        ColorChanger.SetBackground();
        ColorChanger.SetForegroundMain();
        Writer.writeD();
        Writer.writeE();
        Writer.writeV();
        ColorChanger.SetForegroundSecond();
        Writer.writeW();
        Writer.writea();
        Writer.writer();
        Writer.writee();
        Console.SetCursorPosition(0, Console.WindowHeight - 1);

        Console.ReadKey();
    }
}