using OOPS_revise;

namespace Revising {

    class Program
    {
        public static void Main()
        {
            //Student student = new Student();
            //student.Accept(2, "noman");
            //student.display();

            Employee emp = new Employee("A","B","C");
            Employee emp1 = new Employee(1, "B", 20);
            double salary = Employee.getSalary();
            
            Console.WriteLine("Salary: " + salary);
        }
    }
}
