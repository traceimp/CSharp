using System;
using System.Linq;

namespace Ex15_2
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

            //var selected = cars.Where(c => c.Cost < 60).OrderBy(c => c.Cost);
            var selected = from car in cars
                           where car.Cost < 60
                           orderby car.Cost
                           select car;

            foreach (var c in selected)
                Console.WriteLine($"Cost: {c.Cost}, Maxspeed: {c.MaxSpeed}");
        }
    }
}