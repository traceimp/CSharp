using System;

namespace UsingOut
{
    class Program
    {
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            // int c;   // out 키워드는 초기화가 필요없음!
            // int d;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
}
