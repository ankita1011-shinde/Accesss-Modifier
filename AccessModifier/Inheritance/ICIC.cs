using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier.Inheritance
{
    //Inheritance
    class SuperBank
    {
       
      public SuperBank()
        {
            Console.WriteLine("using constructor");
            Console.WriteLine("This is Superbank");
        }
        public void m1()
        {
            Console.WriteLine("in m1");
        }
    }
    class Bank:SuperBank
    {
        int accno;
        string name;

        public Bank( )
        {
            Console.WriteLine("In Bank");
        }
        public Bank(int accno, string name)
        {
            accno = accno;
            this.name = name;
        }
        public void withdraw()
        {
            
            Console.WriteLine("in withdraw");
        }

        public void deposit()
        {
            Console.WriteLine("in deposit");
        }
    }

    class ICIC:Bank
    {
        public ICIC()
        {
            Console.WriteLine("in ICIC ");
        }
        static void Main(string[] args)
        {
            ICIC i= new ICIC();
            Console.WriteLine("using method calling");
            i.deposit();
            i.m1();
            i.withdraw();

            

        }

    }
}
