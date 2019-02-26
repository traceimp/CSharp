using System;

namespace Practice
{
    class Program
    {
        // 문제 1 메소드
        static double Square(double arg)
        {
            return arg * arg;
        }

        static void Main(string[] args)
        {
            // 문제 1 (메인)
            //Console.Write("수를 입력하세요: ");
            //string input = Console.ReadLine();
            //double arg = Convert.ToDouble(input);

            //Console.WriteLine("결과: {0}", Square(arg));



            // 문제 2 (메인)
            //double mean = 0;

            ////Mean(1, 2, 3, 4, 5, ref mean);
            //Mean(1, 2, 3, 4, 5, out mean);

            //Console.WriteLine("평균: {0}", mean);

            // 문제 3 (메인)
            int a = 3;
            int b = 4;
            int resultA = 0;

            Plus(a, b, out resultA);

            Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

            double x = 2.4;
            double y = 3.1;
            double resultB = 0;

            Plus(x, y, out resultB);    // 오버로드가 필요한 메소드입니다.
            Console.WriteLine("{0} + {1} = {2}", x, y, resultB);

        }

        // 문제 2 메소드
        //public static void Mean(double a, double b, double c, double d, double e, ref double mean)
        public static void Mean(double a, double b, double c, double d, double e, out double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }

        // 문제 3 메소드
        public static void Plus(int a, int b, out int c)
        {
            c = a + b;
        }

        public static void Plus(double a, double b, out double c)
        {
            c = a + b;
        }
    }
}
