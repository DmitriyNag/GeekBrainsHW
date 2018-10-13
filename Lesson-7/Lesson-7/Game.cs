using System;

namespace Lesson_7
{
    class Game
    {
        public bool IsStarted { get; set; }
        public int RightAnswer { get; set; }
        public int CountSteps { get; set; }
        public int RangeStart { get; set; }
        public int RangeEnd { get; set; }
        public void Start(int a, int b)
        {
            IsStarted = true;
            Random rnd = new Random();
            RangeStart = a;
            RangeEnd = b;
            RightAnswer = rnd.Next(RangeStart, RangeEnd);
            CountSteps = 0;
        }

        /// <summary>
        /// проверяем верность ответа. возвращаем
        ///     2, если ответ больше верного,
        ///     1 если ответ меньше верного,
        ///     0 - если ответ совпал,
        ///     -1 - если не удвлось считать ответ
        /// </summary>
        /// <param name="answerString"></param>
        /// <returns></returns>
        public int CheckAnswer(string answerString)
        {
            if (int.TryParse(answerString, out int answer))
            {
                CountSteps++;
                if (answer > RightAnswer) return 2;
                else if (answer < RightAnswer) return 1;
                else 
                {
                    IsStarted = false;
                    return 0;
                }
            }
            else return -1;
        }

        /// <summary>
        /// возвращаем точку на шкале ответов, в процентах от мин до макс возможного ответа
        /// </summary>
        /// <param name="answerString"></param>
        /// <returns></returns>
        public double GetAnswerPosition(string answerString)
        {
            if (int.TryParse(answerString, out int answer))
            {
                return Math.Round((double)answer/RangeEnd,2);
            }
            else return 0;
        }
    }
}