using System;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int myInt, int exponenet)
        {
            int result = myInt;
            for (int i = 1; i < exponenet; i++)
                result = result * myInt;
            return result;
        }

        // Bitamin Quiz 7-1
        public static string Append(this string myStr, string otherStr)
        {
            string str = myStr;
            str += otherStr;
            return str;
        }
    }
}

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : { 3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");

            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}
