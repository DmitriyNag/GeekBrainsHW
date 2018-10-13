using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// ReSharper disable LocalizableElement

/// <summary>
/// 1. а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
///   б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.Игрок должен постараться получить это число за минимальное количество ходов.
///    в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
/// </summary>
namespace Task_1 // Наговицын Дмитрий HW 7 Task 1
{
    public partial class Form1 : Form
    {
        private CalcGame myGame;
        int a;

        public Form1()
        {
            InitializeComponent();
            Lbl_countName.Text = "";
            Lbl_result.Text = "0";
            myGame = new CalcGame();
            Btn_return.Enabled = false;
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            a = int.Parse(Lbl_result.Text);
            a = a + 1;
            Lbl_result.Text = (a).ToString();
            Turn(a);
        }

        private void Btn_multi_Click(object sender, EventArgs e)
        {
            a = int.Parse(Lbl_result.Text);
            a = a * 2;
            Lbl_result.Text = (a).ToString();
            Turn(a);

        }

        private void Btn_rewind_Click(object sender, EventArgs e)
        {
            if(myGame.Started)
            {
                Lbl_result.Text = myGame.ReturnTurn().ToString();
                Lbl_countName.Text = $"Кол - во ходов: {myGame.TurnCount}";
            }
        }
        private void Btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
            Btn_return.Enabled = false;

        }

        private void PlayMenu_Click(object sender, EventArgs e)
        {
            int a = 50;
            int b = 200;
            Lbl_result.Text = "0";
            myGame.StartGame(a,b);
            Lbl_countName.Text = "Кол - во ходов:";
            Lbl_answr.Text = myGame.NumberToGuess.ToString();
            Btn_return.Enabled = true;


        }

        /// <summary>
        /// сброс игры
        /// </summary>
        public void Reset()
        {
            Lbl_result.Text = "0";
            Lbl_countName.Text = "";
            Lbl_answr.Text = "";
            myGame.Started = false;
        }

        /// <summary>
        /// выполнение операции
        /// </summary>
        /// <param name="a"></param>
        public void Turn(int a)
        {
            if (myGame.Started)
            {
                myGame.GaneTurn(a);
                Lbl_countName.Text = $"Кол - во ходов: {myGame.TurnCount}";
                if (myGame.CheckAnswer(a))
                {
                    MessageBox.Show($"вы выиграли за {myGame.TurnCount} ходов");
                    Reset();
                }
            }
        }
    }
}
