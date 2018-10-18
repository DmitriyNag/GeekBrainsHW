using System;
using System.Windows.Forms;

namespace Task_2
{
    public partial class Form2 : Form
    {
        private string Filename { set; get; }
        private TrueFalse Db { set; get; }
        private int QNumber { set; get; }

        public Form2()
        {
            InitializeComponent();
            Btn_BackQ.Enabled = false;
            Btn_DeleteQ.Enabled = false;
            Btn_ForwardQ.Enabled = false;
        }

        /// <summary>
        /// Открываем доступ к кнопкам управления на форме, показываем первый вопрос
        /// </summary>
        private void InitForm()
        {
            QNumber = 0;
            ShowQuestion(QNumber);
            Btn_BackQ.Enabled = true;
            Btn_DeleteQ.Enabled = true;
            Btn_ForwardQ.Enabled = true;
        }

        /// <summary>
        /// Показываем данные вопроса в форме(или пустые данные)
        /// </summary>
        /// <param name="qNumber"></param>
        private void ShowQuestion(int qNumber)
        {
            if (qNumber > -1)   
            {
                //question = Db.list[qNumber];
                Lbl_QNumber.Text = $"{qNumber + 1}";
                Text_Q.Text = Db[qNumber].Text;
                ChkBox_Answer.Checked = Db[qNumber].TrueFalse;
            }
            else //если словили признак пустого массива вопросов
            {
                Lbl_QNumber.Text = "0";
                Text_Q.Text = "";
                ChkBox_Answer.Checked = false;
            }

        }
        /// <summary>
        /// Сохраняем данные из формы в вопрос (в оперативной памяти)
        /// </summary>
        /// <param name="qNumber"></param>
        private void SaveQuestion(int qNumber)
        {
            Db[qNumber].Text = Text_Q.Text;
            Db[qNumber].TrueFalse = ChkBox_Answer.Checked;
        }

        private void Menu_openFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Filename = ofd.FileName;
                Db = new TrueFalse(ofd.FileName);
                Db.Load();
                InitForm();
            }
        }
        private void Menu_createFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Db = new TrueFalse(sfd.FileName);
                Db.Add("Введите здесь текст утверждения и поставьте  справа галочку, если утверждение верное", true);
                Db.Save();
                InitForm();
            }
        }
        private void Menu_saveFile_Click(object sender, EventArgs e)
        {
            if (Filename != string.Empty)
            {
                SaveQuestion(QNumber);
                Db.Save();
                MessageBox.Show($"Сохранение выполнено в файл: {Filename}");
            }
        }

        /// <summary>
        /// смотрим предыдущий вопрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_BackQ_Click(object sender, EventArgs e)
        {
            SaveQuestion(QNumber);
            if (QNumber > 0)
                ShowQuestion(--QNumber);
        }

        /// <summary>
        /// смотрим следующий вопрос
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_ForwardQ_Click(object sender, EventArgs e)
        {
            SaveQuestion(QNumber);
            if (QNumber < Db.Count-1)
                ShowQuestion(++QNumber);
        }

        /// <summary>
        /// удаляем вопрос из массива вопросов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_DeleteQ_Click(object sender, EventArgs e)
        {
            if (Db.Count > 0)
            {
                Db.Remove(QNumber);
                if (Db.Count == 0)
                    QNumber = -1;   //признак пустого массива вопросов

                else if (QNumber >= Db.Count - 1)
                    QNumber = Db.Count - 1;
                ShowQuestion(QNumber);
            }
        }

        private void Btn_AddQ_Click(object sender, EventArgs e)
        {
            Db.Add("<текст утверждения>",false);
            QNumber = Db.Count - 1;
            ShowQuestion(QNumber);
        }
    }
}
