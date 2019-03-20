using System;
using System.Collections;

namespace Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문제 2
            //int[,] arr1 = new int[2, 2]
            //{
            //    {3, 2},
            //    {1, 4}
            //};

            //int[,] arr2 = new int[2, 2]
            //{
            //    {9, 2},
            //    {1, 7}
            //};

            //int[,] array = new int[2, 2];
            ////array[0, 0] = (arr1[0, 0] * arr2[0, 0]) + (arr1[0, 1] * arr2[1, 0]);    // a
            ////array[0, 1] = (arr1[0, 0] * arr2[0, 1]) + (arr1[0, 1] * arr2[1, 1]);    // b
            ////array[1, 0] = (arr1[1, 0] * arr2[0, 0]) + (arr1[1, 1] * arr2[1, 0]);    // c
            ////array[1, 1] = (arr1[1, 0] * arr2[0, 1]) + (arr1[1, 1] * arr2[1, 1]);    // d

            //for(int i=0; i<array.GetLength(0); i++)
            //{
            //    array[i, 0] = (arr1[i, 0] * arr2[0, 0]) + (arr1[i, 1] * arr2[1, 0]);
            //    Console.WriteLine($"{array[i, 0]}");
            //    array[i, 1] = (arr1[i, 0] * arr2[0, 1]) + (arr1[i, 1] * arr2[1, 1]);
            //    Console.WriteLine($"{array[i, 1]}");

            //}

            //// array 출력
            //for (int i = 0; i<array.GetLength(0); i++)
            //{
            //    for(int j = 0; j<array.GetLength(1); j++)
            //    {
            //        Console.Write($"{array[i, j]} ");
            //    }
            //    Console.WriteLine();
            //}



            // 문제 3 확인
            //Stack stack = new Stack();
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(3);
            //stack.Push(4);
            //stack.Push(5);

            //while (stack.Count > 0)
            //    Console.WriteLine(stack.Pop());



            // 문제 4 확인
            //Queue que = new Queue();
            //que.Enqueue(1);
            //que.Enqueue(2);
            //que.Enqueue(3);
            //que.Enqueue(4);
            //que.Enqueue(5);

            //while (que.Count > 0)
            //    Console.WriteLine(que.Dequeue());



            // 문제 5
            Hashtable ht = new Hashtable();

            ht["회사"] = "Microsoft";
            ht["URL"] = "www.microsoft.com";

            Console.WriteLine("회사 : {0}", ht["회사"]);
            Console.WriteLine("URL : {0}", ht["URL"]);
        }
    }
}
