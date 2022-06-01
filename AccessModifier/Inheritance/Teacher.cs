using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Inheritance
{
   class Teacher
    {
        int tid;
        string tname;
        string mobileNo;
       
        

        public Teacher()
        {

        }

    public Teacher(int tid,string tname,string mobileNo)
        {
           this. Tid = tid;
           this. tname = tname;
           this. mobileNo = mobileNo;
           
           }

        public int Tid { get => tid; set => tid = value; }
        public string Tname { get => tname; set => tname = value; }
        public string MobileNo { get => mobileNo; set => mobileNo = value; }
    }

    class HourlyBased :Teacher
    {
        int rate_per_hr;
        int hrs;

        public HourlyBased()
        {

        }
        public HourlyBased(int rate_per_hr, int hrs)
        {
         this.   Rate_per_hr = rate_per_hr;
         this.   Hrs = hrs;
        }

        public int Rate_per_hr { get => rate_per_hr; set => rate_per_hr = value; }
        public int Hrs { get => hrs; set => hrs = value; }

        public void salary(int rate_per_hr,int hrs)
        {
            int sal = rate_per_hr * hrs;
            Console.WriteLine("Salary for HourlyBased teacher"+sal);
        }
    }  
        class SalaryBased:Teacher
        {
             int salary;
             public SalaryBased()
               {

               }
        public SalaryBased(int salary)
        {
           this. Salary1 = salary;
        }

        public int Salary1 { get => salary; set => salary = value; }

        public void Salary(int salary)
        {
            Console.WriteLine("salary is "+salary);
        }
       

    }

    class TeacherTest
    {
        static void Main(string[] args)
        {
          

            HourlyBased hr = new HourlyBased();
            hr.salary(400,10);
            SalaryBased s1 = new SalaryBased();
            s1.Salary(40000);


           
           



        }

    }
}


