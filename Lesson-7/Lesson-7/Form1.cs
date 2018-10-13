using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Windows.Forms;
// ReSharper disable InvalidXmlDocComment

/// <summary>
/// 2. Используя Windows Forms, разработать игру «Угадай число».
/// Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.
/// Для ввода данных от человека используется элемент TextBox.
/// </summary>
namespace Lesson_7  // Наговицын Дмитрий HW7 Task 2
{
    [SuppressMessage("ReSharper", "LocalizableElement")]
    public partial class Form1 : Form
    {
        Game myGame = new Game();
        private const int rectX = 30; // параметры для отрисовки диапазона ответов
        private const int rectY = 30;
        private const int rectLenght = 460;
        private const int rectHeght = 15;
        private const int rangeStart = 0; // диапазон ответов
        private const int rangeEnd = 100;
        System.Drawing.SolidBrush wrongAnswerBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Tomato);
        System.Drawing.SolidBrush initBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkGray);
        System.Drawing.SolidBrush rightAnswerBrush = new System.Drawing.SolidBrush(System.Drawing.Color.DarkGreen);
        System.Drawing.Graphics formGraphics;

        public Form1()
        {
            InitializeComponent();
            LblFinish.Visible = false;
            LblStart.Visible = false;
            LblUserAnswer.Visible = false;
            LbltxtAnswer.Visible = false;
            BtnAnswer.Text = "Старт";
            TextAnswer.Visible = false;
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            formGraphics = this.CreateGraphics();
            if (myGame.IsStarted)
            {
                LblUserAnswer.Text = TextAnswer.Text; //показываем ответ игрока на шкале ответов
                int rectRange = Convert.ToInt32((rectLenght * myGame.GetAnswerPosition(TextAnswer.Text)));
                //чуть корректируем размещение ответа игрока, если оно накладывается на подписи к шкале
                if (rectRange + rectX < 35) LblUserAnswer.Left = 35;
                else if (rectRange + rectX > 470) LblUserAnswer.Left = 470;
                else LblUserAnswer.Left = rectRange + rectX;

                // закрашиваем область не подходящих значений на шкале ответов и выводим сообщение 
                int a = myGame.CheckAnswer(TextAnswer.Text);
                if (a == 2)
                {
                    Message.Text = "Ваш значение больше загаданного";
                    formGraphics.FillRectangle(wrongAnswerBrush, new Rectangle(rectRange + rectX, rectY, rectLenght- rectRange, rectHeght));
                }
                else if (a == 1)
                {
                    Message.Text = "Ваш значение меньше загаданного";
                    formGraphics.FillRectangle(wrongAnswerBrush, new Rectangle(rectX, rectY, rectRange, rectHeght));
                }
                else if (a == 0)
                {
                    Message.Text = "Верно!";
                    formGraphics.FillRectangle(rightAnswerBrush, new Rectangle(rectX, rectY, rectLenght, rectHeght));
                }
                else
                    Message.Text = "Ошибка ввода";

                if (!myGame.IsStarted)
                {
                    BtnAnswer.Text = "Старт";
                }
            }
            else
            {
                myGame.Start(rangeStart, rangeEnd);
                RenewForm();
            }
        }
        /// <summary>
        /// обновляем все элементы формы.
        /// </summary>
        public void RenewForm()
        {
            BtnAnswer.Text = "Ответить";
            LblFinish.Text = Convert.ToString(rangeEnd);
            LblStart.Text = Convert.ToString(rangeStart);
            LblFinish.Visible = true;
            LblStart.Visible = true;
            LblUserAnswer.Visible = true;
            LblUserAnswer.Text = "";
            LbltxtAnswer.Visible = true;
            TextAnswer.Visible = true;
            TextAnswer.Text = "";
            Message.Text = "";
            formGraphics.FillRectangle(initBrush, new Rectangle(rectX, rectY, rectLenght, rectHeght));
        }
    }
}
