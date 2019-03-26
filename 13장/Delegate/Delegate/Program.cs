using System;

namespace Delegate
{
    delegate int MyDelegate(int a, int b);  // 대리자 선언

    class Calculator
    {
        public int Plus(int a, int b)   // 대리자는 인스턴스 메소드도 참조할 수 있고,
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            Callback = new MyDelegate(Calc.Plus);   // 대리자를 메소드 호출하듯 사용하면, 참조하고 있는 메소드가 실행됩니다.
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}
