using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask20
{
    internal class Student : Person
    {
        public bool isOnline;

        public Student(string _name, string _surname, int _age, bool _isOnline) : base(_name, _surname, _age)
        {
            isOnline = _isOnline;
        }
    }
}
