
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drawing_application
{
    class shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("base class draw method");
        }
    }

    class circle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a circle");
            base.Draw();
        }
    }

    class triangle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a triangle");
            base.Draw();
        }
    }

    class rectangle : shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a rectangle");
            // base.Draw();
        }

    }

    class square : shape
    {
        public override void Draw()
        {
            Console.WriteLine("drawing a square");
            base.Draw();                                             //reference for a base class//base class method will not be called if we dont use 
        }
    }
    class Program
    {



        public static void Main(string[] args)
        {
            shape s = null;
            int userinput;

            do
            {

                Console.WriteLine("choose an option to draw shapes");
                Console.WriteLine("1: circle");
                Console.WriteLine("2: triangle");
                Console.WriteLine("3: rectangle");
                Console.WriteLine("4: square");
                Console.WriteLine("enter your input");

                userinput = Convert.ToInt32(Console.ReadLine());

                switch (userinput)
                {
                    case 1:
                        s = new circle();
                        break;

                    case 2:
                        s = new triangle();
                        break;

                    case 3:
                        s = new rectangle();
                        break;

                    case 4:
                        s = new square();
                        break;

                    default:
                        Console.WriteLine("wrong");
                        Environment.Exit(0);
                        break;



                }


                s.Draw();
            }

            while (userinput >= 1 && userinput <= 5);


            /*   var drawobj = new List<shape>
              {
                  new circle(),
                  new triangle(),
                  new rectangle(),
                  new square(),
              };

              foreach(shape s in drawobj)
              {
                  s.Draw();              
              }*/
            Console.ReadLine();
        }

    }
}

// seeled keyword for method to stop overriding further
//for class uh cannot inherit