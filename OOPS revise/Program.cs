
namespace OOPS_revise
{

    class Program
    {
        public static void Main()
        {
            //Student student = new Student();
            //student.Accept(2, "noman");
            //student.display();

            //Employee emp = new Employee("A","B","C");
            //Employee emp1 = new Employee(1, "B", 20);
            //double salary = Employee.getSalary();

            //Console.WriteLine("Salary: " + salary);

            //Myltileve12 inheritance = new Myltileve12();
            //inheritance.mul21();
            //inheritance.add();



            Account account = new Account();
            account.setdepositMoney(1000);
            Console.WriteLine();
            double balance = account.getDepositMoney();
            Console.WriteLine(balance);


        }
    }
}
