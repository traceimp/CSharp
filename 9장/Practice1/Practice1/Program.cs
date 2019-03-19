using System;

namespace Practice1
{
    class NameCard
    {
        public int Age
        { get; set; }

        public string Name
        { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            NameCard MyCard = new NameCard()
            { Age = 24, Name = "상현" };

            Console.WriteLine("나이: {0}", MyCard.Age);
            Console.WriteLine("이름: {0}", MyCard.Name);
        }
    }
}
