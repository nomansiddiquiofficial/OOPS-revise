using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_revise
{
    internal class Employee1
    {
        public int empId;
        public string empName;
        public int empAge;

        private double grossPay;
        private static double taxes = 0.1 ;
        private double netsalary ;
       
        public static double salary = 40000;


        //Constructor
        public Employee1(int empId, string empName, int empAge, double grossPay)
        {
            this.empId = empId;
            this.empName = empName;
            this.empAge = empAge;
            this.grossPay = grossPay;


            Console.WriteLine("empId = {0}, empName= {1}, empAge = {2}, empSalary={3}, empGrossPAy = {4}", this.empId, this.empName, this.empAge, salary, this.grossPay);
        }
        //contructor 2 

        double calculateSalary()
        {
            if (this.grossPay > 30000) {
                double netSalary =  ( grossPay - taxes);
                return netSalary;

            }
            else
            {
                return this.netsalary;
            }
        }

        public void showEmployeeDetails()
        {
            double netsalary = this.calculateSalary();
            Console.WriteLine(netsalary);
        }


        
    }
}
