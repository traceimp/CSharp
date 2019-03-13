using System;

namespace Bitamin8_2
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Car Run");
        }
    }

    class Plane : IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Plane Fly");
        }
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("FlyingCar Run");
        }

        public void Fly()
        {
            Console.WriteLine("FlyingCar Fly");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Run();

            Plane plane = new Plane();
            plane.Fly();

            FlyingCar flyingCar = new FlyingCar();
            flyingCar.Run();
            flyingCar.Fly();
        }
    }
}
