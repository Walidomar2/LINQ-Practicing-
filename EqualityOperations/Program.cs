using SharedData;

namespace EqualityOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SequenceEqualFunc2();
        }

        static void SequenceEqualFunc()
        {
            var employees = Repository.LoadEmployees();

            var empList_1 = employees.Where(x => x.Salary > 300000);
            var empList_2 = employees.Where(x => x.Salary > 300000);

            var equalityResult = empList_1.SequenceEqual(empList_2);

            Console.WriteLine($"Employee list#1 and Employee list#2 {(equalityResult?"are":"are not")} equal");

        }

        static void SequenceEqualFunc2()
        {
            var employees = Repository.LoadEmployees();

            var empList_1 = employees.Take(5);
            var empList_2 = employees.Take(5);

            var equalityResult = empList_1.SequenceEqual(empList_2);

            Console.WriteLine($"Employee list#1 and Employee list#2 {(equalityResult ? "are" : "are not")} equal");

        }


    }
}
