using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Student
    {
        public delegate bool SearchCondition(Student student);

        public string lastName;
        public string firstName;
        public string university;
        public string faculty;
        public int course;
        public string department;
        public int group;
        public string city;
        int age;

        /// <summary>
        /// Конструктор
        /// </summary>
        public Student(string firstName, string lastName, string university,
            string faculty, string department, int age, int course, int group, string city)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.course = course;
            this.age = age;
            this.group = group;
            this.city = city;
        }

        /// <summary>
        /// своя функция поиска по массиву студентов с предикатом
        /// </summary>
        /// <param name="sc"></param>
        /// <param name="list"></param>
        /// <returns></returns>
        public static List<Student> MySearch(SearchCondition sc, List<Student> list)
        {
            List<Student> resultList = new List<Student>();
            foreach (Student t in list)
            {
                if(sc(t)) resultList.Add(t);
            }

            return resultList;
        }

        public static bool IsBakalavr(Student student)
        {
            return student.course < 5;
        }

        public static bool IsMagistr(Student student)
        {
            return student.course >= 5;
        }

        /// <summary>
        /// Считаем кол-во студентов по курсам
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static int[] CountStudentsOnCourses(List<Student> list)
        {
            int[] studentsOnCurses = new int[6];
            foreach (var t in list)
            {
                //Console.WriteLine(t.course);
                studentsOnCurses[t.course-1]++;
            }

            return studentsOnCurses;
        }
        /// <summary>
        /// формируем строку с инфо о кол-ве студентов по курсам
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string PrintStudentsOnCourses(List<Student> list)
        {
            StringBuilder str = new StringBuilder();
            int[] studentsOnCourses = Student.CountStudentsOnCourses(list);
            for (int i = 0; i < studentsOnCourses.Length; i++)
            { 
                str.Append($"{i+1} курс - {studentsOnCourses[i]} студентов\n");
            }
            return Convert.ToString(str);
        }

    }
}