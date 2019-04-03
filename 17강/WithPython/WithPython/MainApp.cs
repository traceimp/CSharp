using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace WithPython
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("n", "박상현");
            scope.SetVariable("p", "010-123-4566");

            ScriptSource source = engine.CreateScriptSourceFromString(
                @"
class NameCard :
    name = ''
    phone = ''

    def __init__(self, name, phone) :
        self.name = name
        self.phone = phone

    def printNameCard(self) :
        print self.name + ', ' + self.phone

NameCard(n, p)
");

            dynamic result = source.Execute(scope); // 22~35행의 파이썬 코드를 실행하여 그 결과를 반환. 34행에서 NameCard 생성자를 호출 -> 해당 객체가 생성되어 반환
            result.printNameCard();                 // 이 객체의 메소드를 호출할 수도 있고,

            Console.WriteLine("{0}, {1}", result.name, result.phone);
                                            // ㄴ 필드에도 접근 가능!
        }
    }
}
