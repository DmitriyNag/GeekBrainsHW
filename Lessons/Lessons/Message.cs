using System.Text;
using System;
using System.Text.RegularExpressions;

namespace Lesson_5_HW
{
    /// <summary>
    /// 2. Разработать класс Message, содержащий следующие статические методы для обработки
    ///текста:
    ///а) Вывести только те слова сообщения, которые содержат не более n букв.
    /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    ///в) Найти самое длинное слово сообщения.
    ///г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    ///Продемонстрируйте работу программы на текстовом файле с вашей программой.
    /// </summary>
    class Message
    {
        /// <summary>
        /// а) Вывести только те слова сообщения, которые содержат не более n букв.
        /// </summary>
        public static string WordsLessN (string str, int lenght)
        {
            StringBuilder tmpStr= new StringBuilder();
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length <= lenght) tmpStr.Append(words[i] + " ");
            }
            return Convert.ToString(tmpStr);
        }
        /// <summary>
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        public static string RemoveWordsWithEndChar (string str, char ch)
        {
            StringBuilder tmpStr = new StringBuilder();
            string[] words = str.Split(' ');
            Regex myReg = new Regex($"[^{ch}]$");
            for (int i = 0; i < words.Length; i++)
            {
                if (myReg.IsMatch(words[i])) tmpStr.Append(words[i] + " ");
            }
            return Convert.ToString(tmpStr);
        }

        /// <summary>
        /// в) Найти самое длинное слово сообщения.
        /// </summary>
        public static int LongestWord(string str)
        {
            string[] words = str.Split(' ');
            int max = words[0].Length;
            for (int i = 1; i < words.Length; i++)
            {
                if (max < words[i].Length) max = words[i].Length;
            }
            return max;
        }
        /// <summary>
        /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        public static string AllLongestWords(string str)
        {
            int max = LongestWord(str);
            StringBuilder tmpStr = new StringBuilder();
            string[] words = str.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length == max) tmpStr.Append(words[i] + " ");
            }
            return Convert.ToString(tmpStr);

        }
    }
}


