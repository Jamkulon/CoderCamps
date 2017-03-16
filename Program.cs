using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    //abstract class be inherited from but never instanciated  anything with 'Car' will pull the information to that class
    public abstract class Car
    {
        public string VIN { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal CalculateTax()
        {
            return Price * .08m;
        }

    }
    //car classes
    public class NewCar : Car
    {

    }

    public class UsedCar : Car
    {
        public int Miles { get; set; }
    }

    public class CertifiedUsedCar : UsedCar
    {

        public int WarrantyMonths { get; set; }
    }
    

    public class Program
    {
        public static void Main(string[] args)
        {
            CertifiedUsedCar vw = new CertifiedUsedCar()
            {
                VIN = "456f456dw456456",
                Price = 1499.99m
            };

            NewCar mazda = new NewCar()
            {
                VIN = "456d456et48946",
                Price = 23699.00m
            };

            //create collection of cars
            Car[]cars = new Car[] { vw, mazda };  //this is essential to the whole process

            decimal taxOnVw = vw.CalculateTax();
            decimal taxOncar = mazda.CalculateTax();
            Console.WriteLine(taxOnVw);
            Console.WriteLine(taxOncar);
            Console.ReadLine();
        }



    }
}

