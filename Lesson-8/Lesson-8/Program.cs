using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Lesson_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к CSV файлу со списком студентов");
            string pathname = Console.ReadLine();
            List<Student> list = ReadStudentsCsv(pathname);
            if (list != null)
            {
                Console.WriteLine("Введите  путь и имя файла json, который необходимо создать");
                pathname = Console.ReadLine();
                WriteStudentsToJson(pathname, list);
                Console.WriteLine("Запись выполнена успешно");
            }
            else
            {
                Console.WriteLine("Ошибка записи");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Записываем даннные о студентах в JSON
        /// </summary>
        /// <param name="pathname"></param>
        /// <param name="list"></param>
        private static void WriteStudentsToJson(string pathname, List<Student> list)
        {
            string json = JsonConvert.SerializeObject(list);
            Stream fStream = new FileStream(pathname, FileMode.Create, FileAccess.Write);
            StreamWriter sWrite = new StreamWriter(fStream);
            sWrite.Write(json);
            sWrite.Close();
            fStream.Close();
        }

        /// <summary>
        /// Считываем данные о студентах из CSV
        /// </summary>
        /// <param name="pathname"></param>
        /// <returns></returns>
        private static List<Student> ReadStudentsCsv(string pathname)
        {
            List<Student> list = new List<Student>();
            if (File.Exists(pathname))
            {
                Console.WriteLine(pathname);
                StreamReader sr = new StreamReader(pathname);
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
                        Console.WriteLine("Ошибка!Нажми кнопку что бы прекратить выполнение программы");
                        Console.ReadKey();
                        return null;
                    }
                }
                sr.Close();
                return list;
            }
            else
            {
                Console.WriteLine("Ошибка!Нажми кнопку что бы прекратить выполнение программы");
                Console.ReadKey();
                return null;
            }
           
        }
    }
}
