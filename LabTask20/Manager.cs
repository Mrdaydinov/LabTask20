using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask20
{
    internal class Manager : Employee
    {
        public Manager(string name, bool isSuccessfull, decimal salary) : base(name, isSuccessfull, salary)
        {
            
        }

        public static void GetPromotion(Employee employee)
        {
            employee.Salary += 100;
        }

        public static void GetMinusPromotion(Employee employee)
        {
            employee.Salary -= 50;
        }
    }
}
