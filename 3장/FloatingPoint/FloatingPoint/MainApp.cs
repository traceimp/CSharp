﻿using System;

namespace FloatingPoint
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // float 형식 변수에 값을 직접 할당하려면 숫자 뒤에 f를 붙여야 함
            float a = 3.1415_9256_3589_7932_3846f;
            Console.WriteLine(a);

            double b = 3.1415_9256_3589_7932_3846;
            Console.WriteLine(b);
        }
    }
}