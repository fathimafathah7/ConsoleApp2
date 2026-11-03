using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp2
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine(" student added");

        }
        public void ListStudents()
        {
            Console.WriteLine("Registered Students: ");

            foreach(Student student in students)
            {
                Console.WriteLine($"ID: {student.Id}");
                Console.WriteLine($"Name: {student.Name}");
                Console.WriteLine($"Age: {student.Age}");
                Console.WriteLine($"Couse ID: {student.CourseId}");
            }
        }

        //update student 

        public void UpdateStudent(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id == id);
            if(student==null)
            {
                Console.WriteLine("student not found");
                return;
            }
            Console.Write("enter new name: ");
            student.Name = Console.ReadLine() ?? "";
            Console.Write("enter new age: ");
            student.Age = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine("enter the course id: ");
            student.CourseId = int.Parse(Console.ReadLine() ?? "");

        }
        public void DeleteStudent(int id)
        {
            Student? student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                Console.WriteLine("student not found");
                return;
            }
            students.Remove(student);
            Console.WriteLine("student deleted");


        }
        public void FilterStudentsByAge(int age)
        {
            var result = students.Where(f => f.Age > age);
            Console.WriteLine($"Students older than {age}:");

            foreach(Student student in result)
            {
                Console.WriteLine(
                    $"Name: {student.Name} -Age {student.Age}");
            }

        }
        public void GetStudentsByCourse(int courseId)
        {
            var result = students.Where(s => s.CourseId == courseId);
            Console.WriteLine($"studentlist by course id: {courseId}");
            foreach (Student student in result)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Course: {student.CourseId}");
            }
        }
    }
}
