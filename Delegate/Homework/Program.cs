using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Group g1 = new Group("P318");

            Student student1 = new Student("Vugar", "Rustamov", 39);
            Student student2 = new Student("Rail", "Cennetov", 24);

            g1.AddToGroup(student1);
            g1.AddToGroup(student2);
            //g1.ShowStudents();

            //Student foundStudent = g1.FindById(3);
            //if (foundStudent == null)
            //    Console.WriteLine("Bele id-de student yoxdur.");
            //else
            //    Console.WriteLine(foundStudent);

            //g1.RemoveById(1);
            //g1.ShowStudents();

            //Console.WriteLine(g1.Students.Exists(x => x.Name == "Ulvi"));

            //Console.WriteLine(g1.FindBy(x => x.Name == "Vugar"));
            //Console.WriteLine(g1.FindBy(x => x.Id == 2).Name);
            //Console.WriteLine(g1.FindBy(x => x.Surname == "Rustamov"));


            //Student foundStudent = g1.FindBy(x => x.Name.StartsWith('U'));
            //Student foundStudent = g1.FindBy(x => x.Name.StartsWith("Ra"));
            Student foundStudent = g1.FindBy(x => x.Name.Contains("aia"));
            if (foundStudent == null)
                Console.WriteLine("Bele id-de student yoxdur.");
            else
                Console.WriteLine(foundStudent);
        }
    }
}
