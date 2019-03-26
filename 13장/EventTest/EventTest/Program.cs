using System;

namespace EventTest
{
    delegate void EventHandler(string message); // 1. 대리자 선언

    class MyNotifier
    {
        public event EventHandler SomethingHappened;    // 2. 대리자의 인스턴스를 event 한정자로 수식해서 선언
        public void DoSomething(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0)
                SomethingHappened(String.Format("{0} : 짝", number));
        }
    }

    class Program
    {
        // 이벤트 핸들러는 public 한정자로 선언되어 있어도자신이 선언되어 있는 클래스 외부에서는 호출이 불가능!!!
        static public void MyHandler(string message)    // 3. 이벤트 핸들러 작성
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();                     //─┬─ 4. 클래스 인스턴스를 생성
            notifier.SomethingHappened += new EventHandler(MyHandler);  // │  이 객체의 이벤트에 3의 이벤트 핸들러를 등록
                                                                        // │
            for (int i = 1; i < 30; i++)                                // │
                notifier.DoSomething(i);                                //─┘  5. 이벤트가 발생하면 이벤트 핸들러가 호출

            // SomethingHappened에는 2개의 이벤트가 포함
            // ① SomethingHappened(String.Format("{0} : 짝", number));
            // ② Console.WriteLine(message);

        }
    }
}
