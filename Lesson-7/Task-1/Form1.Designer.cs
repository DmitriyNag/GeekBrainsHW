namespace Task_1
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
            this.components = new System.ComponentModel.Container();
            this.Btn_add = new System.Windows.Forms.Button();
            this.Btn_multi = new System.Windows.Forms.Button();
            this.Btn_reset = new System.Windows.Forms.Button();
            this.Lbl_result = new System.Windows.Forms.Label();
            this.Lbl_countName = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.игратьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.DoingsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.PlayMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Lbl_answr = new System.Windows.Forms.Label();
            this.Btn_return = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_add
            // 
            this.Btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_add.Location = new System.Drawing.Point(346, 36);
            this.Btn_add.Name = "Btn_add";
            this.Btn_add.Size = new System.Drawing.Size(120, 51);
            this.Btn_add.TabIndex = 0;
            this.Btn_add.Text = "+1";
            this.Btn_add.UseVisualStyleBackColor = true;
            this.Btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // Btn_multi
            // 
            this.Btn_multi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_multi.Location = new System.Drawing.Point(346, 93);
            this.Btn_multi.Name = "Btn_multi";
            this.Btn_multi.Size = new System.Drawing.Size(120, 51);
            this.Btn_multi.TabIndex = 0;
            this.Btn_multi.Text = "x2";
            this.Btn_multi.UseVisualStyleBackColor = true;
            this.Btn_multi.Click += new System.EventHandler(this.Btn_multi_Click);
            // 
            // Btn_reset
            // 
            this.Btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_reset.Location = new System.Drawing.Point(292, 266);
            this.Btn_reset.Name = "Btn_reset";
            this.Btn_reset.Size = new System.Drawing.Size(174, 51);
            this.Btn_reset.TabIndex = 0;
            this.Btn_reset.Text = "Сброс";
            this.Btn_reset.UseVisualStyleBackColor = true;
            this.Btn_reset.Click += new System.EventHandler(this.Btn_reset_Click);
            // 
            // Lbl_result
            // 
            this.Lbl_result.AutoSize = true;
            this.Lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_result.Location = new System.Drawing.Point(40, 79);
            this.Lbl_result.Name = "Lbl_result";
            this.Lbl_result.Size = new System.Drawing.Size(95, 36);
            this.Lbl_result.TabIndex = 1;
            this.Lbl_result.Text = "label1";
            // 
            // Lbl_countName
            // 
            this.Lbl_countName.AutoSize = true;
            this.Lbl_countName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_countName.Location = new System.Drawing.Point(12, 310);
            this.Lbl_countName.Name = "Lbl_countName";
            this.Lbl_countName.Size = new System.Drawing.Size(150, 25);
            this.Lbl_countName.TabIndex = 1;
            this.Lbl_countName.Text = "Кол - во ходов:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.игратьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(141, 34);
            // 
            // игратьToolStripMenuItem
            // 
            this.игратьToolStripMenuItem.Name = "игратьToolStripMenuItem";
            this.игратьToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.игратьToolStripMenuItem.Text = "Играть";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DoingsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(501, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // DoingsMenu
            // 
            this.DoingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayMenu});
            this.DoingsMenu.Name = "DoingsMenu";
            this.DoingsMenu.Size = new System.Drawing.Size(99, 29);
            this.DoingsMenu.Text = "Действия";
            // 
            // PlayMenu
            // 
            this.PlayMenu.Name = "PlayMenu";
            this.PlayMenu.Size = new System.Drawing.Size(152, 30);
            this.PlayMenu.Text = "Играть";
            this.PlayMenu.Click += new System.EventHandler(this.PlayMenu_Click);
            // 
            // Lbl_answr
            // 
            this.Lbl_answr.AutoSize = true;
            this.Lbl_answr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_answr.Location = new System.Drawing.Point(12, 266);
            this.Lbl_answr.Name = "Lbl_answr";
            this.Lbl_answr.Size = new System.Drawing.Size(0, 25);
            this.Lbl_answr.TabIndex = 1;
            // 
            // Btn_return
            // 
            this.Btn_return.Enabled = false;
            this.Btn_return.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_return.Location = new System.Drawing.Point(292, 176);
            this.Btn_return.Name = "Btn_return";
            this.Btn_return.Size = new System.Drawing.Size(174, 51);
            this.Btn_return.TabIndex = 0;
            this.Btn_return.Text = "Отменить";
            this.Btn_return.UseVisualStyleBackColor = true;
            this.Btn_return.Click += new System.EventHandler(this.Btn_rewind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 344);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Lbl_answr);
            this.Controls.Add(this.Lbl_countName);
            this.Controls.Add(this.Lbl_result);
            this.Controls.Add(this.Btn_return);
            this.Controls.Add(this.Btn_reset);
            this.Controls.Add(this.Btn_multi);
            this.Controls.Add(this.Btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_add;
        private System.Windows.Forms.Button Btn_multi;
        private System.Windows.Forms.Button Btn_reset;
        private System.Windows.Forms.Label Lbl_result;
        private System.Windows.Forms.Label Lbl_countName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem игратьToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DoingsMenu;
        private System.Windows.Forms.ToolStripMenuItem PlayMenu;
        private System.Windows.Forms.Label Lbl_answr;
        private System.Windows.Forms.Button Btn_return;
    }
}

