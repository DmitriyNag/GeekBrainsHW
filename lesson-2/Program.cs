using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_2  // Наговицын Дмитрий, HW 2
{
    /// <summary>
    /// Мой класс с унниверсальными функциями 
    /// </summary>
    class MyClass   
    {
        /// <summary>
        /// просим ввести значение и считываем его
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public static string Question(string param)
        {
            Console.WriteLine("Введите " + param);
            return Console.ReadLine();
        }
        public static void Pause()
        {
            Console.ReadKey();
        }
        /// <summary>
        /// Печатаем текст по координатам в коносли
        /// </summary>
        /// <param name="str"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void PrintXY(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(str);
        }
        /// <summary>
        /// Считаем сумму цифр в целом числе циклом
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int SumOfNum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        /// <summary>
        /// Считаем сумму цифр в целом числе рекурсивно
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int SumOfNumRec(int number)
        {
            return (number > 0) ? number % 10 + SumOfNumRec(number / 10) : 0;
        }
    }

    class Program
    {
        /// <summary>
        /// 1.Написать метод, возвращающий минимальное из трех чисел.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns></returns>
        static float MaxOfThree (float x, float y, float z)
        {
            if (x < y) return x < z ? x : z;
            else return y < z ? y : z;
        }
        /// <summary>
        /// 2. Написать метод подсчета количества цифр числа.
        /// Считает кол-во цифр в дробном числе без учета ","
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static int CountChar (double number)
        {
            string s = Convert.ToString(number);
            Console.WriteLine(s);
            return s.IndexOf(",") < 0 ? s.Length : s.Length - 1;
           
        }
        /// <summary>
        /// 3. С клавиатуры вводятся числа, пока не будет введен 0.
        /// Подсчитать сумму всех нечетных положительных чисел.
        /// </summary>
        private static void CountPosOddNumbers()
        {
            int sum = 0;
            int number = 0;
            Console.WriteLine("Вводите целые числа, программа посчитает сумму всех " +
                "положитлеьных не четных чисел. Для подсчета результата введите \"0\"");
            while (true)
            {
                try
                {   // прочитал про try catch, заюзал для опыта
                    number = Convert.ToInt32(MyClass.Question("новое число"));
                    if (number == 0) break;
                    if (number > 0 && number % 2 != 0) sum += number;
                }
                catch (Exception)
                {

                    Console.Write("Нужно ввести целое число. "); ;
                }

            }
            Console.WriteLine($" Сумма всех нечетных положительных чисел = {sum}");
        }
        /// <summary>
        /// 4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
        /// На выходе истина, если прошел авторизацию, и ложь, если не прошел 
        /// (Логин: root, Password: GeekBrains). Используя метод проверки логина и 
        /// пароля, написать программу: пользователь вводит логин и пароль, программа
        /// пропускает его дальше или не пропускает. 
        /// С помощью цикла do while ограничить ввод пароля тремя попытками.
        /// </summary>
        private static bool PassControl(string log, string pass, int attempts)
        {
            for (int i = 0; i < attempts; i++)
            {
                if (log == MyClass.Question("логин") & pass == MyClass.Question("пароль"))
                {
                    Console.WriteLine("Access granted");
                    return true;
                }
                else Console.WriteLine($"Введены не верные данные. У вас осталось {attempts - i -1} попыток.");
            }
            Console.WriteLine("Access denied");
            return false;
        }
        /// <summary>
        ///     6. *Написать программу подсчета количества «Хороших» чисел 
        ///     в диапазоне от 1 до 1 000 000 000. Хорошим называется число, 
        ///     которое делится на сумму своих цифр. 
        ///     Реализовать подсчет времени выполнения программы, 
        ///     используя структуру DateTime.
        /// </summary>
        private static void CountGoodNubmers(int number, int step)
        {
            DateTime DTStart = DateTime.Now;
            DateTime DTNow;
            int count = 0;
            Console.Clear();
            Console.WriteLine($"Считаем количество \"хороших\" чисел в числе {number}");
            for (int i = 1; i <= number; i++)
            {
                if (i % step == 0)
                {
                    DTNow = DateTime.Now;
                    MyClass.PrintXY($"Время выполнения операции: {DTNow.Subtract(DTStart)} | выполнено {Math.Round(((double)i / number) * 100)} %", 0, 1);
                }
                if (i % MyClass.SumOfNumRec(i) == 0) count++;
            }
            Console.WriteLine($"\n Подсчет завершен. Кол-во \"хороших\" чисел - {count}");
        }

        /// <summary>
        /// 7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static void PrintNumAtoB(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                PrintNumAtoB(a+1,b);
            }
        }

        /// <summary>
        /// 7. б) *Разработать рекурсивный метод, который считает сумму чисел от a до b. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private static int SumNumAtoB(int a, int b)
        {
            return (a <= b) ? a += SumNumAtoB(a + 1, b) : 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MaxOfThree(700, 500, 600));   //первое задание
            MyClass.Pause();
            double a = 123456.789;
            Console.WriteLine(CountChar(a));    // второе задание
            MyClass.Pause();
            string pass = "GeekBrains";
            string log = "root";
            int attempts = 3;
            if (PassControl(log, pass, attempts))   // четвертое задание
            {
                Console.WriteLine("Теперь вы можете воспользоваться нашим калькулятором");
                CountPosOddNumbers();   //третье задание
            }
            MyClass.Pause();
            // пятое задание сделал еще в прошлый раз
            CountGoodNubmers(10000000, 100000);  //шестое задание
            MyClass.Pause();
            PrintNumAtoB(10,20);  //седьмое задание 7.1.
            MyClass.Pause();
            Console.WriteLine(SumNumAtoB(1,5)); //седьмое задание 7.2.
            MyClass.Pause();        
        }

    }
}
