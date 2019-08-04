using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_HW
{
    class Program
    {
        static void Main()
        {
            #region Задание 3. Взаимодествие со структурой дробей
            Fraction myFrac1 = new Fraction(MyClass.IntInput("Введите числитель первой дроби (целое число)"), 
                MyClass.IntNotZeroInput("Введите знаменатель первой дроби (целое число, не равное 0)"));
            Fraction myFrac2 = new Fraction(MyClass.IntInput("Введите числитель второй дроби (целое число)"), 
                MyClass.IntNotZeroInput("Введите знаменатель второй дроби (целое число, не равное 0)"));

            Console.WriteLine($"Первая дробь: {myFrac1.Print()}");
            Console.WriteLine($"Вторая дробь: {myFrac2.Print()}");

            //fraction myFrac3 = fraction.Addition(myFrac1, myFrac2);
            Fraction myFrac3 = myFrac1.Addition(myFrac2);
            Console.WriteLine($"Сложение: {myFrac3.Print()}");
            myFrac3 = myFrac1.Subtraction(myFrac2);
            Console.WriteLine($"Вычитание: {myFrac3.Print()}");
            myFrac3 = myFrac1.Multiplication(myFrac2);
            Console.WriteLine($"Умножение: {myFrac3.Print()}");
            myFrac3 = myFrac1.Division(myFrac2);
            Console.WriteLine($"Деление: {myFrac3.Print()}");
            MyClass.Pause();
            #endregion

            #region Задание2 сумма чисел
            Console.Clear();
            CountPosOddNumbers(); //Задание 2
            MyClass.Pause();
            #endregion

            #region Задание 1. Комплексные числа
            Console.Clear();
            Complex complex1;
            complex1.a = 1;
            complex1.b = 1;
            Complex complex2;
            complex2.a = 2;
            complex2.b = 2;
            Complex result = complex1.Plus(complex2);
            Console.WriteLine("Сложение " + result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine("Умножение " + result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine("Вычитание " + result.ToString());
            result = complex1.Div(complex2);
            Console.WriteLine("Деление " + result.ToString());
            MyClass.Pause();
            #endregion
        }
        /// <summary>
        /// Задание 2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
        /// Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму 
        /// вывести на экран, используя tryParse;
        ///б) Добавить обработку исключительных ситуаций на то, что могут быть введены 
        ///    некорректные данные.При возникновении ошибки вывести сообщение.
        ///    Напишите соответствующую функцию;
        /// </summary>
        private static void CountPosOddNumbers()
        {
            int sum = 0;
            int number = 0;
            string allNumbers = "";
            Console.WriteLine("Вводите целые числа, программа посчитает сумму всех " +
                "положитлеьных не четных чисел. Для подсчета результата введите \"0\"");
            while (true)
            {
                if (int.TryParse(MyClass.StrInput("Введите новое число"), out number))
                {   
                    if (number == 0) break;
                    if (number > 0 && number % 2 != 0)
                    {
                        if (allNumbers == "") allNumbers += number;
                        else allNumbers = allNumbers + " + " + number;
                        sum += number;
                    }
                }
                else Console.Write("Нужно ввести целое число. ");
            }
            Console.WriteLine($" Сумма всех нечетных положительных чисел: {allNumbers} = {sum}");
        }
    }
}
