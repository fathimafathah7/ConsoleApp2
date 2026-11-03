
using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            StudentManager studentManager = new StudentManager();
            CourseManager courseManager = new CourseManager();

            
            courseManager.AddCourse(new Course
            {
                CourseId = 101,
                CourseName = "C#"
            });

            courseManager.AddCourse(new Course
            {
                CourseId = 102,
                CourseName = "Angular \n"
            });

            
            Console.WriteLine("\n--- COURSE LIST ---");
            courseManager.ListCourses();

            
            studentManager.AddStudent(new Student
            {
                Id = 1,
                Name = "Ali",
                Age = 22,
                CourseId = 101
            });

            studentManager.AddStudent(new Student
            {
                Id = 2,
                Name = "Anu",
                Age = 20,
                CourseId = 102
            });

            
            Console.WriteLine("\n-- STUDENT LIST --");
            studentManager.ListStudents();

           
            Console.WriteLine("\n-- STUDENTS OLDER THAN 21 --");
            studentManager.FilterStudentsByAge(21);

            
            Console.WriteLine("\n-- STUDENTS IN COURSE 101 --");
            studentManager.GetStudentsByCourse(101);

            
            Console.WriteLine("\n-- UPDATE STUDENT --");
            studentManager.UpdateStudent(1);

            
            Console.WriteLine("\n-- DELETE STUDENT --");
            studentManager.DeleteStudent(2);

            
            Console.WriteLine("\n-- FINAL STUDENT LIST --");
            studentManager.ListStudents();
        }
    }
}
