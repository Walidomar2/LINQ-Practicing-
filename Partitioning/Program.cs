using SharedData;

namespace Partitioning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaginationFunc();

        }

        public static void SkipFunc()
        {
            var employee = Repository.LoadEmployees();

   
            var result = employee.Skip(10);

            result.Print("Skipping the first 10 employees");
        }
        public static void SkipWhileFunc()
        {
            var employee = Repository.LoadEmployees();

  
            var result = employee.SkipWhile(x=>x.Salary < 300000);

            result.Print("Skipping Employees with salary less than 300000");
        } 
        public static void SkipLastFunc()
        {
            var employee = Repository.LoadEmployees();

         
            var result = employee.SkipLast(10);

            result.Print("Skipping the Last 10 employees");
        }
         public static void TakeFunc()
        {
            var employee = Repository.LoadEmployees();

         
            var result = employee.Take(10);

            result.Print("Taking the First 10 employees");

            // and there is TakeLast();
            var resultLas = employee.TakeLast(10);
            resultLas.Print("Taking the Last 10 employees");
         }
         public static void ChunkFunc()
         {
            var employee = Repository.LoadEmployees();

       
            var result = employee.Chunk(5).ToList();

           for(int i = 0;i< result.Count; i++)
            {
                result[i].Print($"Chunk No: #{i + 1}");
            }

         }
         public static void PaginationFunc()
         {
            var employee = Repository.LoadEmployees();

            int pageNumber = 3;
            int pageSize = 10;

            var result = employee.Skip((pageNumber - 1)* pageSize).Take(pageSize);

            result.Print("Pagination in Page 3 with page size 10");
           

         }



    }
}
