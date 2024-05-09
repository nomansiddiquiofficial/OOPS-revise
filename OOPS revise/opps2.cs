using System;

namespace OOPS_revise
{
  
    public class Employee
    {
        public int empId;
        public string empName;
        public int empAge;
        public static double salary = 40000;


        //Constructor
        public Employee(int empId, string empName, int empAge)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;


            Console.WriteLine("empId = {0}, empName= {1}, empAge = {2}, empSalary={3}", this.empId, this.empName, this.empAge, salary) ;
        }
        //contructor 2 
       public Employee(int a, int b) {
            Console.WriteLine("this is a Second constructor: {0}, {1}", a ,b);
        }

        //contructor 3
        public  Employee(string a, string b, string c)
        {
            Console.WriteLine("This is a third constructor !! {0}", a + b + c);
        }

        //static method
        public static double getSalary()
        {
            return salary;
        }

    }
}
