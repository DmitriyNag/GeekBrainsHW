using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

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
    class Pupil
    {
        private static int id = 0;
        private int pupilId;
        private string name;
        private string surname;
        int[] grades = new int[3];
        public double Average
        {
            get
            {
                int avr = 0;
                //добавить try
                for (int i = 0; i < grades.Length; i++) avr += grades[i];
                return Math.Round((double)avr/grades.Length, 2);
            }
        }

        public Pupil(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            this.pupilId = id;
            id++;
        }

        /// <summary>
        /// ввод оценок ученика
        /// </summary>
        /// <param name="grades"></param>
        public void gradesInput(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                //добавить контроль кол-ва вводимых оценок
                this.grades[i] = grades[i];
            }
        }

        /// <summary>
        /// печать данных об ученике
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            StringBuilder str = new StringBuilder();
            str.Append($"id={pupilId}, {name} {surname}, оценки: ");
            for (int i = 0; i < grades.Length; i++)
            {
                str.Append(grades[i]);
                str.Append(" ");
            }
            str.Append($". Среднее {Average}");
            return Convert.ToString(str);
        }
        /// <summary>
        /// Получаем значение оценки, хуже или равны которой numOfLastGrades оценок
        /// </summary>
        /// <param name="pupils"></param>
        /// <param name="numOfLastGrades"></param>
        /// <returns></returns>
        public static double GetBestOfLastGrades(Pupil[] pupils, int numOfLastGrades)
        {
            //double tmp;
            double[] OnlyAverageGrades = new double[pupils.Length];
            for (int i = 0; i < pupils.Length; i++)
            {
                OnlyAverageGrades[i] = pupils[i].Average;
            }
            Array.Sort(OnlyAverageGrades); // можно ли сразу сортировать массив учеников по свойству среднее
            
            // for (int j = 0; j < numOfLastGrades; j++)
            //  {
            //for (int i = 0; i < OnlyAverageGrades.Length - 1; i++)
            //    {
            //        if (OnlyAverageGrades[i] > OnlyAverageGrades[i + 1])
            //        {
            //            tmp = OnlyAverageGrades[i + 1];
            //            OnlyAverageGrades[i + 1] = OnlyAverageGrades[i];
            //            OnlyAverageGrades[i] = tmp;
            //        }
            //    }
            // }
            //for (int i = 0; i < OnlyAverageGrades.Length; i++)
            //{
            //    Console.WriteLine(OnlyAverageGrades[i]);
            //}

            //for (int i = 0; i < numOfLastGrades; i++)
            //{
            //    Console.WriteLine(OnlyAverageGrades[i]);
            //}

            return OnlyAverageGrades[numOfLastGrades-1];
        }
        /// <summary>
        /// Получаем массив учеников, с numOfLastGrades плохих оценок
        /// </summary>
        /// <param name="pupils"></param>
        /// <param name="numOfLastGrades"></param>
        /// <returns></returns>
        public static Pupil[] GetWorstPupils(Pupil[] pupils, int numOfLastGrades)
        {

            int count=0;
            for (int i = 0; i < pupils.Length; i++)
            {
                if (pupils[i].Average <= GetBestOfLastGrades(pupils, numOfLastGrades))
                {
                    count++;
                }
            }

            Pupil[] loosers = new Pupil[count];
            int j = 0;
            for (int i = 0; i < pupils.Length; i++)
            {
                if (pupils[i].Average <= GetBestOfLastGrades(pupils, numOfLastGrades))
                {
                    loosers[j] = pupils[i];
                    j++;
                }
            }
            return loosers;
        }


        /// <summary>
        /// поиск ученика с худшей оценкой
        /// </summary>
        /// <param name="pupils"></param>
        /// <returns></returns>
        public static int GetWorstPupilNumber(Pupil[] pupils)
        {
            
            int worstPupilNumber = 0;
            double minGrade = double.MaxValue;
            for (int i = 1; i < pupils.Length-1; i++)
            {
                if (pupils[i].Average < minGrade)
                {
                    worstPupilNumber = i;
                    minGrade = pupils[i].Average;
                }
                
            }
            return worstPupilNumber;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            int gradesnumber = 3; // кол-во оценок для учеников
            string pathname = "data.txt"; // файл данных
            int worstgrades = 3;    // кол-во худших средних оценок, учеников с которыми нужно вывести
            Pupil[] pupils;

            InputPupils(gradesnumber, pathname, out pupils);
            PrintListOfPupils(pupils,"Все ученики:");

            Pupil[] loosers = Pupil.GetWorstPupils(pupils, worstgrades);
            PrintListOfPupils(loosers, $"Ученики с {worstgrades} самими худшими оценками:");
            Console.ReadKey();

        }

        private static void PrintListOfPupils(Pupil[] pupils, string str)
        {
            Console.WriteLine("_______________________________________________");
            Console.WriteLine(str);
            Console.WriteLine("_______________________________________________");
            for (int i = 0; i < pupils.Length; i++)
            {
                Console.WriteLine(pupils[i].Print());
            }
        }

        private static void InputPupils(int gradesnumber, string pathname, out Pupil[] pupils)
        {
            int pupilCount;
            string input = string.Empty;
            string[] inputArray = new string[gradesnumber + 2];
            int[] grades = new int[gradesnumber];

            StreamReader sr = new StreamReader(pathname); // проверка на наличие файлв
            pupilCount = Convert.ToInt32(sr.ReadLine()); // проверка на чтение первой строки

            pupils = new Pupil[pupilCount];
            for (int i = 0; i < pupilCount; i++)
            {
                inputArray = sr.ReadLine().Split(' ');
                // добавить проверку введенных данных
                pupils[i] = new Pupil(inputArray[0], inputArray[1]);
                for (int j = 0; j < gradesnumber; j++)
                {
                    //добавить проверку кол-ва оценок
                    grades[j] = Convert.ToInt32(inputArray[j + 2]);
                }
                pupils[i].gradesInput(grades);
            }
            sr.Close();
        }
    }
}
