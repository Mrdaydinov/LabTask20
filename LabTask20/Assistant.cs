using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask20
{
    internal class Assistant : Employee
    {
        public Assistant(string name, bool isSuccessfull, decimal salary) : base(name, isSuccessfull, salary)
        {
            
        }

        public void GetFeedBack(Employee employee)
        {
            if(employee.IsSuccessfull)
            {
                Manager.GetPromotion(employee);
            }
            else
                Manager.GetMinusPromotion(employee);
        }
    }
}
