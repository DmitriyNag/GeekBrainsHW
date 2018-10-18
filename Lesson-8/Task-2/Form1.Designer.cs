namespace Task_2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Start = new System.Windows.Forms.Button();
            this.Lbl_QuestionText = new System.Windows.Forms.Label();
            this.Lbl_countAnswers = new System.Windows.Forms.Label();
            this.Btn_True = new System.Windows.Forms.Button();
            this.Btn_false = new System.Windows.Forms.Button();
            this.Lbl_Answer = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.открытьФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_openRedactor = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_numOfQInGame = new System.Windows.Forms.Label();
            this.Txt_NumOfQInGame = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.Location = new System.Drawing.Point(330, 345);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(111, 46);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Старт";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.Btn_Start_Click);
            // 
            // Lbl_QuestionText
            // 
            this.Lbl_QuestionText.AutoSize = true;
            this.Lbl_QuestionText.Location = new System.Drawing.Point(71, 92);
            this.Lbl_QuestionText.Name = "Lbl_QuestionText";
            this.Lbl_QuestionText.Size = new System.Drawing.Size(0, 20);
            this.Lbl_QuestionText.TabIndex = 1;
            // 
            // Lbl_countAnswers
            // 
            this.Lbl_countAnswers.AutoSize = true;
            this.Lbl_countAnswers.Location = new System.Drawing.Point(468, 358);
            this.Lbl_countAnswers.Name = "Lbl_countAnswers";
            this.Lbl_countAnswers.Size = new System.Drawing.Size(0, 20);
            this.Lbl_countAnswers.TabIndex = 1;
            // 
            // Btn_True
            // 
            this.Btn_True.Location = new System.Drawing.Point(217, 247);
            this.Btn_True.Name = "Btn_True";
            this.Btn_True.Size = new System.Drawing.Size(111, 46);
            this.Btn_True.TabIndex = 0;
            this.Btn_True.Text = "Верно";
            this.Btn_True.UseVisualStyleBackColor = true;
            this.Btn_True.Click += new System.EventHandler(this.Btn_True_Click);
            // 
            // Btn_false
            // 
            this.Btn_false.Location = new System.Drawing.Point(447, 247);
            this.Btn_false.Name = "Btn_false";
            this.Btn_false.Size = new System.Drawing.Size(111, 46);
            this.Btn_false.TabIndex = 0;
            this.Btn_false.Text = "Не верно";
            this.Btn_false.UseVisualStyleBackColor = true;
            this.Btn_false.Click += new System.EventHandler(this.Btn_false_Click);
            // 
            // Lbl_Answer
            // 
            this.Lbl_Answer.AutoSize = true;
            this.Lbl_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Answer.Location = new System.Drawing.Point(337, 187);
            this.Lbl_Answer.Name = "Lbl_Answer";
            this.Lbl_Answer.Size = new System.Drawing.Size(0, 32);
            this.Lbl_Answer.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьФайлToolStripMenuItem,
            this.Menu_openRedactor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // открытьФайлToolStripMenuItem
            // 
            this.открытьФайлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_OpenFile,
            this.Menu_exit});
            this.открытьФайлToolStripMenuItem.Name = "открытьФайлToolStripMenuItem";
            this.открытьФайлToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.открытьФайлToolStripMenuItem.Text = "Игра";
            // 
            // Menu_OpenFile
            // 
            this.Menu_OpenFile.Name = "Menu_OpenFile";
            this.Menu_OpenFile.Size = new System.Drawing.Size(211, 30);
            this.Menu_OpenFile.Text = "Открыть файл";
            this.Menu_OpenFile.Click += new System.EventHandler(this.Menu_OpenFile_Click);
            // 
            // Menu_exit
            // 
            this.Menu_exit.Name = "Menu_exit";
            this.Menu_exit.Size = new System.Drawing.Size(211, 30);
            this.Menu_exit.Text = "Выход";
            this.Menu_exit.Click += new System.EventHandler(this.Menu_exit_Click);
            // 
            // Menu_openRedactor
            // 
            this.Menu_openRedactor.Name = "Menu_openRedactor";
            this.Menu_openRedactor.Size = new System.Drawing.Size(100, 29);
            this.Menu_openRedactor.Text = "Редактор";
            this.Menu_openRedactor.Click += new System.EventHandler(this.Menu_openRedactor_Click);
            // 
            // Lbl_numOfQInGame
            // 
            this.Lbl_numOfQInGame.AutoSize = true;
            this.Lbl_numOfQInGame.Location = new System.Drawing.Point(25, 358);
            this.Lbl_numOfQInGame.Name = "Lbl_numOfQInGame";
            this.Lbl_numOfQInGame.Size = new System.Drawing.Size(191, 20);
            this.Lbl_numOfQInGame.TabIndex = 3;
            this.Lbl_numOfQInGame.Text = "Кол-во вопросов в игре:";
            // 
            // Txt_NumOfQInGame
            // 
            this.Txt_NumOfQInGame.Location = new System.Drawing.Point(75, 391);
            this.Txt_NumOfQInGame.Name = "Txt_NumOfQInGame";
            this.Txt_NumOfQInGame.Size = new System.Drawing.Size(100, 26);
            this.Txt_NumOfQInGame.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Txt_NumOfQInGame);
            this.Controls.Add(this.Lbl_numOfQInGame);
            this.Controls.Add(this.Lbl_Answer);
            this.Controls.Add(this.Lbl_countAnswers);
            this.Controls.Add(this.Lbl_QuestionText);
            this.Controls.Add(this.Btn_false);
            this.Controls.Add(this.Btn_True);
            this.Controls.Add(this.Btn_Start);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label Lbl_QuestionText;
        private System.Windows.Forms.Label Lbl_countAnswers;
        private System.Windows.Forms.Button Btn_True;
        private System.Windows.Forms.Button Btn_false;
        private System.Windows.Forms.Label Lbl_Answer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem открытьФайлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_openRedactor;
        private System.Windows.Forms.ToolStripMenuItem Menu_exit;
        private System.Windows.Forms.Label Lbl_numOfQInGame;
        private System.Windows.Forms.TextBox Txt_NumOfQInGame;
    }
}

