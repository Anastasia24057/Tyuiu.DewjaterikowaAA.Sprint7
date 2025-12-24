namespace Project.V8
{
    partial class FormYes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYes));
            pictureBoxYes_DAA = new PictureBox();
            textBoxConnect_DAA = new TextBox();
            buttonOKYES_DAA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxYes_DAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxYes_DAA
            // 
            pictureBoxYes_DAA.Dock = DockStyle.Fill;
            pictureBoxYes_DAA.Image = (Image)resources.GetObject("pictureBoxYes_DAA.Image");
            pictureBoxYes_DAA.Location = new Point(0, 0);
            pictureBoxYes_DAA.Name = "pictureBoxYes_DAA";
            pictureBoxYes_DAA.Size = new Size(462, 263);
            pictureBoxYes_DAA.TabIndex = 0;
            pictureBoxYes_DAA.TabStop = false;
            // 
            // textBoxConnect_DAA
            // 
            textBoxConnect_DAA.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 204);
            textBoxConnect_DAA.Location = new Point(12, 9);
            textBoxConnect_DAA.Multiline = true;
            textBoxConnect_DAA.Name = "textBoxConnect_DAA";
            textBoxConnect_DAA.ReadOnly = true;
            textBoxConnect_DAA.Size = new Size(438, 242);
            textBoxConnect_DAA.TabIndex = 1;
            textBoxConnect_DAA.TabStop = false;
            textBoxConnect_DAA.Text = resources.GetString("textBoxConnect_DAA.Text");
            // 
            // buttonOKYES_DAA
            // 
            buttonOKYES_DAA.BackColor = SystemColors.ActiveCaption;
            buttonOKYES_DAA.Location = new Point(336, 200);
            buttonOKYES_DAA.Name = "buttonOKYES_DAA";
            buttonOKYES_DAA.Size = new Size(94, 42);
            buttonOKYES_DAA.TabIndex = 2;
            buttonOKYES_DAA.Text = "OK";
            buttonOKYES_DAA.UseVisualStyleBackColor = false;
            buttonOKYES_DAA.Click += buttonOKYES_DAA_Click;
            // 
            // FormYes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 263);
            Controls.Add(buttonOKYES_DAA);
            Controls.Add(textBoxConnect_DAA);
            Controls.Add(pictureBoxYes_DAA);
            MaximizeBox = false;
            MaximumSize = new Size(480, 310);
            MinimizeBox = false;
            MinimumSize = new Size(480, 310);
            Name = "FormYes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Связь";
            ((System.ComponentModel.ISupportInitialize)pictureBoxYes_DAA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxYes_DAA;
        private TextBox textBoxConnect_DAA;
        private Button buttonOKYES_DAA;
    }
}