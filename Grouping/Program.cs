using SharedData;

namespace Grouping
{

    /*
     * GroupBy:  uses deferred execution
     *           each iterate makes group again
     *           IEnumerable<IGrouping<TKey, TSource>>
     * 
     * ToLookUp: uses immediate execution
     *           buffer the result in memory 
     *           ILookUp<TKey, TSource>
     */

    internal class Program
    {
        static void Main(string[] args)
        {
            GroupByFunc();
        }

        public static void GroupByFunc()
        {
            var employees = Repository.LoadEmployees();
            var groups = employees.GroupBy(x => x.Department);

            foreach ( var group in groups ) 
            {
                group.Print($"Employees In {group.Key} Department");
            }

            //Query Syntax
            //var groupsQuery = from emp in employees
            //                  group emp by emp.Department;

        }

        public static void ToLookUpFunc()
        {
            var employees = Repository.LoadEmployees();
            var groups = employees.ToLookup(x => x.Department);

            foreach (var group in groups)
            {
                group.Print($"Employees In {group.Key} Department");
            }

        }
    }
}
