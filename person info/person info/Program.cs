using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace person_info
{
    class person
    {
        private string fname;
        private string lname;
        private string emailadd;
        private DateTime dob;
       
        public person()
            {
            }
        

        public person(string fname, string lname, string emailadd, DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.emailadd = emailadd;
            this.dob = dob;
        }

        public person(string fname, string lname, string emailadd)
        {
            this.fname = fname;
            this.lname = lname;
            this.emailadd = emailadd;

        }

        public person(string fname, string lname, DateTime dob)
        {
            this.fname = fname;
            this.lname = lname;
            this.dob = dob;
        }

        //public string DOB { get => dob.ToString(); set => dob = new DateTime(Convert.ToInt32(value.Substring(0,4)),Convert.ToInt32(value.Substring(4,2)), Convert.ToInt32(value.Substring(6,2)); }
        public DateTime DOB { get => dob; set => dob = value; }
        public string EmailAddress { get => emailadd; set => emailadd = value; }

        public string LastName { get => lname; set => lname = value; }

        public string FirstName { get => fname; set => fname = value; }

        public bool adult
        {
            get
            {
                if ((DateTime.Today.Year - dob.Year) >= 18)
                    return true;
                else
                    return false;
            }
        }

        public string sunsign
        {
            get
            {
                switch (dob.Month)
                {
                    case 1:
                        if (dob.Day <= 19)
                        {
                            return "Capricorn";
                        }
                        else
                            return "sagittarius";


                    case 2:
                        if (dob.Day <= 19)
                        {
                            return "capricornus";
                        }
                        else
                            return "Aquarius";


                    case 3:
                        if (dob.Day <= 19)
                        {
                            return "Aquarius";
                        }
                        else
                            return "pisces";

                    case 4:
                        if (dob.Day <= 19)
                        {
                            return "pisces";
                        }
                        else
                            return "Aries";
                    case 5:
                        if (dob.Day <= 19)
                        {
                            return "Aries";
                        }
                        else
                            return "Taurus";
                    case 6:
                        if (dob.Day <= 19)
                        {
                            return "Taurus";
                        }
                        else
                            return "Gemini";

                    case 7:
                        if (dob.Day <= 19)
                        {
                            return "Gemini";
                        }
                        else
                            return "Cancer";

                    case 8:
                        if (dob.Day <= 19)
                        {
                            return "Cancer";
                        }
                        else
                            return "Leo";

                    case 9:
                        if (dob.Day <= 19)
                        {
                            return "Leo";
                        }
                        else
                            return "Virgo";

                    case 10:
                        if (dob.Day <= 19)
                        {
                            return "Virgo";
                        }
                        else
                            return "Libra";

                    case 11:
                        if (dob.Day <= 19)
                        {
                            return "Libra";
                        }
                        else
                            return "Scorpius";

                    case 12:
                        if (dob.Day <= 19)
                        {
                            return "Ophiuchus";
                        }
                        else
                            return "Sagittarius";


                    default: return "null";

                }
            }
        }

        public bool birthday
        {
            get
            {
                if ((dob.Month == DateTime.Today.Month) && (dob.Day == DateTime.Today.Day))
                    return true;

                else
                    return false;
            }

        }

        public string ScreenName
        {
            get
            {
                string screenname;
                screenname = fname.Substring(0, 4) + dob.Month.ToString();
                return screenname;
            }
        }
    }

   interface Ipayable
    {
        double RetriveDueAmount();
        void AddToDueAmount(int dueamount);
        void Payamount(string address);

    }

    class Employee : person, Ipayable
    {
        private double salary;
        private string mailingaddress;
        private double dueamount;

        public Employee()
        {
            dueamount = 0.0;
        }

        public Employee(string fname, string lname, string email, double salary, double dueamount, string mailingadd)
        {
            base.FirstName = fname;
            base.LastName = lname;
            base.EmailAddress = email;
            this.Salary = salary;
            this.dueamount = dueamount;
            this.Mailingaddress = mailingadd;
        }
            
        public string Mailingaddress { get => mailingaddress; set => mailingaddress = value; }
        public double Salary { get =>(salary-dueamount); set => salary = value; }

        public void AddToDueAmount(int dueamount)
        {
            
            this.dueamount += dueamount;
        }

        public void Payamount(string address)
        {
            this.mailingaddress = address;
        }

        public double RetriveDueAmount()
        {
            return dueamount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          /*  string fname, lname, email, dob;

            Console.WriteLine("enter first name:");
            fname= Console.ReadLine();

            Console.WriteLine("enter last name:");
            lname = Console.ReadLine();
                       Console.WriteLine("enter email:");
            email = Console.ReadLine();

            Console.WriteLine("enter dob y-m-d:");
            dob = Console.ReadLine();

            DateTime dt = new DateTime(Convert.ToInt32(dob.Substring(0, 4)), Convert.ToInt32(dob.Substring(4, 2)), Convert.ToInt32(dob.Substring(6, 2)));

             person p1 = new person(fname, lname, email, dt);
             Console.WriteLine("the person is an adult ?:" + p1.adult);
             Console.WriteLine("the sunsign:" + p1.sunsign);
             Console.WriteLine("today is your birthday ?:" + p1.birthday);
             Console.WriteLine("the allotted screenname:" + p1.ScreenName);*/

            //employee class related
            Employee e1 = new Employee("teju","gowda","teju@gmail.com",500000,2411,"doddaballapur");
            Console.WriteLine("salary:" + e1.Salary);
            Console.WriteLine(e1.ScreenName);
            Console.WriteLine(e1.Mailingaddress);
          
            Console.ReadLine();
            
        }
    }
}

