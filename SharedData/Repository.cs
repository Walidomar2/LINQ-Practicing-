using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedData
{
    public static class Repository
    {
        public static IEnumerable<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee
                {
                        Id = 1001,
                        FirstName = "Cochran",
                        LastName = "Cole",
                        HireDate = new DateTime(2017, 11, 2),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 103200m,
                        Skills = new() {"ASP.NET" , "CSS" , "Oracle"}
                },
                new Employee
                {
                        Id = 1002,
                        FirstName = "Jaclyn",
                        LastName = "Wolfe",
                        HireDate = new DateTime(2018, 4, 14),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 192400m,
                        Skills = new() {"ASP.NET" , "SQL Server" , "Javascript" , "CSS" , "HTML"}
                },
                new Employee
                {
                        Id = 1003,
                        FirstName = "Warner",
                        LastName = "Jones",
                        HireDate = new DateTime(2016, 12, 13),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 172800m,
                        Skills = new() {"HTML" , "Oracle" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1004,
                        FirstName = "Hester",
                        LastName = "Evans",
                        HireDate = new DateTime(2016, 8, 17),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 155500m,
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1005,
                        FirstName = "Wallace",
                        LastName = "Buck",
                        HireDate = new DateTime(2014, 5, 12),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 315800m,
                        Skills = new() {"C++" , "ASP.NET" , "C#" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1006,
                        FirstName = "Acevedo",
                        LastName = "Wall",
                        HireDate = new DateTime(2020, 10, 30),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 343700m,
                        Skills = new() {"C++" , "SQL Server" , "CSS" , "HTML"}
           
                },
                new Employee
                {
                        Id = 1007,
                        FirstName = "Jacqueline",
                        LastName = "Pickett",
                        HireDate = new DateTime(2021, 2, 17),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = false,
                        Salary = 370000m,
                        Skills = new() {"SQL Server" , "CSS" , "C++" , "Javascript" , "C#"}
                },
                new Employee
                {
                        Id = 1008,
                        FirstName = "Oconnor",
                        LastName = "Espinoza",
                        HireDate = new DateTime(2017, 3, 12),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 155600m,
                        Skills = new() {"NodeJS" , "Oracle"}
                },
                new Employee
                {
                        Id = 1009,
                        FirstName = "Allie",
                        LastName = "Elliott",
                        HireDate = new DateTime(2020, 4, 20),
                        Gender = "female",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 315400m,
                        Skills = new() {"ASP.NET" , "C#"}
                },
                new Employee
                {
                        Id = 1010,
                        FirstName = "Elva",
                        LastName = "Decker",
                        HireDate = new DateTime(2016, 9, 6),
                        Gender = "female",
                        Department = "HR",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 345900m,
                        Skills = new() {"HTML" , "C#" , "SQL Server" , "Javascript"}
                },
                new Employee
                {
                        Id = 1011,
                        FirstName = "Hayes",
                        LastName = "Beasley",
                        HireDate = new DateTime(2020, 4, 25),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 372700m,
                        Skills = new() {"ASP.NET"}
                },
                new Employee
                {
                        Id = 1012,
                        FirstName = "Florine",
                        LastName = "Cervantes",
                        HireDate = new DateTime(2015, 3, 25),
                        Gender = "female",
                        Department = "FIMAMCE",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 338700m,
                        Skills = new() {"C#" , "Oracle" , "Javascript"}
                },
                new Employee
                {
                        Id = 1013,
                        FirstName = "Bullock",
                        LastName = "Carney",
                        HireDate = new DateTime(2017, 1, 3),
                        Gender = "male",
                        Department = "Accounting",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 214400m,
                        Skills = new() {"CSS" , "NodeJS" , "Javascript"}
                },
                new Employee
                {
                        Id = 1014,
                        FirstName = "Carroll",
                        LastName = "Cantu",
                        HireDate = new DateTime(2021, 5, 26),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 343200m,
                        Skills = new() {"C#" , "C++" , "PHP"}
                },
                new Employee
                {
                        Id = 1015,
                        FirstName = "Debra",
                        LastName = "Hogan",
                        HireDate = new DateTime(2019, 10, 4),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 249100m,
                        Skills = new() {"C++" , "ASP.NET" , "NodeJS" , "Oracle"}
                },
                new Employee
                {
                        Id = 1016,
                        FirstName = "Winnie",
                        LastName = "Mccall",
                        HireDate = new DateTime(2019, 7, 17),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 287300m,
                        Skills = new() {"SQL Server" , "C++" , "NodeJS"}
                },
                new Employee
                {
                        Id = 1017,
                        FirstName = "Manuela",
                        LastName = "Berger",
                        HireDate = new DateTime(2015, 12, 11),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 172500m,
                        Skills = new() {"HTML" , "C#"}
                },
                new Employee
                {
                        Id = 1018,
                        FirstName = "Lakeisha",
                        LastName = "Lowe",
                        HireDate = new DateTime(2017, 1, 18),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 314300m,
                        Skills = new() {"C++" , "CSS" , "ASP.NET" , "SQL Server"}
                },
                new Employee
                {
                        Id = 1019,
                        FirstName = "Stewart",
                        LastName = "Lott",
                        HireDate = new DateTime(2016, 12, 12),
                        Gender = "male",
                        Department = "FIMAMCE",
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        Salary = 146600m,
                        Skills = new() {"CSS", "HTML", "Javascript", "PHP"}
                },
                new Employee
                {
                        Id = 1020,
                        FirstName = "Stafford",
                        LastName = "Peck",
                        HireDate = new DateTime(2014, 9, 25),
                        Gender = "male",
                        Department = "IT",
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        Salary = 320700m,
                        Skills = new() {"C++" , "CSS" , "ASP.NET"}
                },
                new Employee
                {
                        Id = 1021,
                        FirstName = "Barron",
                        LastName = "Bird",
                        HireDate = new DateTime(2020, 5, 18),
                        Gender = "male",
                        Department = "HR",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 151200m,
                        Skills = new() {"C++" , "HTML" , "ASP.NET" , "Javascript"}
                },
                new Employee
                {
                        Id = 1022,
                        FirstName = "Nona",
                        LastName = "Brooks",
                        HireDate = new DateTime(2015, 12, 4),
                        Gender = "female",
                        Department = "IT",
                        HasHealthInsurance = false,
                        HasPensionPlan = true,
                        Salary = 136500m,
                        Skills = new() {"CSS"}
                },
                   new Employee
                {
                    Id = 1023,
                    FirstName = "Clara",
                    LastName = "Reeves",
                    HireDate = new DateTime(2014, 12, 6),
                    Gender = "female",
                    Department = "IT",
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                    Salary = 245800m,
                    Skills = new() {"Javascript" , "Oracle" , "ASP.NET" , "CSS"}
                },
                new Employee
                {
                    Id = 1024,
                    FirstName = "Karin",
                    LastName = "Blanchard",
                    HireDate = new DateTime(2018, 1, 20),
                    Gender = "female",
                    Department = "IT",
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                    Salary = 341200m,
                    Skills = new() {"Python", "SQL", "React", "Node.js"}
                },
                new Employee
                {
                    Id = 1025,
                    FirstName = "Burris",
                    LastName = "Morgan",
                    HireDate = new DateTime(2019, 7, 6),
                    Gender = "male",
                    Department = "Accounting",
                    HasHealthInsurance = false,
                    HasPensionPlan = false,
                    Salary = 360300m,
                    Skills = new() {"Excel", "QuickBooks", "Financial Analysis"}
                },
                new Employee
                {
                    Id = 1026,
                    FirstName = "Owen",
                    LastName = "Cortez",
                    HireDate = new DateTime(2021, 12, 9),
                    Gender = "male",
                    Department = "IT",
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                    Salary = 193700m,
                    Skills = new() {"C#", "AWS", "Docker", "Angular"}
                },
                new Employee
                {
                    Id = 1027,
                    FirstName = "Letha",
                    LastName = "Finch",
                    HireDate = new DateTime(2016, 12, 18),
                    Gender = "female",
                    Department = "Accounting",
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                    Salary = 357200m,
                    Skills = new() {"Accounting", "Tax Preparation", "Financial Reporting"}
                },
                new Employee
                {
                    Id = 1028,
                    FirstName = "Sondra",
                    LastName = "Rojas",
                    HireDate = new DateTime(2016, 4, 22),
                    Gender = "female",
                    Department = "Accounting",
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                    Salary = 309700m,
                    Skills = new() {"Bookkeeping", "Payroll", "Financial Analysis"}
                },
                new Employee
                {
                    Id = 1029,
                    FirstName = "Hoover",
                    LastName = "Cook",
                    HireDate = new DateTime(2020, 12, 17),
                    Gender = "male",
                    Department = "HR",
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                    Salary = 282200m,
                    Skills = new() {"Recruiting", "Employee Relations", "HR Policies"}
                },
                new Employee
                {
                    Id = 1030,
                    FirstName = "Wanda",
                    LastName = "Bender",
                    HireDate = new DateTime(2021, 6, 17),
                    Gender = "female",
                    Department = "Accounting",
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                    Salary = 294200m,
                    Skills = new() {"Auditing", "Tax Compliance", "Financial Planning"}
                },
                new Employee
                {
                    Id = 1031,
                    FirstName = "Sanford",
                    LastName = "Craig",
                    HireDate = new DateTime(2020, 2, 27),
                    Gender = "male",
                    Department = "Accounting",
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                    Salary = 278200m,
                    Skills = new() {"Cost Accounting", "Budgeting", "Accounts Receivable"}
                },
                new Employee
                {
                    Id = 1032,
                    FirstName = "Christy",
                    LastName = "Middleton",
                    HireDate = new DateTime(2021, 4, 2),
                    Gender = "female",
                    Department = "FIMAMCE",
                    HasHealthInsurance = false,
                    HasPensionPlan = false,
                    Salary = 377400m,
                    Skills = new() {"Project Management", "Risk Assessment", "Financial Modeling"}
                },
                new Employee
                {
                    Id = 1033,
                    FirstName = "Day",
                    LastName = "Brady",
                    HireDate = new DateTime(2019, 1, 23),
                    Gender = "male",
                    Department = "HR",
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                    Salary = 142600m,
                    Skills = new() {"Training & Development", "Compensation & Benefits", "HR Software"}
                },
                new Employee
                {
                    Id = 1034,
                    FirstName = "Powers",
                    LastName = "Beard",
                    HireDate = new DateTime(2014, 4, 25),
                    Gender = "male",
                    Department = "FIMAMCE",
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                    Salary = 224000m,
                    Skills = new() {"Market Analysis", "Investment Strategies", "Financial Forecasting"}
                },
                new Employee
                {
                    Id = 1035,
                    FirstName = "Arline",
                    LastName = "Pratt",
                    HireDate = new DateTime(2017, 8, 12),
                    Gender = "female",
                    Department = "FIMAMCE",
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                    Salary = 360300m,
                    Skills = new() {"Financial Analysis", "Portfolio Management", "Risk Management"}
                },
                new Employee
                {
                    Id = 1036,
                    FirstName = "Sharpe",
                    LastName = "Cardenas",
                    HireDate = new DateTime(2017, 11, 28),
                    Gender = "male",
                    Department = "Accounting",
                    HasHealthInsurance = false,
                    HasPensionPlan = true,
                    Salary = 266100m,
                    Skills = new() {"Accounts Payable", "Tax Preparation", "Financial Reporting"}
                },
                new Employee
                {
                    Id = 1037,
                    FirstName = "Madeleine",
                    LastName = "Stanton",
                    HireDate = new DateTime(2020, 7, 17),
                    Gender = "female",
                    Department = "Accounting",
                    HasHealthInsurance = true,
                    HasPensionPlan = true,
                    Salary = 198300m,
                    Skills = new() {"General Ledger", "Payroll", "Financial Analysis"}
                },
                new Employee
                {
                    Id = 1038,
                    FirstName = "Spears",
                    LastName = "Noble",
                    HireDate = new DateTime(2014, 10, 6),
                    Gender = "male",
                    Department = "FIMAMCE",
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                    Salary = 176300m,
                    Skills = new() {"Financial Planning", "Investment Management", "Market Research"}
                }
          };
        }
    }
}
