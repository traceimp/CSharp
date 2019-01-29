using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. 다음 코드에서 잘못된 부분을 찾고, 그 이유를 설명하시오.
            int a = 7; // int형에 소수 형식을 저장하려 함
            float b = 3.14f; // float형은 마지막에 f를 붙여줘야 함
            double c = a * b; // a와 b가 잘못됐기 때문에 오류. 단, a와 b가 올바르다고 하더라도 쓰레기 값이 저장됨
            //char d = "abc"; // char형은 문자에만 사용, 작은 따옴표를 사용.
            //string e = '한'; // string형은 문자열 사용, 큰 따옴표 사용. 

            // 2. 값 형식과 참조 형식의 차이는 무엇인가요?
            // 값 형식은 스택 메모리에 올라가고, 숫자나 문자 같은 형식을 의미
            // 참조 형식은 힙 메모리에 올라가고, 값을 저장한 힙 메모리의 주소값을 의미

            // 3. 박싱과 언박싱을 설명하세요.
            // object형에서 사용.
            // 박싱은 값을 박싱해서 힙 메모리에 값을, 스택에 메모리에 그 값의 주소값을 올려 사용 (간접 참조)
            // 언박싱은 박싱한 값을 꺼내서 스택 메모리에 올림 (직접 참조)

            // 4. 다음과 같이 사용자로부터 사각형의 너비와 높이를 입력받아 넓이를 계산하는 프로그램을 완성하세요.
            //    다음 코드 중 주석 부분을 바꾸면 됩니다.
            // [결과 화면]
            // 사각형의 너비를 입력하세요.
            // 30
            // 사각형의 높이를 입력하세요.
            // 40
            // 사각형의 넓이는 : 1200

            Console.WriteLine("사각형의 너비를 입력하세요.");
            string width = Console.ReadLine();

            Console.WriteLine("사각형의 높이를 입력하세요.");
            string height = Console.ReadLine();

            // 이 곳에 사각형의 넓이를 계산하고
            int result = Int32.Parse(width) * Int32.Parse(height);
            // 출력하는 루틴을 추가하세요.
            Console.WriteLine("사각형의 넓이는 : {0}", result);

            // 5. 다음 코드를 컴파일한 후의 a와 b는 각각 어떤 데이터 형식이겠습니까?
            var a = 2020;
            var b = "double";
            Console.WriteLine("a type: {0}, b type: {1}", a.GetType(), b.GetType());
        }
    }
}
