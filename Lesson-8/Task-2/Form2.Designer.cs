namespace Task_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_createFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Text_Q = new System.Windows.Forms.RichTextBox();
            this.Btn_BackQ = new System.Windows.Forms.Button();
            this.Btn_ForwardQ = new System.Windows.Forms.Button();
            this.Btn_DeleteQ = new System.Windows.Forms.Button();
            this.ChkBox_Answer = new System.Windows.Forms.CheckBox();
            this.Lbl_QNumber = new System.Windows.Forms.Label();
            this.Btn_AddQ = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_openFile,
            this.Menu_saveFile,
            this.Menu_createFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_openFile
            // 
            this.Menu_openFile.Name = "Menu_openFile";
            this.Menu_openFile.Size = new System.Drawing.Size(139, 29);
            this.Menu_openFile.Text = "Открыть файл";
            this.Menu_openFile.Click += new System.EventHandler(this.Menu_openFile_Click);
            // 
            // Menu_saveFile
            // 
            this.Menu_saveFile.Name = "Menu_saveFile";
            this.Menu_saveFile.Size = new System.Drawing.Size(170, 29);
            this.Menu_saveFile.Text = "Сохранить в файл";
            this.Menu_saveFile.Click += new System.EventHandler(this.Menu_saveFile_Click);
            // 
            // Menu_createFile
            // 
            this.Menu_createFile.Name = "Menu_createFile";
            this.Menu_createFile.Size = new System.Drawing.Size(193, 29);
            this.Menu_createFile.Text = "Создать новый файл";
            this.Menu_createFile.Click += new System.EventHandler(this.Menu_createFile_Click);
            // 
            // Text_Q
            // 
            this.Text_Q.Location = new System.Drawing.Point(181, 75);
            this.Text_Q.Name = "Text_Q";
            this.Text_Q.Size = new System.Drawing.Size(476, 149);
            this.Text_Q.TabIndex = 1;
            this.Text_Q.Text = "";
            // 
            // Btn_BackQ
            // 
            this.Btn_BackQ.Location = new System.Drawing.Point(26, 75);
            this.Btn_BackQ.Name = "Btn_BackQ";
            this.Btn_BackQ.Size = new System.Drawing.Size(130, 34);
            this.Btn_BackQ.TabIndex = 3;
            this.Btn_BackQ.Text = "Прыдыдущий";
            this.Btn_BackQ.UseVisualStyleBackColor = true;
            this.Btn_BackQ.Click += new System.EventHandler(this.Btn_BackQ_Click);
            // 
            // Btn_ForwardQ
            // 
            this.Btn_ForwardQ.Location = new System.Drawing.Point(26, 190);
            this.Btn_ForwardQ.Name = "Btn_ForwardQ";
            this.Btn_ForwardQ.Size = new System.Drawing.Size(130, 34);
            this.Btn_ForwardQ.TabIndex = 3;
            this.Btn_ForwardQ.Text = "Следующий";
            this.Btn_ForwardQ.UseVisualStyleBackColor = true;
            this.Btn_ForwardQ.Click += new System.EventHandler(this.Btn_ForwardQ_Click);
            // 
            // Btn_DeleteQ
            // 
            this.Btn_DeleteQ.Location = new System.Drawing.Point(456, 245);
            this.Btn_DeleteQ.Name = "Btn_DeleteQ";
            this.Btn_DeleteQ.Size = new System.Drawing.Size(201, 34);
            this.Btn_DeleteQ.TabIndex = 3;
            this.Btn_DeleteQ.Text = "Удалить вопрос";
            this.Btn_DeleteQ.UseVisualStyleBackColor = true;
            this.Btn_DeleteQ.Click += new System.EventHandler(this.Btn_DeleteQ_Click);
            // 
            // ChkBox_Answer
            // 
            this.ChkBox_Answer.AutoSize = true;
            this.ChkBox_Answer.Location = new System.Drawing.Point(679, 138);
            this.ChkBox_Answer.Name = "ChkBox_Answer";
            this.ChkBox_Answer.Size = new System.Drawing.Size(80, 24);
            this.ChkBox_Answer.TabIndex = 2;
            this.ChkBox_Answer.Text = "верно";
            this.ChkBox_Answer.UseVisualStyleBackColor = true;
            // 
            // Lbl_QNumber
            // 
            this.Lbl_QNumber.AutoSize = true;
            this.Lbl_QNumber.Location = new System.Drawing.Point(22, 138);
            this.Lbl_QNumber.Name = "Lbl_QNumber";
            this.Lbl_QNumber.Size = new System.Drawing.Size(51, 20);
            this.Lbl_QNumber.TabIndex = 4;
            this.Lbl_QNumber.Text = "label1";
            // 
            // Btn_AddQ
            // 
            this.Btn_AddQ.Location = new System.Drawing.Point(203, 245);
            this.Btn_AddQ.Name = "Btn_AddQ";
            this.Btn_AddQ.Size = new System.Drawing.Size(201, 34);
            this.Btn_AddQ.TabIndex = 3;
            this.Btn_AddQ.Text = "Добавить вопрос";
            this.Btn_AddQ.UseVisualStyleBackColor = true;
            this.Btn_AddQ.Click += new System.EventHandler(this.Btn_AddQ_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl_QNumber);
            this.Controls.Add(this.Btn_AddQ);
            this.Controls.Add(this.Btn_DeleteQ);
            this.Controls.Add(this.Btn_ForwardQ);
            this.Controls.Add(this.Btn_BackQ);
            this.Controls.Add(this.ChkBox_Answer);
            this.Controls.Add(this.Text_Q);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu_openFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_saveFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_createFile;
        private System.Windows.Forms.RichTextBox Text_Q;
        private System.Windows.Forms.Button Btn_BackQ;
        private System.Windows.Forms.Button Btn_ForwardQ;
        private System.Windows.Forms.Button Btn_DeleteQ;
        private System.Windows.Forms.CheckBox ChkBox_Answer;
        private System.Windows.Forms.Label Lbl_QNumber;
        private System.Windows.Forms.Button Btn_AddQ;
    }
}