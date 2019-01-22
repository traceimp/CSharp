using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BrainCSharp
{
    class HelloWorld
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용방법: HelloWorld.exe <이름>");
                return;
            }

            WriteLine("Hellom {0}!", args[0]);
        }
    }
}
