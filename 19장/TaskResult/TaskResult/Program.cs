using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TaskResult
{
    class Program
    {
        static bool IsPrime(long number)
        {
            if (number < 2)
                return false;

            if (number % 2 == 0 && number != 2)
                return false;

            for(long i=2; i<number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            long from = Convert.ToInt64(args[0]);
            long to = Convert.ToInt64(args[1]);
            int taskCount = Convert.ToInt32(args[2]);   // 작업할 테스크의 량

            
            //  ┌ 입력  매개 형식  ┌ 반환 형식(가장 마지막은 항상 반환 형식)
            Func<object, List<long>> FindPrimeFunc =
                (objectRange) =>
                {
                    long[] range = (long[])objectRange;     // 소수인지 체크할 숫자들
                    List<long> found = new List<long>();    // 찾은 소수 배열

                    for (long i = range[0]; i < range[1]; i++)
                    {
                        if (IsPrime(i))
                            found.Add(i);
                    }

                    return found;
                };
            
            // Task 객체를 만들되 List<long> 형태의 결과를 받는다
            Task<List<long>>[] tasks = new Task<List<long>>[taskCount];
            long currentFrom = from;
            long currentTo = to / tasks.Length;
            for (int i = 0; i < tasks.Length; i++)
            {
                Console.WriteLine("Task[{0}] : {1} ~ {2}", i, currentFrom, currentTo);

                tasks[i] = new Task<List<long>>(FindPrimeFunc, new long[] { currentFrom, currentTo });
                currentFrom = currentTo + 1;

                if (i == tasks.Length - 2)
                    currentTo = to;
                else
                    currentTo = currentTo + (to / tasks.Length);
            }

            Console.WriteLine("Please press enter to start...");
            Console.ReadLine();
            Console.WriteLine("Started...");

            DateTime startTime = DateTime.Now;

            foreach (Task<List<long>> task in tasks)
                task.Start();

            List<long> total = new List<long>();

            foreach(Task<List<long>> task in tasks)
            {
                task.Wait();
                total.AddRange(task.Result.ToArray());
            }
            DateTime endTime = DateTime.Now;

            TimeSpan ellapsed = endTime - startTime;    // 걸린 시간 계산

            Console.WriteLine("Prime number count between {0} and {1} : {2}",
                from, to, total.Count);

            Console.WriteLine("Ellapsed tiem : {0}", ellapsed);
        }
    }
}
