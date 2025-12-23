namespace Project.V8
{
    partial class FormAbout
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
            pictureBoxAva_DAA = new PictureBox();
            buttonNo = new Button();
            buttonYes = new Button();
            labelMe_DAA = new Label();
            labelQes_DAA = new Label();
            labelUp_DAA = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_DAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAva_DAA
            // 
            pictureBoxAva_DAA.Image = Properties.Resources.Ava;
            pictureBoxAva_DAA.Location = new Point(4, 12);
            pictureBoxAva_DAA.Name = "pictureBoxAva_DAA";
            pictureBoxAva_DAA.Size = new Size(179, 245);
            pictureBoxAva_DAA.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAva_DAA.TabIndex = 0;
            pictureBoxAva_DAA.TabStop = false;
            // 
            // buttonNo
            // 
            buttonNo.BackColor = Color.FromArgb(255, 224, 192);
            buttonNo.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonNo.Location = new Point(339, 219);
            buttonNo.Name = "buttonNo";
            buttonNo.Size = new Size(83, 50);
            buttonNo.TabIndex = 1;
            buttonNo.Text = "НЕТ";
            buttonNo.UseVisualStyleBackColor = false;
            buttonNo.Click += buttonNo_Click;
            // 
            // buttonYes
            // 
            buttonYes.BackColor = Color.FromArgb(255, 224, 192);
            buttonYes.Font = new Font("Calibri", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonYes.Location = new Point(231, 219);
            buttonYes.Name = "buttonYes";
            buttonYes.Size = new Size(87, 50);
            buttonYes.TabIndex = 0;
            buttonYes.Text = "ДА";
            buttonYes.UseVisualStyleBackColor = false;
            buttonYes.Click += buttonYes_Click;
            // 
            // labelMe_DAA
            // 
            labelMe_DAA.AutoSize = true;
            labelMe_DAA.BackColor = Color.FromArgb(255, 192, 192);
            labelMe_DAA.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelMe_DAA.Location = new Point(189, 12);
            labelMe_DAA.Name = "labelMe_DAA";
            labelMe_DAA.Size = new Size(311, 184);
            labelMe_DAA.TabIndex = 3;
            labelMe_DAA.Text = "Разработчик: Девятерикова А. А.\r\nГруппа ИИПБ-25-1\r\nПрограмма разработана в рамках \r\nизучения языка С#\r\nТИУ (с) 2025\r\nВШЦТ (с) 2025\r\n-------------------------------------------\r\n\r\n";
            // 
            // labelQes_DAA
            // 
            labelQes_DAA.AutoSize = true;
            labelQes_DAA.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelQes_DAA.Location = new Point(189, 170);
            labelQes_DAA.Name = "labelQes_DAA";
            labelQes_DAA.Size = new Size(275, 46);
            labelQes_DAA.TabIndex = 4;
            labelQes_DAA.Text = "У вас есть какие-нибудь вопросы\r\nили предложения?";
            // 
            // labelUp_DAA
            // 
            labelUp_DAA.AutoSize = true;
            labelUp_DAA.Location = new Point(174, 9);
            labelUp_DAA.Name = "labelUp_DAA";
            labelUp_DAA.Size = new Size(13, 260);
            labelUp_DAA.TabIndex = 5;
            labelUp_DAA.Text = "|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|\r\n|";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(482, 273);
            Controls.Add(labelUp_DAA);
            Controls.Add(labelQes_DAA);
            Controls.Add(buttonNo);
            Controls.Add(labelMe_DAA);
            Controls.Add(buttonYes);
            Controls.Add(pictureBoxAva_DAA);
            MaximizeBox = false;
            MaximumSize = new Size(500, 320);
            MinimizeBox = false;
            MinimumSize = new Size(500, 320);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Информация о разработчике";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAva_DAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAva_DAA;
        private Button buttonNo;
        private Button buttonYes;
        private Label labelMe_DAA;
        private Label labelQes_DAA;
        private Label labelUp_DAA;
    }
}