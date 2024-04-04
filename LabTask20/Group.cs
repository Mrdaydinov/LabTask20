using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask20
{
    internal class Group
    {
        public string groupName;
        public Student[] students;

        public Group(string _groupName, Student[] _students)
        {
            groupName = _groupName;
            students = _students;
        }

        public void GetAll()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"Name = {student.name}, Surname = {student.surname}");
            }
        }

        public void GetOnlineStudents()
        {
            foreach (Student student in students)
            {
                if (student.isOnline)
                {
                    Console.WriteLine($"Name = {student.name}, Surname = {student.surname}");
                }
            }
        }

        public void GetOfflineStudents()
        {
            foreach(Student student in students)
            {
                if (!student.isOnline)
                {
                    Console.WriteLine($"Name = {student.name}, Surname = {student.surname}");
                }
            }
        }
    }
}
