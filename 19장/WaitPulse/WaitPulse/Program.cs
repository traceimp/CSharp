using System;
using System.Threading;

namespace WaitPulse
{
    class Counter
    {
        const int LOOP_COUNT = 1000;

        readonly object thisLock;
        bool lockedCount = false;   //─┬─ lockedCount와 count는 스레드가 블록될 조건을 검사하기 위해 사용됩니다.
                                    // │  lockedCount는 count 변수를 다른 스레드가 사용하고 있는지를 판별하기 위해,
        private int count;          //─┘  count는 각 스레드가 너무 오랫동안 count 변수를 혼자 사용하는 것을 막기위해 사용되었습니다.
        public int Count
        {
            get { return count; }
        }

        public Counter()
        {
            thisLock = new object();
            count = 0;
        }

        public void Increase()
        {
            int loopCount = LOOP_COUNT;

            while(loopCount-- > 0)
            {
                lock(thisLock)
                {
                    while (count > 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count++;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }

        public void Decrease()
        {
            int loopCount = LOOP_COUNT;

            while (loopCount-- > 0)
            {
                lock (thisLock)
                {
                    while (loopCount < 0 || lockedCount == true)
                        Monitor.Wait(thisLock);

                    lockedCount = true;
                    count--;
                    lockedCount = false;

                    Monitor.Pulse(thisLock);
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();


            Thread incThread = new Thread(new ThreadStart(counter.Increase));
            Thread decThread = new Thread(new ThreadStart(counter.Decrease));

            incThread.Start();
            decThread.Start();

            incThread.Join();
            decThread.Join();

            Console.WriteLine(counter.Count);
        }
    }
}
