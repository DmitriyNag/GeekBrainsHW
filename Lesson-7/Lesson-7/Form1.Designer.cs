namespace Lesson_7
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
            this.BtnAnswer = new System.Windows.Forms.Button();
            this.TextAnswer = new System.Windows.Forms.TextBox();
            this.VisualizeAnswer = new System.Windows.Forms.TableLayoutPanel();
            this.LblStart = new System.Windows.Forms.Label();
            this.LblFinish = new System.Windows.Forms.Label();
            this.LblUserAnswer = new System.Windows.Forms.Label();
            this.LbltxtAnswer = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAnswer
            // 
            this.BtnAnswer.Location = new System.Drawing.Point(311, 304);
            this.BtnAnswer.Name = "BtnAnswer";
            this.BtnAnswer.Size = new System.Drawing.Size(152, 38);
            this.BtnAnswer.TabIndex = 0;
            this.BtnAnswer.Text = "Начать игру";
            this.BtnAnswer.UseVisualStyleBackColor = true;
            this.BtnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
            // 
            // TextAnswer
            // 
            this.TextAnswer.Location = new System.Drawing.Point(311, 234);
            this.TextAnswer.Name = "TextAnswer";
            this.TextAnswer.Size = new System.Drawing.Size(152, 26);
            this.TextAnswer.TabIndex = 1;
            // 
            // VisualizeAnswer
            // 
            this.VisualizeAnswer.ColumnCount = 2;
            this.VisualizeAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.VisualizeAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VisualizeAnswer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.VisualizeAnswer.Location = new System.Drawing.Point(42, 45);
            this.VisualizeAnswer.Name = "VisualizeAnswer";
            this.VisualizeAnswer.RowCount = 1;
            this.VisualizeAnswer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.VisualizeAnswer.Size = new System.Drawing.Size(700, 40);
            this.VisualizeAnswer.TabIndex = 2;
            this.VisualizeAnswer.Visible = false;
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.Location = new System.Drawing.Point(30, 100);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(18, 20);
            this.LblStart.TabIndex = 3;
            this.LblStart.Text = "0";
            // 
            // LblFinish
            // 
            this.LblFinish.AutoSize = true;
            this.LblFinish.Location = new System.Drawing.Point(730, 100);
            this.LblFinish.Name = "LblFinish";
            this.LblFinish.Size = new System.Drawing.Size(36, 20);
            this.LblFinish.TabIndex = 3;
            this.LblFinish.Text = "100";
            // 
            // LblUserAnswer
            // 
            this.LblUserAnswer.AutoSize = true;
            this.LblUserAnswer.Location = new System.Drawing.Point(380, 89);
            this.LblUserAnswer.Name = "LblUserAnswer";
            this.LblUserAnswer.Size = new System.Drawing.Size(36, 20);
            this.LblUserAnswer.TabIndex = 3;
            this.LblUserAnswer.Text = "___";
            // 
            // LbltxtAnswer
            // 
            this.LbltxtAnswer.AutoSize = true;
            this.LbltxtAnswer.Location = new System.Drawing.Point(176, 240);
            this.LbltxtAnswer.Name = "LbltxtAnswer";
            this.LbltxtAnswer.Size = new System.Drawing.Size(129, 20);
            this.LbltxtAnswer.TabIndex = 3;
            this.LbltxtAnswer.Text = "Введите ответ:";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(364, 173);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(0, 20);
            this.Message.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.LblUserAnswer);
            this.Controls.Add(this.LblFinish);
            this.Controls.Add(this.LbltxtAnswer);
            this.Controls.Add(this.LblStart);
            this.Controls.Add(this.VisualizeAnswer);
            this.Controls.Add(this.TextAnswer);
            this.Controls.Add(this.BtnAnswer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAnswer;
        private System.Windows.Forms.TextBox TextAnswer;
        private System.Windows.Forms.TableLayoutPanel VisualizeAnswer;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label LblFinish;
        private System.Windows.Forms.Label LblUserAnswer;
        private System.Windows.Forms.Label LbltxtAnswer;
        private System.Windows.Forms.Label Message;
    }
}

