using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
// ReSharper disable InvalidXmlDocComment
// ReSharper disable StringLiteralTypo
// ReSharper disable All

namespace EGE
{
    /// <summary> 
    /// *На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
    ///школы.В первой строке сообщается количество учеников N, которое не меньше 10, но не
    ///превосходит 100, каждая из следующих N строк имеет следующий формат:
    ///<Фамилия> <Имя> <оценки>,
    ///где<Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
    ///более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
    ///пятибалльной системе. <Фамилия> и<Имя>, а также<Имя> и<оценки> разделены одним пробелом.
    ///Пример входной строки:
    ///Иванов Петр 4 5 3
    ///Требуется написать как можно более эффективную программу, которая будет выводить на экран
    ///фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
    ///набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
    /// </summary>

#pragma warning disable CS0659
    class Pupil
    #pragma warning restore CS0659
    {
        private static int _id;
        private readonly int _pupilId;
        private readonly string _name;
        private readonly string _surname;
        private int[] _grades;

        public double Average
        {
            get
            {
                int avr = 0;
                foreach (int t in _grades)
                    avr += t;
                return Math.Round((double)avr/_grades.Length, 2);
            }
        }

        public Pupil(string name, string surname)
        {
            Regex nameRegEx = new Regex(@"^[a-z,A-Z,а-я,А-Я]{1,15}$"); 
            Regex surnameRegEx = new Regex(@"^[a-z,A-Z,а-я,А-Я]{1,20}$");
            if (nameRegEx.IsMatch(name) && surnameRegEx.IsMatch(surname)) 
            {
                _name = name;
                _surname = surname;
                _pupilId = _id;
                _id++;
            }
            else
                throw new ArgumentException("Не корректные данные Имя или Фамилия");
        }

        /// <summary>
        /// ввод оценок ученика
        /// </summary>
        /// <param name="grades"></param>
        public void GradesInput(int[] grades)
        {
            _grades = new int[grades.Length];
            grades.CopyTo(_grades, 0);

        }

        /// <summary>
        /// печать данных об ученике
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"id={_pupilId}, {_name} {_surname}, оценки: ");
            foreach (int t in _grades)
            {
                str.Append($"{t} ");
            }
            str.Append($". Среднее {Average}");
            return Convert.ToString(str);
        }

        /// <summary>
        /// Получаем значение средней оценки, лучшей(большей)  из numOfLastGrades худших(меньших) оценок
        /// </summary>
        /// <param name="pupils"></param>
        /// <param name="numOfLastGrades"></param>
        /// <returns></returns>
        public static double GetBestOfLastGrades(Pupil[] pupils, int numOfLastGrades)
        {
            double[] onlyAverageGrades = new double[pupils.Length];
            for (int i = 0; i < pupils.Length; i++)
            {
                onlyAverageGrades[i] = pupils[i].Average;
            }
            Array.Sort(onlyAverageGrades);
            //tip попробовать написать алгорит создания новго отсортированного массива( через /2)
            return onlyAverageGrades[numOfLastGrades-1];
        }

        /// <summary>
        /// Получаем массив учеников, средняя оценка коотрых равна или хуже(меньше) лучшей из
        /// numOfLastGrades самых плохих средних оценок
        /// </summary>
        /// <param name="pupils"></param>
        /// <param name="numOfLastGrades"></param>
        /// <returns></returns>
        public static Pupil[] GetWorstPupils(Pupil[] pupils, int numOfLastGrades)
        {
            double bestOfLstGrades = GetBestOfLastGrades(pupils, numOfLastGrades);
            List<Pupil> loosers = new List<Pupil>();
            foreach (Pupil t in pupils)
            {
                if (t.Average <= bestOfLstGrades)
                {
                    loosers.Add(t);
                }
            }
            return loosers.ToArray();
        }

        public static bool CheckGradesFormat(string grade)
        {
            int intGrade;
            if (Int32.TryParse(grade, out intGrade))
            {
                if (intGrade > 0 && intGrade <= 5)
                    return true;
                else
                    return false;
            }
            else return false;

        }

    }
}
