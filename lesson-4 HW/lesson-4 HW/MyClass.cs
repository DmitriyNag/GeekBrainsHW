using System;

namespace lesson_4_HW
{
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
