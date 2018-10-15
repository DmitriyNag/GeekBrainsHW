using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_8
{
    public class Student
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string University { get; set; }

        public string Faculty { get; set; }

        public int Course { get; set; }

        public string Department { get; set; }

        public int Group { get; set; }

        public string City { get; set; }

        public int Age { get; set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        public Student(string firstName, string lastName, string university,
            string faculty, string department, int age, int course, int group, string city)
        {
            LastName = lastName;
            FirstName = firstName;
            University = university;
            Faculty = faculty;
            Department = department;
            Course = course;
            Age = age;
            Group = group;
            City = city;
        }

    }
}