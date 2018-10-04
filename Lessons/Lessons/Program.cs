using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace Lesson_5_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            //#region task1
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

            #region task2
            string input = "мама мыла раму папа пилил деревоо брат сидел на корове и отгонял мух";
            //Console.WriteLine(Message.WordsLessN(input,4));
            //Console.WriteLine(Message.RemoveWordsWithEndChar(input,'а'));
            //Console.WriteLine(Message.LongestWord(input));
            //Console.WriteLine(Message.AllLongestWords(input));
            Console.ReadKey();
            #endregion

            string a = "erpoogbm;";
            string b = "PooGbm;Er";
            if (UsingStrings.TwoStringCompare(a,b))  Console.WriteLine("одна строка является перестановкой другой ");
            else Console.WriteLine("одна строка НЕ является перестановкой другой");
            Console.ReadKey();

        }
    }
}


