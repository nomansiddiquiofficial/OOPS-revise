using OOPS_revise;
using System.ComponentModel.DataAnnotations;

namespace Revising {

    class Program
    {
        public static void Main()
        {
            Student student = new Student();
            student.Accept(2, "noman");
            student.display();

            Employee emp = new Employee(1, "noman", 22);
        }
    }
}
