using System;
using System.IO;

namespace SeqNRand
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream outStream = new FileStream("a.dat", FileMode.Create);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x01);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x02);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x03);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.Seek(5, SeekOrigin.Current);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.WriteByte(0x04);
            Console.WriteLine($"Position : {outStream.Position}");

            outStream.Close();

            Console.WriteLine("-------------------");

            // 비타민 퀴즈 18-1
            Stream inStream = new FileStream("a.dat", FileMode.Open);

            Console.WriteLine($"Psition 0 : {inStream.ReadByte()}");
            Console.WriteLine($"Psition 1 : {inStream.ReadByte()}");
            Console.WriteLine($"Psition 2 : {inStream.ReadByte()}");
            Console.WriteLine($"Psition 8 : {inStream.Seek(5, SeekOrigin.Current)}");
            Console.WriteLine($"Psition 9 : {inStream.ReadByte()}");

            inStream.Close();
        }
    }
}
