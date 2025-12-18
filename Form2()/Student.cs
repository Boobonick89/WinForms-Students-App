using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form2__
{
    internal class Student
    {
        public string Name { get; private set; }
        public string Group {  get; private set; }
        public int Age { get; private set; }

        public Student(string name, string group, int age)
        {
            Name = name;
            Group = group;
            Age = age;
        }

        public override string ToString()
        {
            return $"Имя {Name} Возраст {Age} Группа {Group}";
        }
    }
}
