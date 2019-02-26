using System;

namespace UsingParams
{
    class Program
    {
        static int Sum(params int[] args)   // Sum() 메소드에 입력한 모든 메소드는 args 배열에 담깁니다.
        {
            Console.Write("Summing...");

            int sum = 0;

            for(int i=0; i<args.Length; i++)
            {
                if (i > 0)
                    Console.Write(", ");

                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
