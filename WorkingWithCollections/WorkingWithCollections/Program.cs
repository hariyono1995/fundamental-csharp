using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Car car1 = new Car();
            car1.Make = "Oldsmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prisma";

            Book book1 = new Book();
            book1.Author = "Robert Tabor";
            book1.Title = "Microsoft .NET XML Web Services";
            book1.ISBN = "0-000-00000-0";

            // ArrayList dinamicly size array
            ArrayList myArray = new ArrayList();
            myArray.Add(car1);
            myArray.Add(car2);
            myArray.Add(book1);
            myArray.Remove(book1);

            foreach (Car car in myArray)
            {
                Console.WriteLine(car.Make);
            }

            List<Car> car3 = new List<Car>();
            car3.Add(car1);
            car3.Add(car2);
            //car3.Add(book1);

            foreach (Car car in car3)
            {
                Console.WriteLine(car.Make);
            }

            //Dictionary<TKey, TValue>
            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();

            myDictionary.Add(car1.Model, car1);

            Console.WriteLine(myDictionary["Cutlas Supreme"].Model);

            */

            //Object initializer
            // No need for a constructor

            Car car1 = new Car()
            {
                Make = "Joe Doe",
                Model = "Urus"
            };

            //Collection initializer
            List<Car> myGarage = new List<Car>()
            {
                new Car{Make = "Lorep Ipsum", Model = "Honda"},
                new Car{Make = "Null", Model = "Toyota series"}
            };

            Console.WriteLine(myGarage[0].Make);
            Console.ReadLine();
            
        }
    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
