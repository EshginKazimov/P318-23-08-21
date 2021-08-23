using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Student
    {
        public int Id { get; }
        public string Name { get; }
        public string Surname { get; }
        public int Age { get; }

        private static int _id = 0;

        public Student(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
            _id++;
            Id = _id;
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return $"{Id} {Name} {Surname} {Age}";
        }
    }
}
