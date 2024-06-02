using SharedData;

namespace ElementOperations
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ElementAtFunc();
            //ElementAtOrDefaultFunc();
            //FirstFunc();
            //FirstOrDefaultFunc();
            //LastFunc();
            //LastOrDefaultFunc();
            //SingleFunc();
            SingleOrDefaultFunc();
        }

        static void ElementAtFunc()
        {
            var employees = Repository.LoadEmployees();

            // if it's null it will return exception so better use elementatordefault or use it in try catch
            var emp = employees.ElementAt(10);

            var emp2 = employees.FirstOrDefault(x=>x.Id == 1010);
          
            Console.WriteLine(emp);
        }

        static void ElementAtOrDefaultFunc()
        {
            var employees = Repository.LoadEmployees(); 
            var emp = employees.ElementAtOrDefault(11);

            if(emp!=null)
                Console.WriteLine(emp);
            else
                Console.WriteLine("null value");
        }

        static void FirstFunc()
        {
            var employees = Repository.LoadEmployees();

            // it will return the first employee in repository
            var emp = employees.First();
            Console.WriteLine(emp);

            // you can put a condition and return the first employee meet the condition  
            // but null value will throw exception
            var emp2 = employees.First(x=>x.Salary > 300000);
            Console.WriteLine(emp2);

        }

        static void FirstOrDefaultFunc()
        {
            var employees = Repository.LoadEmployees();

            var emp2 = employees.FirstOrDefault(x => x.Salary > 300000);
            Console.WriteLine(emp2);
        }

        static void LastFunc()
        {
            var employees = Repository.LoadEmployees();

            // it will return the first employee in repository
            var emp = employees.Last();
            Console.WriteLine(emp);

            // you can put a condition and return the first employee meet the condition  
            // but null value will throw exception
            var emp2 = employees.Last(x => x.Salary > 300000);
            Console.WriteLine(emp2);
        }

        static void LastOrDefaultFunc()
        {
            var employees = Repository.LoadEmployees();

            var emp2 = employees.LastOrDefault(x => x.Salary > 300000);
            Console.WriteLine(emp2);
        }


        static void SingleFunc()
        {
            var employees = Repository.LoadEmployees();

            // must found a single unique value or it will throw exception
            var emp = employees.Single(x=>x.Id == 1005);
            Console.WriteLine(emp);
        }

        static void SingleOrDefaultFunc()
        {
            var employees = Repository.LoadEmployees();

            
            var emp = employees.SingleOrDefault(x => x.Id == 1005);
            Console.WriteLine(emp);
        }

    }
}
