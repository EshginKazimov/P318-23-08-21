using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Group
    {
        public string Name { get; }

        public List<Student> Students { get; }

        public Group(string name)
        {
            Name = name;
            Students = new List<Student>();
        }

        public void AddToGroup(Student student)
        {
            Students.Add(student);
        }

        public void RemoveInGroup(Student student)
        {
            Students.Remove(student);
        }

        public void UpdateStudent(int index, Student student)
        {
            Students[index] = student;
        }

        public void ShowStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine(student);
            }
        }

        public Student FindById(int id)
        {
            foreach (Student student in Students)
            {
                if (id == student.Id)
                {
                    return student;
                }
            }

            return null;
        }

        public Student FindBy(Predicate<Student> predicate)
        {
            foreach (Student student in Students)
            {
                if (predicate(student))
                {
                    return student;
                }
            }

            return null;
        }

        public void RemoveById(int id)
        {
            //List<Student> newStudents = new List<Student>(Students);
            foreach (Student student in Students.ToList())
            {
                if (id == student.Id)
                {
                    Students.Remove(student);
                }
            }
        }
    }
}
