using System;
using System.Collections;

namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get { return array[index]; }

            set
            {
                if(index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        // IEnumerator 멤버
        public object Current   // IEnumerator로부터 상속받은 Current 프로퍼티는 현재 위치의 요소를 반환
        {
            get
            {
                return array[position];
            }
        }

        // IEnumerator 멤버
        public bool MoveNext()  // IEnumerator로 부터 상속받은 MoveNext() 메소드. 다음 위치의 요소도 이동
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        // IEnumberator 멤버
        public void Reset() // IEnumberator로 부터 상속받은 Reset() 메소드. 요소의 위치를 첫 요소의 "앞"으로 옮깁니다.
        {
            position = -1;
        }

        // IEnumberator 멤버
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
                yield return (array[i]);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++) // 배열에 값을 집어넣음
                list[i] = i;

            foreach (int e in list)     // 배열 출력
                Console.WriteLine(e);
        }
    }
}
