using System;
using System.Collections.Generic;
using System.IO;


namespace Task3 ////Наговицын Дмитрий HW6, Task 3
{

    //3. Переделать программу «Пример использования коллекций» для решения следующих задач:
    //а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
    //б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(частотный массив);
    //в) отсортировать список по возрасту студента;
    // (не сделано) г) * отсортировать список по курсу и возрасту студента;
    //д) разработать единый метод подсчета количества студентов по различным параметрам выбора с помощью делегата и методов предикатов.

    class Program
    {
        static int CompareCourse(Student st1, Student st2) // Сделал по наитию :)
        {
            if(st1.course > st2.course) return 1;
            else if (st1.course < st2.course) return -1;
            else return 0;
        }

        static void Main(string[] args)
        {
            List<Student> list = new List<Student>();
            StreamReader sr = new StreamReader("students_6.csv");
            while (!sr.EndOfStream)
            {
                try
                {
                    string[] s = sr.ReadLine().Split(';');
                    // Добавляем в список новый экземпляр класса Student
                    list.Add(new
                        Student(s[0], s[1], s[2], s[3], s[4], int.Parse(s[5]), int.Parse(s[6]), int.Parse(s[7])
                            , s[8]));

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Ошибка!ESC - прекратить выполнение программы");
                    if (Console.ReadKey().Key == ConsoleKey.Escape) return;
                }
            }
            sr.Close();

            Console.WriteLine("Всего студентов:" + list.Count);
                //своя функция
            List<Student> tmpList = Student.MySearch(Student.IsBakalavr, list);
            Console.WriteLine($"кол-во бакалавров {tmpList.Count}");
                // встроенна функция
            Console.WriteLine($"кол-во магистров и учеников на 5 и 6 курсах {list.FindAll(Student.IsMagistr).Count}");
            Console.WriteLine("____________________");
            Console.WriteLine(Student.PrintStudentsOnCourses(list));
                //сортировка по курсу
            //list.Sort(new Comparison<Student>(CompareCourse));
            //foreach (var t in list)
            //{
            //    Console.WriteLine($"{t.firstName} {t.course}");
            //}
            Console.ReadKey();
        }
    }
}