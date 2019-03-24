using System;

namespace KillingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i]);

            Console.WriteLine("종료");    // 이 코드는 실행되지 않습니다. 12번 행에서 예외가 발생해서 프로그램이 종료되기 때문입니다.
        }
    }
}
