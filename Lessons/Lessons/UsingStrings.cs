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
            char[] ArStr1 = str1.ToCharArray();
            char[] ArStr2 = str2.ToCharArray();

            ArStr1 = SortArray(ArStr1);
            str1 = string.Join("", ArStr1);
            Console.WriteLine(str1);
            ArStr2 = SortArray(ArStr2);
            str2 = string.Join("", ArStr2);
            Console.WriteLine(str2);

            if (str1.CompareTo(str2) == 0) return true;
            else return false;

        }

        private static char[] SortArray (char[] CharArray)
        {
            char tmpChar;
            for (int j = 1; j < CharArray.Length; j++)
            {
                for (int i = 0; i < CharArray.Length - j; i++)
                {
                    if (CharArray[i].CompareTo(CharArray[i+1]) < 0)
                    {
                        tmpChar = CharArray[i + 1];
                        CharArray[i + 1] = CharArray[i];
                        CharArray[i] = tmpChar;
                    }

                }
            }
            return CharArray;
        }
        
    }
}


