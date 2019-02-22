using System;

namespace BitwiseOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            Console.WriteLine($"{a} & {b} : {a & b}");  // 둘 다 1이면 1
            Console.WriteLine($"{a} | {b} : {a | b}");  // 둘 중 하나라도 1이면 1
            Console.WriteLine($"{a} ^ {b} : {a ^ b}");  // 둘이 달라야 1

            int c = 255;
            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c);

        }
    }
}
