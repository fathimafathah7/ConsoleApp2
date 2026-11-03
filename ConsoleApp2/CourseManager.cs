using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    internal class CourseManager
    {
       private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Course added");
        }
        public void ListCourses()
        {
            Console.WriteLine("Available Courses: ");

            foreach(Course course in courses)
            {
                Console.WriteLine($"course ID: {course.CourseId}");
                Console.WriteLine($"Course Name: {course.CourseName}");
            }

        }

    }
}
