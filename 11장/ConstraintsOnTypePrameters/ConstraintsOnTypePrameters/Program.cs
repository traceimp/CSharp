using System;

namespace ConstraintsOnTypePrameters
{
    interface IA { }

    class StructArray<T> where T : struct // T는 값형식
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
            Console.WriteLine($"StructArray 생성 {Array.Length}");
        }
    }

    class RefArray<T> where T : class // T는 참조 형식
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
            Console.WriteLine($"RefArray 생성 {Array.Length}");

        }
    }

    class Base { public Base() { Console.WriteLine("Base 생성"); } }
    class Derived : Base{ public Derived() { Console.WriteLine("Derived 생성"); } }
    class BaseArray<U> where U : Base // U는 기반 클래스를 상속하는 파생 클래스
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
            Console.WriteLine($"BaseArray 생성 {Array.Length}");
        }

        public void CopyArray<T>(T[] Source) where T : U // T는 또 다른 형식 매개 변수 U로부터 상속받은 클래스여야 함
        {
            Source.CopyTo(Array, 0);
            Console.WriteLine($"CopyArray 진행 / Source: {Source.Length} / Array: {Array.Length}");
        }
    }

    class MethodInterface<T> where T : IA
    {
        public void MethodA()
        {
            Console.WriteLine($"IA.Method_a 구현");
        }
    }

    class Program
    {
        public static T CreateInstance<T>() where T : new() // T는 매개 변수가 없는 생성자가 있어야 함
        {
            Console.WriteLine($"CreateInstance 진입");
            return new T();
        }

        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            Console.Write("StructArray 값들: ");
            for (int i = 0; i < a.Array.Length; i++)
                Console.Write(a.Array[i]+" ");
            Console.WriteLine();
            Console.WriteLine();

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);
            Console.WriteLine();

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();
            Console.WriteLine();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived(); // Base 형식은 여기에 할당할 수 없다.
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();
            Console.WriteLine();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);
            Console.WriteLine();

            MethodInterface<IA> f = new MethodInterface<IA>();
            f.MethodA();
            
        }
    }
}
