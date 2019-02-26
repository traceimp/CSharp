using System;

namespace Calculator
{
    class Program
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            int result = Program.Plus(3, 4);
            Console.WriteLine(result);

            result = Program.Minus(5, 2);
            Console.WriteLine(result);
        }
    }
}
