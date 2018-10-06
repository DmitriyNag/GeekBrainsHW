using System;
using System.Text.RegularExpressions;using System.Text;

namespace Lesson_5_HW
{
    /// <summary>

    /// </summary>
    class UsingStrings
    {
        /// <summary>
        /// 1. Создать программу, которая будет проверять корректность ввода логина. 
        /// Корректным логином будет строка от 2 до 10 символов, содержащая только 
        /// буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        ///б) с использованием регулярных выражений.
        /// <returns></returns>
        public static bool PassCheck(string pass,string regExString)
        {
            Regex myReg = new Regex(regExString);
            if (myReg.IsMatch(pass)) return true;
            else return false;
        }

        /// <summary>
        /// 3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
        ///а) с использованием методов C#;
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns></returns>
        public static bool TwoStringCompare(string str1,string str2)
        {
            str1 = str1.ToLower();
            str2 = str2.ToLower();
            char[] arStr1 = StringToCharArray(str1);
            char[] arStr2 = StringToCharArray(str2);

            arStr1 = SortArray(arStr1);
            str1 = CharArrayToString(arStr1);
            arStr2 = SortArray(arStr2);
            str2 = CharArrayToString(arStr2);
            return str1.CompareTo(str2) == 0;
        }

        private static char[] StringToCharArray(string str)
        {
            char[] charArr = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                charArr[i] = str[i];
            }

            return charArr;
        }

        private static string CharArrayToString(char[] charArr)
        {
            StringBuilder str = new StringBuilder();
            foreach (char t in charArr)
            {
                str.Append(t);
            }

            return Convert.ToString(str);
        }
        /// <summary>
        /// функция сортировки массива символов
        /// </summary>
        private static char[] SortArray (char[] charArray)
        {
            char tmpChar;
            for (int j = 1; j < charArray.Length; j++)
            {
                for (int i = 0; i < charArray.Length - j; i++)
                {
                    if (charArray[i].CompareTo(charArray[i+1]) < 0)
                    {
                        tmpChar = charArray[i + 1];
                        charArray[i + 1] = charArray[i];
                        charArray[i] = tmpChar;
                    }

                }
            }
            return charArray;
        }
        
    }
}


