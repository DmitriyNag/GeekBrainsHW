namespace Lesson_3_HW
{
    /// <summary>
    /// Задание 3.*Описать класс дробей - рациональных чисел, являющихся отношением двух целых 
    /// чисел. Предусмотреть методы сложения, вычитания, умножения и деления дробей. 
    /// Написать программу, демонстрирующую все разработанные элементы класса.
    /// </summary>
    struct Fraction
    {
        int frTop;
        int frBottom;

        public Fraction(int x, int y)
        {
            frTop = x;
            frBottom = y;
        }

        /// <summary>
        /// Сложение дробей
        /// </summary>
        public Fraction Addition(Fraction fr2)
        {
            Fraction tmpfr;
            tmpfr.frTop = frTop*fr2.frBottom + fr2.frTop*frBottom;
            tmpfr.frBottom = frBottom * fr2.frBottom;
            return Fraction.Simplific(tmpfr);
        }

        /// <summary>
        /// Вычитание дробей
        /// </summary>
        public Fraction Subtraction(Fraction fr2)
        {
            Fraction tmpfr;
            tmpfr.frTop = frTop * fr2.frBottom - fr2.frTop * frBottom;
            tmpfr.frBottom = frBottom * fr2.frBottom;
            return Fraction.Simplific(tmpfr);
        }

        /// <summary>
        /// Умножение дробей
        /// </summary>
        public Fraction Multiplication(Fraction fr2)
        {
            Fraction tmpfr;
            tmpfr.frTop = frTop * fr2.frTop;
            tmpfr.frBottom = frBottom * fr2.frBottom;
            return Fraction.Simplific(tmpfr);
        }

        /// <summary>
        /// Деление дробей
        /// </summary>
        public Fraction Division(Fraction fr2)
        {
            Fraction tmpfr;
            tmpfr.frTop = frTop * fr2.frBottom;
            tmpfr.frBottom = frBottom * fr2.frTop;
            return Fraction.Simplific(tmpfr);
        }
        public string Print ()
        {
            return frTop + "/" + frBottom; 
        }
        /// <summary>
        /// Упрощение дробей
        /// Задание 3.2.Добавить упрощение дробей.
        /// </summary>
        static Fraction Simplific(Fraction fr)
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
}
