using System;
using System.Collections.Generic;

namespace Task_2
{
    public class Game
    {
        public string FileName { get; set; }
        public bool IsStarted { get; set; }
        public int NumOfQuestions { get; set; }
        public List<Question> Questions { get; set; }
        public int TurnsCount { get; set; }
        public int RightAnswerCount { get; set; }

        /// <summary>
        /// конструктор,создаем новую игру с заданным колиеством вопросов в ней
        /// </summary>
        /// <param name="numOfQuestions"></param>
        public Game(int numOfQuestions, string filename)
        {
            NumOfQuestions = numOfQuestions;
            IsStarted = true;
            FileName = filename;
            TrueFalse tf = new TrueFalse(FileName);
            Questions = tf.Load();
            Random rnd = new Random();
                //формируем пул вопросов для игры
            if (Questions.Count < NumOfQuestions)
                NumOfQuestions = Questions.Count;
            else
            {
                while (Questions.Count > NumOfQuestions)
                    Questions.RemoveAt(rnd.Next(0, Questions.Count));
            }
        }

        public string GetQuestion()
        {
            return Questions[TurnsCount].Text;
        }

        /// <summary>
        /// проверка корректности ответа
        /// </summary>
        /// <param name="answer"></param>
        /// <returns></returns>
        public bool CheckAnswer(bool answer)
        {
            if (Questions[TurnsCount++].TrueFalse == answer)
            {
                RightAnswerCount++;
                CheckEndOfGame();
                return true;
            }
            else
            {
                CheckEndOfGame();
                return false;
            }

        }

        /// <summary>
        /// проверяем не закончились ли ходы
        /// </summary>
        public void CheckEndOfGame()
        {
            if (TurnsCount >= Questions.Count) IsStarted = false;
        }
    }

}
