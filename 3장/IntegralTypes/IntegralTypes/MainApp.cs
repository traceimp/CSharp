﻿using System;

namespace IntegralTypes
{
    class MainApp
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            // 비타민 퀴즈 3-1
            //sbyte a = -5000_0000_0000;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            // _: 자릿수 구분자
            int e = -1000_0000;     // 0이 7개
            int f = 3_0000_0000;    // 0이 8개

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;           // 0이 11개
            ulong h = 200_0000_0000_0000_0000;  // 0이 18개

            Console.WriteLine($"g={g}, h={h}");
            
        }
    }
}
