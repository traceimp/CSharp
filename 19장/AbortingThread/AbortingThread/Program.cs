using System;
using System.Threading;

namespace AbortingThread
{
    class SideTask
    {
        int count;

        public SideTask(int count)
        {
            this.count = count;
        }

        public void KeepAlive()
        {
            try
            {
                while(count > 0)
                {
                    Console.WriteLine($"{count--} left");
                    Thread.Sleep(10);
                }
                Console.WriteLine("Count: 0");
            }
            catch(ThreadAbortException e)   // 스레드 취소(종료)
            {
                Console.WriteLine(e);
                Thread.ResetAbort();
            }
            finally
            {
                Console.WriteLine("Clearing resource...");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread t1 = new Thread(new ThreadStart(task.KeepAlive));
            t1.IsBackground = false;

            Console.WriteLine("Starting thread...");
            t1.Start();

            Thread.Sleep(10);

            Console.WriteLine("Aborting thread...");
            t1.Abort();

            Console.WriteLine("Waiting until thread stops...");
            t1.Join();

            Console.WriteLine("finished");
        }
    }
}
