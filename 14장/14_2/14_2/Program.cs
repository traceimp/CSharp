using System;

namespace _14_2
{
    class Program
    {
        delegate int Result(int a);
        delegate void Result2(int[] arr);

        static void Main(string[] args)
        {
            // 문제 1
            //Func<int> func_1 = () => 10;
            //Func<int, int> func_2 = (a) => a * 2;

            //Console.WriteLine(func_1() + func_2(30));

            //문제 2
            int[] array = { 11, 22, 33, 44, 55 };

            //foreach (int a in array)
            //{
            //    Action action = new Action
            //        (
            //            delegate ()
            //            {
            //                Console.WriteLine(a * a);
            //            }
            //        );
            //    action.Invoke();
            //}

            // 기본 람다식
            Console.WriteLine(">> 기본 람다식 <<");
            Result re = (int a) => a * a;
            foreach (int a in array)
                Console.WriteLine(re(a));
            Console.WriteLine();

            // 문 형식 람다식
            Console.WriteLine(">> 문형식 람다식 <<");
            Result2 re2 = (int[] arr) =>
            {
                foreach (int a in arr)
                    Console.WriteLine(a * a);
            };
            re2(array);
            Console.WriteLine();

            // Func 람다식
            Console.WriteLine(">> Func 람다식 <<");
            Func<int, int> func = (x) => x * x;
            foreach (int a in array)
                Console.WriteLine(func(a));
            Console.WriteLine();

            // Action 람다식
            Console.WriteLine(">> Action 람다식 <<");
            Action<int[]> action = (int[] arr) =>
            {
                foreach (int a in arr)
                    Console.WriteLine(a * a);
            };
            action(array);
            Console.WriteLine();

        }
    }
}
