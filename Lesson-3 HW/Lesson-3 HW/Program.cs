using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_3_HW
{
    /// <summary>
    /// Мой класс с функциями 
    /// </summary>
    class MyClass
    {
        /// <summary>
        /// чтение строки
        /// </summary>
        public static string StrInput(string param)
        {
            Console.WriteLine(param);
            return Console.ReadLine();
        }

        /// <summary>
        /// Чтение целого числа
        /// </summary>
        public static int IntInput(string param)
        {
            string str;
            int output;
            while (true)
            {
                Console.WriteLine(param);
                str = Console.ReadLine();
                if (int.TryParse(str, out output)) break;
            }
            return output;
        }

        /// <summary>
        /// Задание 3.1. ** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
        ///ArgumentException("Знаменатель не может быть равен 0");
        /// Чтение целого числа, не равного 0
        /// </summary>
        public static int IntNotZeroInput(string param)
        {
            string str;
            int output;
            while (true)
            {
                Console.WriteLine(param);
                str = Console.ReadLine();
                if (int.TryParse(str, out output))
                    if (output != 0) break;
            }
            return output;
        }
        /// <summary>
        /// вывод на экран дроби
        /// </summary>
        public static void FrPrint(string str, fraction fr)
        {
            Console.WriteLine($"{str} {fr.frTop}/{fr.frBottom}");
        }
        /// <summary>
        /// Пауза
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
      }

    /// <summary>
    /// Структура для работы с комплексными числами
    /// Задание 1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. 
    /// Продемонстрировать работу структуры;
    /// б) Дописать класс Complex, добавив методы вычитания и произведения чисел.
    /// Проверить работу класса;
    /// </summary>
    struct Complex
    {
        public double a;
        public double b;
        
        /// <summary>
        /// Сложение двух комплексных чисел
        /// </summary>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.a = a + x.a;
            y.b = b + x.b;
            return y;
        }
        /// <summary>
        /// Вычитание двух комплексных чисел
        /// </summary>
        public Complex Minus(Complex x)
        {
            Complex y;
            y.a = a - x.a;
            y.b = b - x.b;
            return y;
        }
        /// <summary>
        /// Произведение двух комплексных чисел
        /// </summary>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.a = a * x.a - b * x.b;
            y.b = b * x.a + a * x.b;
            return y;
        }
        /// <summary>
        /// Деление двух комплексных чисел
        /// </summary>
        public Complex Div(Complex x)
        {
            Complex y;
            y.a = (a * x.a + b * x.b) / (Math.Pow(x.a,2) + Math.Pow(x.b, 2));
            y.b = (b *x.a - a*x.b) / (Math.Pow(x.a, 2) + Math.Pow(x.b, 2));
            return y;
        }
        public string ToString()
        {
            if(b>=0) return a + "+" + b + "i";
            else return a +""+ b + "i";
        }
    }
    

    /// <summary>
    /// Задание 3.*Описать класс дробей - рациональных чисел, являющихся отношением двух целых 
    /// чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    /// Написать программу, демонстрирующую все разработанные элементы класса.
    /// </summary>
    struct fraction
    {
        public int frTop;
        public int frBottom;

        public fraction(int x, int y)
        {
            this.frTop = x;
            this.frBottom = y;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        public static fraction Addition(fraction fr1, fraction fr2)
        {
            fraction tmpfr;
            tmpfr.frTop = fr1.frTop*fr2.frBottom + fr2.frTop*fr1.frBottom;
            tmpfr.frBottom = fr1.frBottom * fr2.frBottom;
            return fraction.Simplific(tmpfr);
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        public static fraction Subtraction(fraction fr1, fraction fr2)
        {
            fraction tmpfr;
            tmpfr.frTop = fr1.frTop * fr2.frBottom - fr2.frTop * fr1.frBottom;
            tmpfr.frBottom = fr1.frBottom * fr2.frBottom;
            return fraction.Simplific(tmpfr);
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        public static fraction Multiplication(fraction fr1, fraction fr2)
        {
            fraction tmpfr;
            tmpfr.frTop = fr1.frTop * fr2.frTop;
            tmpfr.frBottom = fr1.frBottom * fr2.frBottom;
            return fraction.Simplific(tmpfr);
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        public static fraction Division(fraction fr1, fraction fr2)
        {
            fraction tmpfr;
            tmpfr.frTop = fr1.frTop * fr2.frBottom;
            tmpfr.frBottom = fr1.frBottom * fr2.frTop;
            return fraction.Simplific(tmpfr);
        }

        /// <summary>
        /// Упрощение дробей
        /// Задание 3.2.Добавить упрощение дробей.
        /// </summary>
        static fraction Simplific(fraction fr)
        {
            for (int i = 2; i <= fr.frTop && i <= fr.frBottom; i++)
            {
                if (fr.frTop % i == 0 && fr.frBottom % i == 0)
                {
                    fr.frTop /= i;
                    fr.frBottom /= i;
                    return Simplific(fr);

                }
            }
            return fr;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            #region Задание 3. Взаимодествие со структурой дробей
            fraction myFrac1;
            fraction myFrac2;
            myFrac1.frTop = MyClass.IntInput("Введите числитель первой дроби (целое число)");
            myFrac1.frBottom = MyClass.IntNotZeroInput("Введите знаменатель первой дроби (целое число, не равное 0)");
            myFrac2.frTop = MyClass.IntInput("Введите числитель второй дроби (целое число)");
            myFrac2.frBottom = MyClass.IntNotZeroInput("Введите знаменатель второй дроби (целое число, не равное 0)");

            MyClass.FrPrint("Первая дробь:", myFrac1);
            MyClass.FrPrint("Вторая дробь:", myFrac2);

            fraction myFrac3 = fraction.Addition(myFrac1, myFrac2);
            MyClass.FrPrint("Сложение:", myFrac3);
            myFrac3 = fraction.Subtraction(myFrac1, myFrac2);
            MyClass.FrPrint("Вычитание:", myFrac3);
            myFrac3 = fraction.Multiplication(myFrac1, myFrac2);
            MyClass.FrPrint("Умножение:", myFrac3);
            myFrac3 = fraction.Division(myFrac1, myFrac2);
            MyClass.FrPrint("Деление:", myFrac3);
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
