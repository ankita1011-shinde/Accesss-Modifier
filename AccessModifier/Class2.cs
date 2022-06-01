using System;
using P1;


namespace P2
{
    internal class A
    {
        public void Add()
        {
            Console.WriteLine("in M1");
        }

        static void Main(string[] args)
        {
            CC c1 = new CC();
            c1.M2();

        }
    }
}
