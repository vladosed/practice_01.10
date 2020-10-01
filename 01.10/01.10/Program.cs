using _01._10.modules;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace _01._10
{
    class Program
    {
        static void Main(string[] args)
        {
            StaticClass.Path = "sdfsf.txt";
            //StaticClass.Text = "Hello world!";
            var audi = new Car() { Name = "Audi A5", Price = 1500000 };
            var honda = new Car() { Name = "Civic", Price = 800000 };

            List<Car> carList = new List<Car>() { audi, honda };
            var jsonCar = JsonConvert.SerializeObject(carList);
            StaticClass.Text = jsonCar;
            StaticClass.WriteLine();
            StaticClass.ReadLine();

        }
    }
}
