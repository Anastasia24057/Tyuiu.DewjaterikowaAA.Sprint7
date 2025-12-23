namespace Project.V8
{
    partial class FormReminder
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
            textBoxRemind_DAA = new TextBox();
            SuspendLayout();
            // 
            // textBoxRemind_DAA
            // 
            textBoxRemind_DAA.Dock = DockStyle.Fill;
            textBoxRemind_DAA.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxRemind_DAA.Location = new Point(0, 0);
            textBoxRemind_DAA.Multiline = true;
            textBoxRemind_DAA.Name = "textBoxRemind_DAA";
            textBoxRemind_DAA.ReadOnly = true;
            textBoxRemind_DAA.Size = new Size(552, 296);
            textBoxRemind_DAA.TabIndex = 0;
            textBoxRemind_DAA.Text = "Программа предназначена для работы с базой данных.\r\n\r\nВам предлагается работа с базой данных:\r\n- Открытие\r\n- Сохранение\r\n- Фильтрация\r\n- Поиск \r\n- Редактирование\r\n\r\nА также просмотр статистики";
            // 
            // FormReminder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 296);
            Controls.Add(textBoxRemind_DAA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormReminder";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ПАМЯТКА";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxRemind_DAA;
    }
}