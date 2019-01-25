using System;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;   // a에 담긴 값을 박싱해서 힙에 저장
            int c = (int)b;         // b에 저장된 값을 언박싱해서 스택에 저장

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            double x = 3.1414213;
            object y = x;           // x에 담긴 값을 박싱해서 힙에 저장 (object에 저장할 때 형식 연산자를 지정하지 않으면 암시적으로 object로 형변환)
            double z = (double)y;   // y에 담긴 값을 언박싱해서 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}
