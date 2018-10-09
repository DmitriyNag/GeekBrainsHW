using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using static lesson_6.ProgramFunc;

namespace lesson_6  //Наговицын Дмитрий HW6, Task 2
{
    //2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    //а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
    //б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
    //в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
    //возвращает минимум через параметр.

    public delegate double InputFunction(double x);

    class MainProgram
    {
     
        static void Main(string[] args)
        {
            double fromValue = -10; // начальный параметр изменения переменной, результат будет в файле
            double toValue = 10; // начальный параметр изменения переменной, результат будет в файле
            double step = 0.5; //шаг

            List<InputFunction> listOfFunc = GetListOfFunc();
            int userPick = InputUserChoise(listOfFunc);

            double searchFrom, searchTo;
            InputUserDiapason(fromValue, toValue, out searchFrom, out searchTo);

            SaveFunc(MyFunc, "data.bin", fromValue, toValue, step);
            double min = double.MaxValue;
            double[,] result = Load("data.bin", searchFrom, searchTo, ref min);
            Console.WriteLine($"Минимальное значение: {min}");

            Console.ReadKey();
        }

        /// <summary>
        /// Получаем от пользвоателя диапазон поиска
        /// </summary>
        /// <param name="fromValue"></param>
        /// <param name="toValue"></param>
        /// <param name="searchFrom"></param>
        /// <param name="searchTo"></param>
        private static void InputUserDiapason(double fromValue, double toValue, out double searchFrom, out double searchTo)
        {
            while (true)
            {
                Console.WriteLine($"Введите начальное значение диапазона для поиска, в пределах от {fromValue} до {toValue}:");
                if (double.TryParse(Console.ReadLine(), out searchFrom))
                {
                    if (searchFrom >= fromValue)
                        break;
                }
                Console.WriteLine("Криво ввел");

            }

            while (true)
            {
                Console.WriteLine($"Введите конечное значение диапазона для поиска, в пределах от {fromValue} до {toValue}:");
                if (double.TryParse(Console.ReadLine(), out searchTo))
                {
                    if (searchTo <= toValue)
                        break;
                }
                Console.WriteLine("Криво ввел");
            }
        }

        /// <summary>
        /// получаем от пользователя выбор функции
        /// </summary>
        private static int InputUserChoise(List<InputFunction> listOfFunc)
        {
            int userPick;
            while (true)
            {
                Console.WriteLine("Выбирите функцию (введите соответствующий номер):");
                for (int i = 0; i < listOfFunc.Count; i++)
                {

                    Console.WriteLine($"{i + 1}. {listOfFunc[i].Method}");
                }

                if (Int32.TryParse(Console.ReadLine(), out userPick)) break;
            }

            return userPick-1;
        }
    }
}
