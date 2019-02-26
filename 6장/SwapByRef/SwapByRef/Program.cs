using System;
using static System.Console;

namespace SwapByRef
{
    class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            WriteLine($"x: {x}, y: {y}");

            Swap(ref x, ref y);

            WriteLine($"x: {x}, y: {y}");

        }
    }
}
