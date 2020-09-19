
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace studentdetails
{
    class details
    {
       // private static bool isCorrect;

        public static void Main(string[] args)
        {
            string userinput;
            string Uid;
            string Name;
            int Sem;
            string Email;

            Console.Write("Enter Uid: ");
            userinput = Console.ReadLine();
            Uid = Convert.ToString(userinput);
            Console.WriteLine("You entered Uid :{0}", Uid);

            Console.Write("Enter Name: ");
            userinput = Console.ReadLine();
            Name = Convert.ToString(userinput);
            Console.WriteLine("You entered Name: {0}", Name);

            try
            {

                Console.Write("Enter Sem: ");
                userinput = Console.ReadLine();
                Sem = Convert.ToInt32(userinput);
                Console.WriteLine("You entered Sem: {0}", Sem);
            }
            catch
            {
                Console.WriteLine("invalid input!! try again");
            }



            try
            {

                Console.Write("Enter Email: ");
                userinput = Console.ReadLine();
                Email = Convert.ToString(userinput);
                bool isCorrect = Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'+/=?^_`{|}~-]+)@(?:[a-z0-9](?:[a-z0-9-][a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                Console.WriteLine("You entered Email: {0}", Email);

            }
            catch (Exception)
            {
                Console.WriteLine("invalid!!" + "try again");
            }

            Console.ReadLine();
        }
    }
}

                






















/*using System;
using System.Threading;

public class Details
{
    public void Readdata(string Uid, string Name, int Sem, string Email)
    {
        Console.WriteLine("Ur uid:" + Uid + "!");
        Console.WriteLine("Ur name:" + Name + " !");
        Console.WriteLine("ur sem:" + Sem + "!");
        Console.WriteLine("ur email:" + Email + "!");
    }

     public static void HaveAnice()
   {
       Console.WriteLine("Have a nice day!");
   }

   public static void Main(string[] args)
   {


       string myUid;
       string myName;
       int mySem;
       string myEmail;

       Console.Write("Enter Uid: ");
       myUid = Console.ReadLine();
        Readdata(myUid);

       Console.Write("Enter Name: ");
       myName = Console.ReadLine();
        Readdata(myName);

       try
       {

           Console.Write("Enter Sem: ");
           mySem = Convert.ToInt32(Console.ReadLine());
            Readdata(mySem);

       }
       catch
       {
           Console.WriteLine("invalid input!! try again");
       }


       try
       {

           Console.Write("Enter Email: ");
           myEmail = Console.ReadLine();
            Readdata(myEmail);


       }


       catch (Exception)
       {
           Console.WriteLine("invalid email");
           Console.WriteLine("try again");
       }


       HaveAnice();


       Console.ReadLine();
   }

    private static void Readdata(int mySem)
    {
       
    }

    private static void Readdata(string myName)
    {
        
    }
}

*/