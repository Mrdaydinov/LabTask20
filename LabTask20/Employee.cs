using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask20
{
    internal class Employee
    {
        public string Name { get; set; }
        public bool IsSuccessfull { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, bool isSuccessfull, decimal salary)
        {
            Name = name;
            IsSuccessfull = isSuccessfull;
            Salary = salary;
        }
    }
}
