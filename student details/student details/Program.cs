
using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace studentdetails
{
    class details
    {
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

            Console.Write("Enter Email: ");
            userinput = Console.ReadLine();
            Email = Convert.ToString(userinput);
            if (IsValidEmail(Email))
            {
                Console.WriteLine("valid email address");
            }
            else
                Console.WriteLine("invalid email address");
            Console.ReadLine();
        }

            public static bool IsValidEmail(string email)
            {
                if (string.IsNullOrWhiteSpace(email))
                    return false;

                if (Regex.IsMatch(email,
                        @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                        RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
                {
                    return true;
                }
                else
                    return false;


              
            }
        }
    }


            






















