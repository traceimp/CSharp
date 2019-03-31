using System;
using System.Linq;

namespace Ex15_1
{
    class Car
    {
        public int Cost { get; set; }
        public int MaxSpeed { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car[] cars =
            {
                new Car(){Cost=56,MaxSpeed=120},
                new Car(){Cost=70,MaxSpeed=158},
                new Car(){Cost=45,MaxSpeed=180},
                new Car(){Cost=32,MaxSpeed=200},
                new Car(){Cost=82,MaxSpeed=280}
            };

            // where 절로만 검색
            var selected = from car in cars
                           where car.Cost > 50
                           where car.MaxSpeed > 150
                           select car;

            foreach (var c in selected)
                Console.WriteLine($"Cost: {c.Cost}, Maxspeed: {c.MaxSpeed}");
        }
    }
}
