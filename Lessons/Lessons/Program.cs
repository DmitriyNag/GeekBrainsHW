using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Lesson_5_HW // Наговицын Дмитрий HW5 Tasks 1,2,3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region task1
            //string passRule = @"^[^\d]{1}[a-zA-z\d]{1,9}$";
            //string log = string.Empty;
            //while (true)
            //{
            //    Console.WriteLine("логин");
            //    log = Console.ReadLine();
            //    if (UsingStrings.PassCheck(log, passRule))
            //    {
            //        Console.WriteLine("Ок, логин подходит");
            //        break;
            //    }

            //    else Console.WriteLine("Введите логин от 2 до 10 символов, " +
            //        "содержащий только буквы латинского алфавита или цифры, " +
            //        "при этом цифра не может быть первой");
            //}
            //Console.ReadKey();
            //#endregion

            //#region task2
            //string input = "мама мыла раму папа пилил деревоо брат сидел на корове и отгонял мух";
            //Console.WriteLine(input);
            //Console.Write("Слова короче 4х букв: ");
            //Console.WriteLine(Message.WordsLessN(input, 4));
            //Console.Write("Слова не оканчивающиеся на 'а': ");
            //Console.WriteLine(Message.RemoveWordsWithEndChar(input, 'а'));
            //// ReSharper disable once StringLiteralTypo
            //Console.Write("длинна самого длинного слова: ");
            //Console.WriteLine(Message.LongestWord(input));
            //Console.Write("самые длинные слова: ");
            //Console.WriteLine(Message.AllLongestWords(input));
            //Console.ReadKey();
            #endregion

            #region task3
            string a = "erpoAogbm;";
            string b = "aPooGbm;Er";
            Console.WriteLine($"Первая строка: {a}");
            Console.WriteLine($"Первая строка: {b}");
            if (UsingStrings.TwoStringCompare(a, b)) Console.WriteLine("одна строка является перестановкой другой ");
            else Console.WriteLine("одна строка НЕ является перестановкой другой");
            Console.ReadKey();
            #endregion

        }
    }
}


