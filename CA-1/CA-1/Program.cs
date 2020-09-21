using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_1
{
   
    public abstract class Vehicle
    {
        private string make;
        private string model;
        private int year;
        private double price;

        protected Vehicle(string make, string model, double price, int year)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.year = year;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public abstract void checkPrice();

        public abstract void printInfo();

        public abstract void testDrive();
    }
    class Minivan : Vehicle
    {
        string model_name;
        public Minivan(string make,string model,double price,int year) : base(make,model,price,year)
        {
            model_name = model;
        }




        public override void checkPrice()
        {
           
           
             Console.WriteLine("price" + Price);

            

        }

        public override void printInfo()
        {
            Console.WriteLine("Make:" + Make);
            Console.WriteLine("Model" + Model);
            Console.WriteLine("Year:" + Year);
            Console.WriteLine("price" + Price);

        }

        public override void testDrive()
        {
            Console.WriteLine("Make:" + Make);
            Console.WriteLine("Model" + Model);
            Console.WriteLine("Year:" + Year);
           

        }
    }
    class SchoolBus : Vehicle
    {
        string model_name;
        public SchoolBus(string make, string model, double price, int year) : base(make, model, price, year)
        {
            model_name = model;
        }
        public override void checkPrice()
        {
           
            Console.WriteLine("price" + Price);
        }

        public override void printInfo()
        {
            Console.WriteLine("Make:" + Make);
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("Year:" + Year);
            Console.WriteLine("price:" + Price);
        }

        public override void testDrive()
        {
            Console.WriteLine("Make:" + Make);
            Console.WriteLine("Mode:l" + Model);
            Console.WriteLine("Year:" + Year);
           
        }
    }
    class Program
        {
            static void Main(string[] args)
            {
            Minivan minivan = new Minivan("a", "swift", 2001, 20000);
            SchoolBus schoolbus = new SchoolBus("b", "omini", 1894, 500000);

            Console.WriteLine("MINIVAN INFO");
            Console.WriteLine("price info");
            minivan.checkPrice();
            Console.WriteLine("\n");
            Console.WriteLine("print info");
            minivan.printInfo();
            Console.WriteLine("\n");
            Console.WriteLine("test drive");
            minivan.testDrive();
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            Console.WriteLine("SCHOOL INFO");
            Console.WriteLine("price info");
            schoolbus.testDrive();
            Console.WriteLine("\n");
            Console.WriteLine("print info");
            schoolbus.printInfo();
            Console.WriteLine("\n");
            Console.WriteLine("test drive");
            schoolbus.testDrive();

            Console.ReadLine();

            }
        }
    }

