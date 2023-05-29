using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_To_Objects
{
    public class Employee
    {
        public int Eno { get; set; }
        public string EName { get; set; }

        public string job { get; set; }

        public static List<Employee> GetDetails()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Eno = 1, EName = "Rohit", job = "SDE" },
                new Employee { Eno = 2, EName = "Ravi", job = "Footballer" },
                new Employee { Eno = 3, EName = "Pavan", job = "SDE" },
                new Employee { Eno = 4, EName = "Rahane", job = "Cricketer" }
            };
            return employees;
        }
    }
}
