using System;
using System.Threading;

namespace BasicThread
{
    class Program
    {
        static void DoSomething()
        {
            for(int i =0; i<5; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);   // Sleep() 메소드는 다른 스레드도 CPU를 사용할 수 있도록 CPU 점유를 내려놓습니다. 매개변수는 밀리초 단위입니다.
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(DoSomething));

            Console.WriteLine("Starting thread...");
            t1.Start();

            for(int i =0; i<5; i++)
            {
                Console.WriteLine($"Main: {i}");
                Thread.Sleep(10);
            }

            Console.WriteLine("Wating until thread stops...");
            t1.Join();

            Console.WriteLine("Finished");

        }
    }
}
