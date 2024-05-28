using SharedData;
using System.Linq;


namespace Filtering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            //// Query Syntex way
            //var resultQuery = from number in numbers where number < 5 select number;

            //foreach (var number in resultQuery)
            //{
            //    Console.WriteLine(number);
            //}

            //Console.WriteLine("========================================");
            //// Method Syntex way
            //var resultMethod = numbers.Where(number => number < 5);

            //foreach (var number in resultQuery)
            //{
            //    Console.WriteLine(number);
            //}


            var employees = Repository.LoadEmployees();

            //method syntex way
            var selectedEmps = employees.Where(x => x.Salary > 200000);
            selectedEmps.Print("Employees with salary > 200000");

            //Query syntex way
            var selectedEmps2 = from emp in employees where emp.Salary > 200000 select emp;
            Console.WriteLine("\n=====================================");
            selectedEmps2.Print("Employees with salary > 200000");
        }
    }
}
