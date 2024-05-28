using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedData
{
    public class Employee
    {
        public Employee()
        {
        }


        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        public List<string> Skills { get; set; } = new List<string>();

        public string Gender { get; set; }

        public string Department { get; set; }

        public bool HasHealthInsurance { get; set; }

        public bool HasPensionPlan { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return string.Format(
                                 "ID: {0}\n" +
                                 "Name: {1}\n" +
                                 "Hire Date: {2}\n" +
                                 "Gender: {3}\n" +
                                 "Department: {4}\n" +
                                 "Has Health Insurance: {5}\n" +
                                 "Has Pension Plan: {6}\n" +
                                 "Salary: ${7}\n" +
                                 "Skills: {8}",
                                 Id,
                                 $"{LastName}, {FirstName}".PadRight(15, ' '),
                                 HireDate.Date.ToShortDateString(),
                                 Gender.PadRight(10, ' '),
                                 Department.PadRight(10, ' '),
                                 HasHealthInsurance,
                                 HasPensionPlan,
                                 Salary.ToString("0.00"),
                                 string.Join(", ", Skills)
                             );
        }
    }
}
