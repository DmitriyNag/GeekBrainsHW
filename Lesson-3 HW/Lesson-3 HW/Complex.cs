using System;

namespace Lesson_3_HW
{
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
}
