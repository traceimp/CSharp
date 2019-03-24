using System;

namespace Throw
{
    class Program
    {
        static void DoSomething(int arg)
        {
            if (arg < 10)
                Console.WriteLine($"arg : {arg}");
            else
                throw new Exception("arg가 10보다 큽니다.");
        }

        static void Main(string[] args)
        {
            try
            {
                DoSomething(1);
                DoSomething(3);
                DoSomething(5);
                DoSomething(9);
                DoSomething(11);
                DoSomething(13);    // 23행에서 예외가 발생하여 현재 행은 실행되지 않습니다.
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
