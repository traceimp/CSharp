using System;
using System.Reflection;
using System.Reflection.Emit;

namespace EmitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyBuilder newAssembly = // 1. 어셈블리 생성
                AppDomain.CurrentDomain.DefineDynamicAssembly(new AssemblyName("CalculatorAssembly"), AssemblyBuilderAccess.Run);

            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");    // 2. 모듈 생성
            TypeBuilder newType = newModule.DefineType("Sum1To100");                    // 3. 클래스 생성

            MethodBuilder newMethod = newType.DefineMethod(                             // 4. 메소드 생성
                "Claculate",                // 메소드명
                MethodAttributes.Public,    // 접근성
                typeof(int),                // 반환 형식
                new Type[0]);               // 매개 변수

            ILGenerator generator = newMethod.GetILGenerator();                         // 5. IL 넣기 (메소드에서 실행할 코드 구현)

            generator.Emit(OpCodes.Ldc_I4, 1);       // 32비트 정수(1)를 계산 스택에 넣기

            for(int i = 2; i<=100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i);  // 32비트 정수(i)를 계산 스택에 넣기
                generator.Emit(OpCodes.Add);        // 계산 후 계산 스택에 담겨있는 두 개의 값을 꺼내서 더한 후, 그 결과를 다시 계산 스택에 넣기
            }

            generator.Emit(OpCodes.Ret);    // 계산 스택에 담겨있는 값을 반환
            newType.CreateType();           // CLR에 해당 객체의 내용 제출

            object sum1To100 = Activator.CreateInstance(newType);
            MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");  // invoke => 동적으로 메소드 호출 가능
            Console.Write(Calculate.Invoke(sum1To100, null));

        }
    }
}
