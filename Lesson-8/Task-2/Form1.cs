using System;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Task_2
{
    [SuppressMessage("ReSharper", "LocalizableElement")]
    public partial class Form1 : Form
    {
        private string Filename { set; get; }
        private Game myGame;
        
        public Form1()
        {
            InitializeComponent();
            Btn_True.Enabled = false;
            Btn_false.Enabled = false;

        }

        /// <summary>
        /// Старт или стоп игры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Start_Click(object sender, EventArgs e)
        {
            if (myGame == null)
            {
                if (File.Exists(Filename))
                {
                    if (Int32.TryParse(Txt_NumOfQInGame.Text, out int numOfQInGame))
                    {
                        if (numOfQInGame > 0)
                        {
                            myGame = new Game(numOfQInGame, Filename);
                            Btn_Start.Text = "Cтоп игра";
                            Btn_True.Enabled = true;
                            Btn_false.Enabled = true;
                            Txt_NumOfQInGame.Visible = false;
                            Lbl_numOfQInGame.Text = $"Кол-во вопросов в игре: {numOfQInGame}";
                            Lbl_QuestionText.Text = myGame.GetQuestion();
                            Lbl_countAnswers.Text = $"Всего ответов\\верных ответов: {myGame.TurnsCount}\\0";
                        }
                        else MessageBox.Show("Укажите число вопросов в игре");
                    }
                    else MessageBox.Show("Укажите число вопросов в игре");
                }
                else MessageBox.Show("Укажите файл с вопросами");
            }
            else
            {
                EndOfGame();
            }
        }

        private void Btn_True_Click(object sender, EventArgs e)
        {
            CheckAnswerOnForm(true);
        }

        private void Btn_false_Click(object sender, EventArgs e)
        {
            CheckAnswerOnForm(false);
        }
        /// <summary>
        /// проверка корректности ответа, смена отображения формы по результату
        /// </summary>
        /// <param name="answer"></param>
        private void CheckAnswerOnForm(bool answer)
        {
            if (myGame != null)
            {
                if (myGame.CheckAnswer(answer))
                {
                    Lbl_Answer.ForeColor = Color.MediumSeaGreen;
                    Lbl_Answer.Text = "Верно";
                }
                else
                {
                    Lbl_Answer.ForeColor = Color.DarkRed;
                    Lbl_Answer.Text = "Не верно";
                }
                Lbl_countAnswers.Text = $"Всего ответов\\верных ответов: {myGame.TurnsCount}\\{myGame.RightAnswerCount}";

                if (!myGame.IsStarted)
                    EndOfGame();
                else
                    Lbl_QuestionText.Text = myGame.GetQuestion();
            }
        }

        /// <summary>
        /// Обновляем форму при завершении игры
        /// </summary>
        private void EndOfGame()
        {
            Btn_True.Enabled = false;
            Btn_false.Enabled = false;
            Txt_NumOfQInGame.Visible = true;
            Lbl_numOfQInGame.Text = $"Кол-во вопросов в игре:";
            Lbl_QuestionText.Text = "ИГРА ОКОНЧЕНА";
            Lbl_Answer.Text = "";
            Btn_Start.Text = "Старт";
            myGame = null;
        }
        private void Menu_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Menu_OpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                Filename = ofd.FileName;
        }

        private void Menu_openRedactor_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }
    }
}


