using System;

namespace OOPS_revise
{
    public class Employee
    {
        public int empId;
        public string empName;
        public int empAge;

        public Employee(int empId, string empName, int empAge)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;

            Console.WriteLine("empId = {0}, empName= {1}, empAge = {2} ", this.empId, this.empName, this.empAge);
        }

       
    }
}
