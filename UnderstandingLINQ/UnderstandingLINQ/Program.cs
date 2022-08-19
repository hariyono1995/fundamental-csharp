using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car{VIN = "A1", Make = "BMW", Model = "550i", Price = 200000},
                new Car{VIN = "B2", Make = "Toyota", Model = "4Runner", Price = 280000},
                new Car{VIN = "C3", Make = "BMW", Model = "745li", Price = 500}, 
                new Car{VIN = "D4", Make = "Ford", Model = "Escape", Price = 10000},
                new Car{VIN = "E5", Make = "BMW", Model = "55i", Price = 9700},

            };

            //LINQ query
            //var bmws = from car in myCars
            //           where car.Make == "BMW"
            //           select car;

            //var orderDescending = from car in myCars
            //                      orderby car.Price descending
            //                      select car;
            //LINQ method
            /*
            var bmws = myCars.Where(p => p.Make == "BMW");
            var orderDescending = myCars.OrderByDescending(p => p.Price);
            var firstCar = myCars.First();
            var lastCar = from car in myCars
                          orderby car.VIN descending
                          select car.VIN;

            Console.WriteLine(lastCar.First());

            foreach (var car in lastCar)
            {
                Console.WriteLine(car.VIN);
            }

            Console.WriteLine("first car: {0} {1} {2} {3}",
                firstCar.VIN,
              firstCar.Make, 
              firstCar.Price, 
              firstCar.Model);

            Console.WriteLine("last car: {0} {1} {2} {3}", lastCar.VIN,
              lastCar.Make,
              lastCar.Price,
              lastCar.Model);

            
            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1} {2}",
                car.VIN, 
                car.Model, 
                car.Price);
            }

            foreach (var car in bmws)
            {
                Console.WriteLine("{0} {1} {2}", 
                car.Price, 
                car.Make, 
                car.VIN);
            }
            
            Console.WriteLine(myCars.TrueForAll(car => car.Model == "BMW"));
            Console.WriteLine(myCars.Exists(car => car.Make == "BMW"));
            Console.WriteLine(myCars.Sum(car => car.Price));

            myCars.ForEach(car => Console.WriteLine(car.Make));

            foreach (var car in myCars)
            {
                Console.WriteLine(car.Price);
            }
            */

            string str = "Hello world";

            Console.WriteLine(str.GetType());

            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
    }
}
