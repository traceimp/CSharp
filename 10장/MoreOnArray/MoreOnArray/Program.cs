using System;

namespace MoreOnArray
{
    class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }

        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions: {scores.Rank}");

            Console.WriteLine("Binary Search: 81 is at {0}", Array.BinarySearch<int>(scores, 81));
            Console.WriteLine("Linear Search: 90 is at {0}", Array.IndexOf(scores, 90));

            // TrueForAll 메소드는 배열과 함께 조건을 검사하는 메소드를 함께 매개변수로 받습니다.
            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));


            // FindIndex 메소드는 특정 조건에 부합하는 메소드를 매개 변수로 받습니다. 여기에선 익명 메소드로 구현해봤습니다.
            int index = Array.FindIndex<int>(scores, delegate (int score)
            {
                if (score < 60)
                    return true;
                else
                    return false;
            });

            scores[index] = 61;
            Console.WriteLine("Everyone passed ? : {0}", Array.TrueForAll<int>(scores, CheckPassed));

            Console.WriteLine($"Old length of scorers: {scores.GetLength(0)}");

            Array.Resize<int>(ref scores, 10);  // 5였던 배열의 용량을 10으로 재조정합니다.

            Console.WriteLine($"New length of scores: {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Array.Clear(scores, 3, 7);

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}
