using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문제 1
            Console.WriteLine("문제 1)");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= j)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 문제 2
            Console.WriteLine("문제 2)");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i <= j)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // 문제 3
            Console.WriteLine("문제 3)");
            int a = 0;
            while (a < 5)
            {
                int b = 0;
                while (b < 5)
                {
                    if (a >= b)
                        Console.Write("*");
                    b++;
                }
                Console.WriteLine();

                a++;
            }
            Console.WriteLine();

            a = 0;
            while (a < 5)
            {
                int b = 0;
                while (b < 5)
                {
                    if (a <= b)
                        Console.Write("*");
                    b++;
                }
                Console.WriteLine();
                a++;
            }

            Console.WriteLine();

            Console.WriteLine("문제 4)");
            while (true)
            {
                Console.Write("반복 횟수를 입력하세요 : ");
                string str = Console.ReadLine();
                int input = Convert.ToInt32(str);

                if (input <= 0)
                {
                    Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                    continue;
                }
                else
                {
                    int c = 0, d = 0;
                    do
                    {
                        Console.WriteLine();
                        do
                        {
                            if (c >= d)
                                Console.Write("*");

                            d++;
                        } while (d < 5);
                        c++;
                        d = 0;
                    } while (c < 5);
                    Console.WriteLine();

                    break;
                }
            }





        }
    }
}
