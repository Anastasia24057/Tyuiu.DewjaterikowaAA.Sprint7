namespace Project.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_DAA = new Panel();
            groupBoxAboutMe_DAA = new GroupBox();
            buttonInfo_DAA = new Button();
            groupBoxFilter_DAA = new GroupBox();
            labelRow_DAA = new Label();
            labelRows_DAA = new Label();
            buttonFilter_DAA = new Button();
            textBoxFilter_DAA = new TextBox();
            comboBoxCols_DAA = new ComboBox();
            groupBoxRows_DAA = new GroupBox();
            buttonDelRows_DAA = new Button();
            groupBoxFile_DAA = new GroupBox();
            buttonOpenFile_DAA = new Button();
            buttonSaveFile_DAA = new Button();
            panelFill_DAA = new Panel();
            tabControlBase_DAA = new TabControl();
            tabArenda = new TabPage();
            dataGridViewLimo_DAA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabStatic = new TabPage();
            groupBox1 = new GroupBox();
            openFileDialogLimo_DAA = new OpenFileDialog();
            saveFileDialogLimo_DAA = new SaveFileDialog();
            panelTop_DAA.SuspendLayout();
            groupBoxAboutMe_DAA.SuspendLayout();
            groupBoxFilter_DAA.SuspendLayout();
            groupBoxRows_DAA.SuspendLayout();
            groupBoxFile_DAA.SuspendLayout();
            panelFill_DAA.SuspendLayout();
            tabControlBase_DAA.SuspendLayout();
            tabArenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLimo_DAA).BeginInit();
            tabStatic.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_DAA
            // 
            panelTop_DAA.Controls.Add(groupBoxAboutMe_DAA);
            panelTop_DAA.Controls.Add(groupBoxFilter_DAA);
            panelTop_DAA.Controls.Add(groupBoxRows_DAA);
            panelTop_DAA.Controls.Add(groupBoxFile_DAA);
            panelTop_DAA.Dock = DockStyle.Top;
            panelTop_DAA.Location = new Point(0, 0);
            panelTop_DAA.Name = "panelTop_DAA";
            panelTop_DAA.Size = new Size(1099, 115);
            panelTop_DAA.TabIndex = 0;
            // 
            // groupBoxAboutMe_DAA
            // 
            groupBoxAboutMe_DAA.BackColor = Color.FromArgb(255, 192, 192);
            groupBoxAboutMe_DAA.Controls.Add(buttonInfo_DAA);
            groupBoxAboutMe_DAA.Dock = DockStyle.Right;
            groupBoxAboutMe_DAA.Location = new Point(936, 0);
            groupBoxAboutMe_DAA.Name = "groupBoxAboutMe_DAA";
            groupBoxAboutMe_DAA.Size = new Size(163, 115);
            groupBoxAboutMe_DAA.TabIndex = 7;
            groupBoxAboutMe_DAA.TabStop = false;
            groupBoxAboutMe_DAA.Enter += groupBoxAboutMe_DAA_Enter;
            // 
            // buttonInfo_DAA
            // 
            buttonInfo_DAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_DAA.BackgroundImage = Properties.Resources.information;
            buttonInfo_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonInfo_DAA.Location = new Point(34, 29);
            buttonInfo_DAA.Name = "buttonInfo_DAA";
            buttonInfo_DAA.Size = new Size(97, 65);
            buttonInfo_DAA.TabIndex = 1;
            buttonInfo_DAA.UseVisualStyleBackColor = true;
            buttonInfo_DAA.Click += buttonInfo_DAA_Click;
            // 
            // groupBoxFilter_DAA
            // 
            groupBoxFilter_DAA.BackColor = Color.FromArgb(192, 255, 255);
            groupBoxFilter_DAA.Controls.Add(labelRow_DAA);
            groupBoxFilter_DAA.Controls.Add(labelRows_DAA);
            groupBoxFilter_DAA.Controls.Add(buttonFilter_DAA);
            groupBoxFilter_DAA.Controls.Add(textBoxFilter_DAA);
            groupBoxFilter_DAA.Controls.Add(comboBoxCols_DAA);
            groupBoxFilter_DAA.Dock = DockStyle.Fill;
            groupBoxFilter_DAA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxFilter_DAA.Location = new Point(671, 0);
            groupBoxFilter_DAA.Name = "groupBoxFilter_DAA";
            groupBoxFilter_DAA.Size = new Size(428, 115);
            groupBoxFilter_DAA.TabIndex = 6;
            groupBoxFilter_DAA.TabStop = false;
            groupBoxFilter_DAA.Text = "                        ФИЛЬТРАЦИЯ";
            // 
            // labelRow_DAA
            // 
            labelRow_DAA.AutoSize = true;
            labelRow_DAA.Location = new Point(234, 29);
            labelRow_DAA.Name = "labelRow_DAA";
            labelRow_DAA.Size = new Size(198, 28);
            labelRow_DAA.TabIndex = 4;
            labelRow_DAA.Text = "Ключ для фильтра";
            // 
            // labelRows_DAA
            // 
            labelRows_DAA.AutoSize = true;
            labelRows_DAA.Location = new Point(15, 29);
            labelRows_DAA.Name = "labelRows_DAA";
            labelRows_DAA.Size = new Size(194, 28);
            labelRows_DAA.TabIndex = 3;
            labelRows_DAA.Text = "Выберите столбец";
            // 
            // buttonFilter_DAA
            // 
            buttonFilter_DAA.BackColor = Color.FromArgb(255, 192, 255);
            buttonFilter_DAA.BackgroundImage = (Image)resources.GetObject("buttonFilter_DAA.BackgroundImage");
            buttonFilter_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonFilter_DAA.Location = new Point(465, 30);
            buttonFilter_DAA.Name = "buttonFilter_DAA";
            buttonFilter_DAA.Size = new Size(109, 67);
            buttonFilter_DAA.TabIndex = 2;
            buttonFilter_DAA.UseVisualStyleBackColor = false;
            buttonFilter_DAA.Click += buttonFilter_DAA_Click;
            // 
            // textBoxFilter_DAA
            // 
            textBoxFilter_DAA.Location = new Point(234, 57);
            textBoxFilter_DAA.Name = "textBoxFilter_DAA";
            textBoxFilter_DAA.Size = new Size(183, 34);
            textBoxFilter_DAA.TabIndex = 1;
            textBoxFilter_DAA.TextChanged += textBox1_TextChanged;
            // 
            // comboBoxCols_DAA
            // 
            comboBoxCols_DAA.FormattingEnabled = true;
            comboBoxCols_DAA.Items.AddRange(new object[] { "ID лимузина", "Марка", "Модель", "Год выпуска", "Цвет", "Количество мест", "Цена за сутки (руб)" });
            comboBoxCols_DAA.Location = new Point(15, 57);
            comboBoxCols_DAA.Name = "comboBoxCols_DAA";
            comboBoxCols_DAA.Size = new Size(198, 36);
            comboBoxCols_DAA.TabIndex = 0;
            comboBoxCols_DAA.SelectedIndexChanged += comboBoxCols_DAA_SelectedIndexChanged_1;
            // 
            // groupBoxRows_DAA
            // 
            groupBoxRows_DAA.BackColor = Color.FromArgb(255, 255, 192);
            groupBoxRows_DAA.Controls.Add(buttonDelRows_DAA);
            groupBoxRows_DAA.Dock = DockStyle.Left;
            groupBoxRows_DAA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxRows_DAA.Location = new Point(408, 0);
            groupBoxRows_DAA.Name = "groupBoxRows_DAA";
            groupBoxRows_DAA.Size = new Size(263, 115);
            groupBoxRows_DAA.TabIndex = 5;
            groupBoxRows_DAA.TabStop = false;
            groupBoxRows_DAA.Text = "    УДАЛИТЬ СТРОКИ";
            // 
            // buttonDelRows_DAA
            // 
            buttonDelRows_DAA.BackColor = Color.PeachPuff;
            buttonDelRows_DAA.BackgroundImage = (Image)resources.GetObject("buttonDelRows_DAA.BackgroundImage");
            buttonDelRows_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonDelRows_DAA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDelRows_DAA.Location = new Point(70, 30);
            buttonDelRows_DAA.Name = "buttonDelRows_DAA";
            buttonDelRows_DAA.Size = new Size(118, 79);
            buttonDelRows_DAA.TabIndex = 3;
            buttonDelRows_DAA.UseVisualStyleBackColor = false;
            buttonDelRows_DAA.Click += buttonDelRows_DAA_Click;
            // 
            // groupBoxFile_DAA
            // 
            groupBoxFile_DAA.BackColor = Color.FromArgb(128, 255, 128);
            groupBoxFile_DAA.Controls.Add(buttonOpenFile_DAA);
            groupBoxFile_DAA.Controls.Add(buttonSaveFile_DAA);
            groupBoxFile_DAA.Dock = DockStyle.Left;
            groupBoxFile_DAA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxFile_DAA.Location = new Point(0, 0);
            groupBoxFile_DAA.Name = "groupBoxFile_DAA";
            groupBoxFile_DAA.Size = new Size(408, 115);
            groupBoxFile_DAA.TabIndex = 4;
            groupBoxFile_DAA.TabStop = false;
            groupBoxFile_DAA.Text = "      ЗАГРУЗКА/СОХРАНЕНИЕ ФАЙЛА";
            // 
            // buttonOpenFile_DAA
            // 
            buttonOpenFile_DAA.BackColor = Color.FromArgb(192, 192, 255);
            buttonOpenFile_DAA.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_DAA.BackgroundImage");
            buttonOpenFile_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_DAA.Location = new Point(75, 34);
            buttonOpenFile_DAA.Name = "buttonOpenFile_DAA";
            buttonOpenFile_DAA.Size = new Size(115, 78);
            buttonOpenFile_DAA.TabIndex = 0;
            buttonOpenFile_DAA.UseVisualStyleBackColor = false;
            buttonOpenFile_DAA.Click += buttonOpenFile_DAA_Click;
            // 
            // buttonSaveFile_DAA
            // 
            buttonSaveFile_DAA.BackColor = Color.FromArgb(192, 192, 255);
            buttonSaveFile_DAA.BackgroundImage = (Image)resources.GetObject("buttonSaveFile_DAA.BackgroundImage");
            buttonSaveFile_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_DAA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSaveFile_DAA.Location = new Point(196, 33);
            buttonSaveFile_DAA.Name = "buttonSaveFile_DAA";
            buttonSaveFile_DAA.Size = new Size(115, 79);
            buttonSaveFile_DAA.TabIndex = 2;
            buttonSaveFile_DAA.UseVisualStyleBackColor = false;
            buttonSaveFile_DAA.Click += buttonSaveFile_DAA_Click;
            // 
            // panelFill_DAA
            // 
            panelFill_DAA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFill_DAA.Controls.Add(tabControlBase_DAA);
            panelFill_DAA.Dock = DockStyle.Fill;
            panelFill_DAA.Location = new Point(0, 115);
            panelFill_DAA.Name = "panelFill_DAA";
            panelFill_DAA.Size = new Size(1099, 419);
            panelFill_DAA.TabIndex = 1;
            // 
            // tabControlBase_DAA
            // 
            tabControlBase_DAA.Controls.Add(tabArenda);
            tabControlBase_DAA.Controls.Add(tabStatic);
            tabControlBase_DAA.Dock = DockStyle.Fill;
            tabControlBase_DAA.Location = new Point(0, 0);
            tabControlBase_DAA.Name = "tabControlBase_DAA";
            tabControlBase_DAA.SelectedIndex = 0;
            tabControlBase_DAA.Size = new Size(1099, 419);
            tabControlBase_DAA.TabIndex = 0;
            // 
            // tabArenda
            // 
            tabArenda.BackColor = Color.FromArgb(255, 192, 192);
            tabArenda.Controls.Add(dataGridViewLimo_DAA);
            tabArenda.ForeColor = SystemColors.ActiveCaptionText;
            tabArenda.Location = new Point(4, 29);
            tabArenda.Name = "tabArenda";
            tabArenda.Padding = new Padding(3, 3, 3, 3);
            tabArenda.Size = new Size(1091, 386);
            tabArenda.TabIndex = 0;
            tabArenda.Text = "Аренда";
            // 
            // dataGridViewLimo_DAA
            // 
            dataGridViewLimo_DAA.AllowUserToAddRows = false;
            dataGridViewLimo_DAA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLimo_DAA.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dataGridViewLimo_DAA.Dock = DockStyle.Fill;
            dataGridViewLimo_DAA.Location = new Point(3, 3);
            dataGridViewLimo_DAA.Name = "dataGridViewLimo_DAA";
            dataGridViewLimo_DAA.RowHeadersVisible = false;
            dataGridViewLimo_DAA.RowHeadersWidth = 50;
            dataGridViewLimo_DAA.Size = new Size(1085, 380);
            dataGridViewLimo_DAA.TabIndex = 0;
            dataGridViewLimo_DAA.CellContentClick += dataGridViewLimo_DAA_CellContentClick;
            dataGridViewLimo_DAA.RowPrePaint += dataGridViewLimo_DAA_RowPrePaint;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID лимузина";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Марка";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 200;
            // 
            // Column3
            // 
            Column3.HeaderText = "Модель";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 200;
            // 
            // Column4
            // 
            Column4.HeaderText = "Год выпуска";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 200;
            // 
            // Column5
            // 
            Column5.HeaderText = "Цвет";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 200;
            // 
            // Column6
            // 
            Column6.HeaderText = "Количество мест";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 260;
            // 
            // Column7
            // 
            Column7.HeaderText = "Цена за сутки (руб)";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 260;
            // 
            // tabStatic
            // 
            tabStatic.BackColor = Color.FromArgb(255, 192, 192);
            tabStatic.Controls.Add(groupBox1);
            tabStatic.Location = new Point(4, 29);
            tabStatic.Name = "tabStatic";
            tabStatic.Padding = new Padding(3, 3, 3, 3);
            tabStatic.Size = new Size(1215, 386);
            tabStatic.TabIndex = 1;
            tabStatic.Text = "Статистика";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(19, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // openFileDialogLimo_DAA
            // 
            openFileDialogLimo_DAA.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1099, 534);
            Controls.Add(panelFill_DAA);
            Controls.Add(panelTop_DAA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " LIMOUSINE RENTAL";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panelTop_DAA.ResumeLayout(false);
            groupBoxAboutMe_DAA.ResumeLayout(false);
            groupBoxFilter_DAA.ResumeLayout(false);
            groupBoxFilter_DAA.PerformLayout();
            groupBoxRows_DAA.ResumeLayout(false);
            groupBoxFile_DAA.ResumeLayout(false);
            panelFill_DAA.ResumeLayout(false);
            tabControlBase_DAA.ResumeLayout(false);
            tabArenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLimo_DAA).EndInit();
            tabStatic.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_DAA;
        private Panel panelFill_DAA;
        private TabControl tabControlBase_DAA;
        private TabPage tabArenda;
        private DataGridView dataGridViewLimo_DAA;
        private TabPage tabStatic;
        private Button buttonOpenFile_DAA;
        private OpenFileDialog openFileDialogLimo_DAA;
        private Button buttonInfo_DAA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button buttonSaveFile_DAA;
        private GroupBox groupBoxFile_DAA;
        private Button buttonDelRows_DAA;
        private GroupBox groupBoxRows_DAA;
        private GroupBox groupBox1;
        private GroupBox groupBoxFilter_DAA;
        private ComboBox comboBoxCols_DAA;
        private TextBox textBoxFilter_DAA;
        private Label labelRow_DAA;
        private Label labelRows_DAA;
        private Button buttonFilter_DAA;
        private GroupBox groupBoxAboutMe_DAA;
        private SaveFileDialog saveFileDialogLimo_DAA;
    }
}
