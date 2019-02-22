using System;

namespace LogicalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing && ... ");
            Console.WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");    // true
            Console.WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");    // false
            Console.WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");  // false
            Console.WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");  // false

            Console.WriteLine("\nTesting || ... ");
            Console.WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");    // true
            Console.WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");    // true
            Console.WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");  // false
            Console.WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");  // true

            Console.WriteLine("\nTesing ! ... ");
            Console.WriteLine($"!True : {!true}");      // false
            Console.WriteLine($"!false : {!false}");    // true
        }
    }
}
