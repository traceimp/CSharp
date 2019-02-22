using System;

namespace RelationalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3 > 4 : {3 > 4}");      // false
            Console.WriteLine($"3 >= 4 : {3 >= 4}");    // false
            Console.WriteLine($"3 < 4 : {3 < 4}");      // true
            Console.WriteLine($"3 <= 4 : {3 <= 4}");    // true
            Console.WriteLine($"3 == 4 : {3 == 4}");    // false
            Console.WriteLine($"3 != 4 : {3 != 4}");    // true
        }
    }
}
