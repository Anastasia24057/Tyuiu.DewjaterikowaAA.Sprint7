namespace Project.V8
{
    partial class FormNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNo));
            pictureBoxHappyNewYear_DAA = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHappyNewYear_DAA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxHappyNewYear_DAA
            // 
            pictureBoxHappyNewYear_DAA.Dock = DockStyle.Fill;
            pictureBoxHappyNewYear_DAA.Image = (Image)resources.GetObject("pictureBoxHappyNewYear_DAA.Image");
            pictureBoxHappyNewYear_DAA.Location = new Point(0, 0);
            pictureBoxHappyNewYear_DAA.Name = "pictureBoxHappyNewYear_DAA";
            pictureBoxHappyNewYear_DAA.Size = new Size(603, 334);
            pictureBoxHappyNewYear_DAA.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxHappyNewYear_DAA.TabIndex = 0;
            pictureBoxHappyNewYear_DAA.TabStop = false;
            // 
            // FormNo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 334);
            Controls.Add(pictureBoxHappyNewYear_DAA);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "С НОВЫМ ГОДОМ";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pictureBoxHappyNewYear_DAA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxHappyNewYear_DAA;
    }
}