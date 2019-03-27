using System;
using System.Collections.Generic;

namespace ExpressionBodiedMember
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);         // 메소드를 식으로 1
        public void Remove(string name) => list.Remove(name);   // 메소드를 식으로 2
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        public FriendList() => Console.WriteLine("FriendList()");   // 생성자를 식으로
        ~FriendList() => Console.WriteLine("~FriendList()");        // 종료자를 식으로

        // public int Capacity => list.Capacity;    // 읽기 전용
        public int Capacity // 속성
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        // public string this[int index] => list[index];    // 읽기 전용
        public string this[int index]   // 인덱서
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Eeny");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.Remove("Eeny");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Moe";
            obj.PrintAll();
        }
    }
}
