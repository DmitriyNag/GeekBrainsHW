using System;
using System.Collections.Generic;
using System.IO;

namespace Task2
{
    class ProgramFunc
    {
        /// <summary>
        /// список функций
        /// </summary>
        /// <returns></returns>
        public static List<InputFunction> GetListOfFunc()
        {
            List<InputFunction> ListOfFunc = new List<InputFunction> {MyFunc, SqrtMinusOne, PenniYearCalc};
            return ListOfFunc;
        }


        public static double MyFunc(double x)
        {
            return x * x - 50 * x + 10;
        }
        public static double SqrtMinusOne(double x)
        {

            return Math.Sqrt(x)-1;

        }
        public static double PenniYearCalc(double x)
        {

            return x * 8.25 * 365 /360000;

        }
        /// <summary>
        /// Сохранение результата работы функции в файл в формате <значение переменной><результат функции>
        /// </summary>
        /// <param name="function">функция</param>
        /// <param name="fileName"> путь к файлу для сохранения</param>
        /// <param name="fromValue">значение начала даипазона переменной</param>
        /// <param name="toValue">значение окончания даипазона переменной</param>
        /// <param name="step">шаг изменения переменной</param>
        public static void SaveFunc(InputFunction function, string fileName, double fromValue, double toValue, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create,
                FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = fromValue;
            while (x <= toValue)
            {
                bw.Write(x);
                bw.Write(function(x));
                x += step;
            }
            bw.Close();
            fs.Close();
        }

        public static double[,] Load(string fileName, double fromValue, double toValue, ref double min)
        {
            
            FileStream fs = new FileStream(fileName, FileMode.Open,
                FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double[,] resultArray = new double[fs.Length / (2*sizeof(double)),2];
            for (int i = 0; i < resultArray.GetLength(0); i++)
            {
                resultArray[i, 0] = bw.ReadDouble();
                resultArray[i, 1] = bw.ReadDouble();

                if (resultArray[i, 0] >= fromValue && resultArray[i, 0] <= toValue && resultArray[i, 1] < min)
                {
                    min = resultArray[i, 1];
                    //Console.WriteLine($"{resultArray[i, 0]} {resultArray[i, 1]} | {min}");
                }
            }
            bw.Close();
            fs.Close();
            return resultArray;
        }


        
    }
}