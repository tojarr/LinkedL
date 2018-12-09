using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedL
{
    class Student:Person
    {
        string NameStudent { get; set; }
        int AgeStudent { get; set; }

        public Student(string name, int age)
        {
            NameStudent = name;
            AgeStudent = age;
        }

        public override string ToString()
        {
            string text = "";

            text = string.Format("ID:{0} - Name:{1} - Age:{2}", IdPerson, NameStudent, AgeStudent);

            return text;
        }
    }
}
