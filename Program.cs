using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_HW    // Наговицын Дмитрий, HW #1
{
    class MyClass   // шестое задание 
    {
        /*6. *Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
         */
        public static string Question(string param)
        {
            Console.WriteLine("Введите " + param);
            return Console.ReadLine();
        }
        public static void Pause()
        {
            Console.ReadKey();
        }

        public static void PrintXY(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
    }

        class Program
    {
        static void Questionary() // первое задание
        {
            /*1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). 
             * В результате вся информация выводится в одну строчку.
                а) используя склеивание;
                б) используя форматированный вывод;
                в) *используя вывод со знаком $.*/
            string fn = MyClass.Question("Имя");
            string ln = MyClass.Question("Фамилия");
            string age = MyClass.Question("Возраст");
            string height = MyClass.Question("Рост");
            string weight = MyClass.Question("Вес");
            Console.WriteLine("Ваши фамилия и имя " + fn + " " + ln + ", возраст " + age + ", рост " + height + ", вес " + weight);
            Console.WriteLine("Ваши фамилия и имя {0} {1}, возраст {2}, рост {3}, вес {4}",fn, ln, age, height, weight);
            Console.WriteLine($"Ваши фамилия и имя {fn} {ln}, возраст {age}, рост {height}, вес {weight}");
        }

        private static void IndexMT() // второе задание, индекс массы тела
        {
            /*2. Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
             * где m — масса тела в килограммах, h — рост в метрах
             */
            float height = Convert.ToSingle(MyClass.Question("Рост в см"))/100;
            int weight = Convert.ToInt32(MyClass.Question("Вес в кг"));
            float indexmt = weight / (height * height);
            Console.WriteLine("Ваш индекс массы тела {0:F2}", indexmt);

            if (indexmt <= 16) Console.WriteLine("Выраженный дефицит массы тела");
            else if (indexmt > 16 && indexmt <= 18.5) Console.WriteLine("Недостаточная (дефицит) масса тела");
            else if (indexmt > 18.5 && indexmt < 25) Console.WriteLine("Это норма");
            else if (indexmt >= 25 && indexmt < 30) Console.WriteLine("Избыточная масса тела (предожирение)");
            else if (indexmt >= 30 && indexmt < 35) Console.WriteLine("Ожирение");
            else if (indexmt >= 35 && indexmt < 40) Console.WriteLine("Ожирение резкое");
            else if (indexmt >= 40) Console.WriteLine("Очень резкое ожирение");
            
        }
        private static void DistanceCalc() //третье задание, расстояние между точками
        {
            /*3. а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
             * по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, 
             * используя спецификатор формата .2f (с двумя знаками после запятой);
            б) *Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
            */
            int x1 = Convert.ToInt32(MyClass.Question("координату X первой точки"));
            int y1 = Convert.ToInt32(MyClass.Question("координату Y первой точки"));
            int x2 = Convert.ToInt32(MyClass.Question("координату X второй точки"));
            int y2 = Convert.ToInt32(MyClass.Question("координату Y второй точки"));
            var r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("Расстояние меджу точками составит {0:F2}", r);
        }
        private static void ChangeValue() //четвертое задание, обмен значениями
        {
            /*4. Написать программу обмена значениями двух переменных.
                а) с использованием третьей переменной;
                б) *без использования третьей переменной.*/
            var a = 100;
            var b = 50;
            Console.WriteLine($"A = {a}, B = {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"A = {a}, B = {b}");
        }
        private static void PrintStr(string str, ConsoleColor color) // пятое задание
        {
            /*5. а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            б) Сделать задание, только вывод организуйте в центре экрана
            в) *Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y)*/
            Console.ForegroundColor = color;
            Console.SetCursorPosition((Console.WindowWidth / 2 - str.Length /2), Console.WindowHeight / 2);
            Console.WriteLine(str);
          
        }
        static void Main(string[] args)
        {
            Questionary();    //первое задание
            MyClass.Pause();
            Console.Clear();
            IndexMT();        // второе задание
            MyClass.Pause();
            Console.Clear();
            DistanceCalc();   // третье задание
            MyClass.Pause();
            Console.Clear();
            ChangeValue();      // четкертое задание
            MyClass.Pause();
            Console.Clear();
            PrintStr("Наговицын Дмитрий, Екатеринбург", ConsoleColor.DarkGreen);    // пятое задание
            MyClass.Pause();
                      
        }
        
    }
}
