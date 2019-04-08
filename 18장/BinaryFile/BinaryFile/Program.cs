using System;
using System.IO;

namespace BinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryWriter bw = new BinaryWriter(new FileStream("a.dat", FileMode.Create));

            bw.Write(int.MaxValue);
            bw.Write("Good morning");
            bw.Write(uint.MaxValue);
            bw.Write("안녕하세요!");
            bw.Write(double.MaxValue);

            bw.Close(); // 쓰기를 마쳤다면 Close()를 호출하여 내부 스트림을 닫습니다.

            BinaryReader br = new BinaryReader(new FileStream("a.dat", FileMode.Open));

            Console.WriteLine($"File size : {br.BaseStream.Length} bytes");
            Console.WriteLine($"{br.ReadInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadUInt32()}");
            Console.WriteLine($"{br.ReadString()}");
            Console.WriteLine($"{br.ReadDouble()}");

            br.Close(); // 스트림을 쓸 때뿐 아니라 읽을 때도 Close() 메소드를 호출하여 내부 스트림을 닫어줘야 합니다.

            Console.WriteLine();

            // 비타민 퀴즈 18-2 => 255자가 넘는 데이터도 가능한가?
            BinaryWriter bw2 = new BinaryWriter(new FileStream("b.dat", FileMode.Create));

            bw2.Write("가나다라마바사아자차카타파하아야어여오요우유으이기역니은디귿리을미음비읍시옷지읏치읏키읔티읕피읖히읗가나다라마바사아자차카타파하아야어여오요우유으이기역니은디귿리을미음비읍시옷지읏치읏키읔티읕피읖히읗가나다라마바사아자차카타파하아야어여오요우유으이기역니은디귿리을미음비읍시옷지읏치읏키읔티읕피읖히읗가나다라마바사아자차카타파하아야어여오요우유으이기역니은디귿리을미음비읍시옷지읏치읏키읔티읕피읖히읗가나다라마바사아자차카타파하아야어여오요우유으이기역니은디귿리을미음비읍시옷지읏치읏키읔티읕피읖히읗가나다라마바사아자차카타파하아야어여오요우유으이기역니은디귿리을미음비읍시옷지읏치읏키읔티읕피읖히읗");
            bw2.Close();

            BinaryReader br2 = new BinaryReader(new FileStream("b.dat", FileMode.Open));

            Console.WriteLine($"{br2.ReadString()}");
            br2.Close();
        }
    }
}
