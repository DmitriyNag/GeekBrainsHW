using System;

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
        /// Пауза
        /// </summary>
        public static void Pause()
        {
            Console.ReadKey();
        }
      }
}
