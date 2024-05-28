using SharedData;
using System.Drawing;
using System.Linq;

namespace Projection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1) Select
            //SelectFunc();

            // 2) Select Many
            SelectManyFunc();

        }

        public static void SelectFunc()
        {
            var employees = Repository.LoadEmployees();

            var result = employees.Select(x => new {
                x.Id,
                Skills = string.Join(", ", x.Skills)
            });


            result.Print("Id + skills");
        }

        public static void SelectManyFunc()
        {
            var employees = Repository.LoadEmployees();

            // you can remove Distinct
            var result = employees.SelectMany(x => x.Skills ).Distinct();

            result.Print("skills");

            //Query Syntex
            //var result2 = from emp in employees
            //              from skill in emp.Skills
            //              select skill;

            //result2.Print("skills");
        }

        public static void ZipFunc()
        {
            string[] colorName = { "Red", "Green", "Blue" };
            string[] colorHEX = { "FF0000", "00FF00", "0000FF", "extra" };

            var colors = colorName.Zip(colorHEX, (name, hex) => $"{name} ({hex})");

            foreach (var color in colors)
                Console.WriteLine(color);
        }





    }
}
