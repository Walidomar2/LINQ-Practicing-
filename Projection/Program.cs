using SharedData;

namespace Projection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = Repository.LoadEmployees();
            employees.Print("All");

        }
    }
}
