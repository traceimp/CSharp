﻿using System;
using System.Collections;

namespace Yield
{
    class MyEnumerator
    {
        int[] numbers = { 1, 2, 3, 4 };
        public IEnumerator GetEnumerator()
        {
            yield return numbers[0];
            yield return numbers[1];
            yield return numbers[2];
            yield break;                // yield break는 GetEnumerator() 메소드를 종료시킴
            yield return numbers[3];    // => 따라서 이 코드는 실행하지 않음
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var obj = new MyEnumerator();
            foreach (int i in obj)
                Console.WriteLine(i);
        }
    }
}
