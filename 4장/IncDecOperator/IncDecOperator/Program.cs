using System;

namespace IncDecOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine(a++); // 10
            Console.WriteLine(++a); // 12

            Console.WriteLine(a--); // 12
            Console.WriteLine(--a); // 10
        }
    }
}
