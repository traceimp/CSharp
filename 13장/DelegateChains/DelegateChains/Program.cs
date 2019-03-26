﻿using System;

namespace DelegateChains
{
    delegate void Notify(string message);   // Notify 대리자 선언

    class Notifier  // Notify 대리자의 인스턴스 EventOccured를 가지는 클래스 Notifier 선언
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine($"{name}.SomethingHappened : {message}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listener1");
            EventListener listener2 = new EventListener("Listener2");
            EventListener listener3 = new EventListener("Listener3");

            notifier.EventOccured += listener1.SomethingHappend;    //─┬─ += 연산자를 이용한 체인 만들기
            notifier.EventOccured += listener2.SomethingHappend;    //─┤
            notifier.EventOccured += listener3.SomethingHappend;    //─┘
            notifier.EventOccured("You've got mail.");

            Console.WriteLine();

            notifier.EventOccured -= listener2.SomethingHappend;    // -= 연산자를 이용한 체인 끊기
            notifier.EventOccured("Download Complete.");

            Console.WriteLine();

            notifier.EventOccured = new Notify(listener2.SomethingHappend)      //─┬─ +, = 연산자를 이용한 체인 만들기
                                  + new Notify(listener3.SomethingHappend);     //─┘
            notifier.EventOccured("Nuclear launch detected.");

            Console.WriteLine();

            Notify notify1 = new Notify(listener1.SomethingHappend);
            Notify notify2 = new Notify(listener2.SomethingHappend);

            notifier.EventOccured = (Notify)Delegate.Combine(notify1, notify2); // Delegate.Combine() 메소드를 이용한 체인 만들기
            notifier.EventOccured("Fire!!");

            Console.WriteLine();

            notifier.EventOccured = (Notify)Delegate.Remove(notifier.EventOccured, notify2);    // Delegate.Remove() 메소드를 이용한 체인 끊기
            notifier.EventOccured("RPG!");
        }
    }
}
