using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                Console.WriteLine("b) i : {0}", i--);   // i는 이미 0이지만 이 코드는 한차례 실행됩니다.
            }
            while (i > 0);
        }
    }
}
