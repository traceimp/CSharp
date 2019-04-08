using System;
using System.IO;

namespace TextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(new FileStream("a.dat", FileMode.Create));

            sw.WriteLine(int.MaxValue);
            sw.WriteLine("Good morning");
            sw.WriteLine(uint.MaxValue);
            sw.WriteLine("안녕하세요!");
            sw.WriteLine(double.MaxValue);

            sw.Close();

            StreamReader sr = new StreamReader(new FileStream("a.dat", FileMode.Open));

            Console.WriteLine($"File size: {sr.BaseStream.Length} bytes");

            while (sr.EndOfStream == false)
                Console.WriteLine(sr.ReadLine());

            sr.Close();
        }
    }
}
