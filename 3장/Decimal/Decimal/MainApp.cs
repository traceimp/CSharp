using System;

namespace Decimal
{
    class MainApp
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;     // f가 있으면 float
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;     // 아무것도 없으면 double
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;   // m이 있으면 decimal

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
