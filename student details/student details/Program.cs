/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentdetails
{

    class DisplayData
    {
       
       
        public DisplayData(string Uid, string Name, int Sem, string Email)
        {

            Console.Write("Uid.... ");
            Uid = Console.ReadLine();
            Console.Write("Name.... ");
            Name = Console.ReadLine();
            Console.Write("Sem.... ");
            Sem = Convert.ToInt32(Console.ReadLine());
            Console.Write("Email.........");
            Email = Console.ReadLine();
        }




        public void GetData()

        {

            Console.WriteLine("Name....." + Name);
            Console.WriteLine("My Semister  is...." + semister);
            Console.WriteLine("My Campus  is.... " + Campus);

        }
        



    }
    class Program
    {
        static void Main(string[] args)
        {
            string FiName = "";
            string Laname = "";
            string FName = "";
            string Addr = "";
            string Gend = "";
            string Ema = "";

            DisplayData obj = new DisplayData(FiName, Laname, FName, Addr, Gend, Ema);

            //DisplayData ob = new DisplayData();
            //ob.GetData();


            Console.ReadLine();

        }
    }


}*/
using System;

namespace student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your Uid:\n ");
           // Uid = Console.ReadLine();
            Console.WriteLine("enter your Name:\n");
            Console.WriteLine("enter your sem\n");
            Console.WriteLine("enter your email\n");
            