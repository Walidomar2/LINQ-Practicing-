using SharedData;

namespace Quantifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // AnyFunc();
            AllFunc();
        }

        public static void AnyFunc()
        {
            /*
             * Any => it just check the items if any item met the condition u spicify or not
             * it return(true/false) and it stop checking when find the first item that meets the condition
             */
            var employees = Repository.LoadEmployees();

            //check if any employess named jac
            var result = employees.Any(x => x.FirstName.Equals("warner", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine($"any employess named Warner? {result}");

            var salaryResult = employees.Any(x => x.Salary < 20000);
            Console.WriteLine($"any employee has salary less than 20000? {salaryResult}");
        }

        public static void AllFunc()
        {
            /*
            * Any => it just check the items if All items met the condition u spicify or not
            * it return(true/false) and it stop checking when find the first item that meets the condition
            */

            var employees = Repository.LoadEmployees();

            var salaryResult = employees.All(x => x.Salary > 20000);
            Console.WriteLine($"Is All Employees take salary more than 20000? {salaryResult}");

            var skillResult = employees.All(x => x.Skills.Count > 2 );
            Console.WriteLine($"Is All Employees has Skills more than 2 skills? {skillResult}");

            var skillResult2 = employees.All(x => x.Skills.Any(s => s == "C#"));
            Console.WriteLine($"Is All Employees has C# Skill? {skillResult2}");

        }
    }
}
