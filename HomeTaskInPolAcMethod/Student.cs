using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskInPolAcMethod
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int[] Grades { get; set; }=new int[0];

        public Student(string name, string surname, int age, int[] grades)
        {
            Name = name;
            Surname = surname;
            Age = age;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] % 2 == 0)
                {
                    Grades = Grades.Append(grades[i]).ToArray();
                }
            }
            
        }
        public void GetInfo(Student student)
        {
            Console.WriteLine(student.Name + " " + student.Surname + " " + student.Age);
            foreach (var item in student.Grades)
            {
                Console.Write(item + ", ");
            }
        }
    }
}
