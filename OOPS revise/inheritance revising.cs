using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_revise
{
    internal class Parent
    {
        public void Par1()
        {
            Console.WriteLine("pa1");
        }
        public void Par2()
        {
            Console.WriteLine("pa2");
        }
        //method ovverriding 
        public virtual void add()
        {
            Console.WriteLine("Parent Class add method");
        }
                


    }
    internal class Multilevel1:Parent
    {
        public void mut11()
        {
            Console.WriteLine("mu1");
        }
        public void mul12()
        {
            Console.WriteLine("mul1->2");
        }


    }

    internal class Myltileve12:Multilevel1
    {
        public void mul21()
        {
            Console.WriteLine("mu2->1");
        }
        public void mul22()
        {
            Console.WriteLine("mu2->2");
        }

        //method ovverriding
        public override void add()
        {
            base.add();

            Console.WriteLine("multilevel2 Class add method");
        }

    }

}
