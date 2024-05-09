using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_revise
{
    internal class Student
    {
        private int rollNumber;
        private string name;

        public void Accept(int rollno, string name)
        {
            this.rollNumber = rollno;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("the name is {0} and roll no is: {1}", this.rollNumber, this.name);
        }
    }
}
