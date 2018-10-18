using System;
using System.Collections.Generic;

namespace Task_1
{
    class CalcGame
    {
        public int NumberToGuess {set; get;}
        public int TurnCount { set; get; }
        public bool Started { set; get; }
        public List<int> Turns = new List<int>();

        public CalcGame()
        {
            Started = false;
        }
        public void StartGame(int a, int b)
        {
            Random rnd = new Random();
            NumberToGuess = rnd.Next(a, b);
            Started = true;
        }

        public bool CheckAnswer(int answer)
        {
            return (NumberToGuess == answer);
        }

        /// <summary>
        /// возвращаем значение с прошлого хода
        /// </summary>
        /// <returns></returns>
        public int ReturnTurn()
        {
            if (Started)
            {
                TurnCount--;
                int a = Turns[Turns.Count - 1 -1];
                Turns.RemoveAt(Turns.Count-1);
                return a;
            }
            else return 0;
        }
        /// <summary>
        /// делаем ход
        /// </summary>
        /// <param name="a"></param>
        public void GaneTurn(int a)
        {
            if (Started)
            {
                TurnCount++;
                Turns.Add(a);
            }
        }
    }
}