using System;
using System.IO;

namespace lesson_4_HW
{
    /// <summary>
    /// 2. а) Дописать класс для работы с одномерным массивом. Реализовать конструктор, 
    /// создающий массив заданной размерности и заполняющий массив числами 
    /// от начального значения с заданным шагом. Создать свойство Sum, 
    /// которые возвращают сумму элементов массива, метод Inverse, 
    /// меняющий знаки у всех элементов массива, метод Multi, 
    /// умножающий каждый элемент массива на определенное число, свойство MaxCount, 
    /// возвращающее количество максимальных элементов. 
    /// В Main продемонстрировать работу класса.
    /// </summary>
    class MyArray
    {
        private int[] arr;

        /// <summary>
        /// сумму элементов массива
        /// </summary>
        public int Sum
        {
            get
            {
                int sumTmp = 0;
                for (int i = 0; i < arr.Length; i++) sumTmp += arr[i];
                return sumTmp;
            }
        }
        /// <summary>
        /// количество максимальных элементов в массиве
        /// </summary>
        public int MaxCount 
        {
            get
            {
                int max = 0;
                int MaxNumber = FindMaxNumber();
                for (int i = 0; i < arr.Length; i++) if (arr[i] == MaxNumber) max += 1;
                return max;
            }
        }

        /// <summary>
        /// конструктор с 1 параметром
        /// </summary>
        /// <param name="num">длинна массива</param>
        public MyArray(int num)
        {
            arr = new int[num];
        }

        /// <summary>
        /// конструктор с 3мя параметрами
        /// </summary>
        /// <param name="num">длинна массива</param>
        /// <param name="startNum">начальное число</param>
        /// <param name="step">шаг</param>
        public MyArray (int num, int startNum, int step)
        {
            try
            {
                arr = new int[num];
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = startNum;
                    startNum += step;
                }
                
            }
            catch 
            {
                arr = new int[] { 0 };
            }
        }

        /// <summary>
        /// конструктор из файла
        /// </summary>
        /// <param name="pathname"></param>
        public MyArray (string pathname)
        {
            try
            {
                // думаю это не оптимальный способ передаи данных из файла, моно как то сократить?
                string text = File.ReadAllText(pathname);
                string[] numbers = text.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                arr = new int[numbers.Length];
                for (int i = 0; i < arr.Length; i++) arr[i] = Convert.ToInt32(numbers[i]);
            }
            catch
            {
                arr = new int[] { 0 };
            }
        }
       
        /// <summary>
        /// поиск максимального значения в массиве
        /// </summary>
        private int FindMaxNumber()
        {
            int maxNumber = arr[0];
            for (int i = 1; i < arr.Length; i++) if (maxNumber < arr[i]) maxNumber = arr[i];
            return maxNumber;
        }

        /// <summary>
        /// 1. Дан целочисленный массив из 20 элементов. 
        /// Элементы массива могут принимать целые значения от –10 000 до 10 000 
        /// включительно. Написать программу, позволяющую найти и вывести количество 
        /// пар элементов массива, в которых хотя бы одно число делится на 3. 
        /// В данной задаче под парой подразумевается два подряд идущих элемента массива
        /// </summary>
        public int CountPairDivTree()
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if ((arr[i] % 3 == 0 && arr[i] != 0) || (arr[i + 1] % 3 == 0 && arr[i + 1] != 0)) count++;
            }
            return count;
        }

        /// <summary>
        /// Вывод на печать массива в строку
        /// </summary>
        /// <returns></returns>
        public string PrintArray()
        {
            string str = "";
            try
            {
                for (int i = 0; i < arr.Length; i++) str += arr[i] + " ";
            }
            catch
            {
                str = "Ошибка печати массива";
            }
            return str;
        }
        
        /// <summary>
        /// Печать массива в файл
        /// </summary>
        /// <param name="pathname"></param>
        public void PrintToFile(string pathname)
        {
            File.WriteAllText(pathname, PrintArray());
        }
        /// <summary>
        /// Заполнение массива произвольными значениями int
        /// </summary>
        /// <param name="genFrom">минимальное генерируемое число</param>
        /// <param name="genTo">максимальное генерируемое число</param>
        /// <returns></returns>
        public void InitArray(int genFrom, int genTo)
        {
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(genFrom, genTo);
            }
        }

        /// <summary>
        /// смена знаков всех значений в массиве
        /// </summary>
        public void Inverse()
        {
            Multi(-1);
        }

        /// <summary>
        /// Умножение на число
        /// </summary>
        /// <param name="a">Множитель</param>
        public void Multi(int a)
        {
            for (int i = 0; i < arr.Length; i++) arr[i] = arr[i]*a;
        }

    }
}
