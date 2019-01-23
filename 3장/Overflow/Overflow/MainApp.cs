using System;

namespace Overflow
{
    class MainApp
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
            Console.WriteLine("=======================");

            // 비타민 퀴즈 3-2
            // Overflow 예제에서 uint 대신에 int를 사용하고 uint.MaxValue 대신에
            // int.MaxValue를 사용해서 코드를 바꿔 실험해보세요.

            int a1 = int.MaxValue;

            Console.WriteLine(a1);

            a1 = a1 + 1;

            Console.WriteLine(a1);

        }
    }
}
