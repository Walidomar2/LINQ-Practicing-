using SharedData;

namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReverseFunc();
        }

        public static void orderByFunc()
        {
           var employees = Repository.LoadEmployees(); 
           var result = employees.OrderBy(x => x.Salary);

           result.Print(" Employees Ordered By salary ");

            // Query Syntax
            //var resultQ = from emp in employees
            //              orderby emp.Salary
            //              select emp;

            //resultQ.Print(" Employees Ordered By salary ");
        }

        public static void orderByDescFunc()
        {
            var employees = Repository.LoadEmployees();
            var result = employees.OrderByDescending(x => x.Salary);

            result.Print(" Employees Ordered By salary Descending");

            // Query Syntax
            //var resultQ = from emp in employees
            //              orderby emp.Salary Descending
            //              select emp;

            //resultQ.Print(" Employees Ordered By salary Descending");
        }

        public static void orderByThenFunc()
        {
            var employees = Repository.LoadEmployees();
            var result = employees.OrderBy(x => x.Salary).ThenBy(x => x.FirstName);

            result.Print(" Employees Ordered By salary ");
        }

        public static void ReverseFunc()
        {
            var employees = Repository.LoadEmployees();
            var result = employees.Reverse();

            result.Print("Employee in Reversed Order");
        }
    }
}
