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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_DAA = new Panel();
            groupBoxAboutMe_DAA = new GroupBox();
            buttonReminder_DAA = new Button();
            buttonInfo_DAA = new Button();
            groupBoxFilter_DAA = new GroupBox();
            labelSearch_DAA = new Label();
            buttonFilter_DAA = new Button();
            textBoxSearch_DAA = new TextBox();
            labelRow_DAA = new Label();
            labelRows_DAA = new Label();
            textBoxFilter_DAA = new TextBox();
            comboBoxCols_DAA = new ComboBox();
            groupBoxRows_DAA = new GroupBox();
            buttonDelRows_DAA = new Button();
            groupBoxFile_DAA = new GroupBox();
            buttonOpenFile_DAA = new Button();
            buttonSaveFile_DAA = new Button();
            panelFill_DAA = new Panel();
            tabControlBase_DAA = new TabControl();
            tabArenda_DAA = new TabPage();
            dataGridViewLimo_DAA = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tabStatic_DAA = new TabPage();
            groupBox_DAA = new GroupBox();
            openFileDialogLimo_DAA = new OpenFileDialog();
            saveFileDialogLimo_DAA = new SaveFileDialog();
            toolTipLimo_DAA = new ToolTip(components);
            panelTop_DAA.SuspendLayout();
            groupBoxAboutMe_DAA.SuspendLayout();
            groupBoxFilter_DAA.SuspendLayout();
            groupBoxRows_DAA.SuspendLayout();
            groupBoxFile_DAA.SuspendLayout();
            panelFill_DAA.SuspendLayout();
            tabControlBase_DAA.SuspendLayout();
            tabArenda_DAA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLimo_DAA).BeginInit();
            tabStatic_DAA.SuspendLayout();
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
            panelTop_DAA.Size = new Size(1099, 136);
            panelTop_DAA.TabIndex = 0;
            // 
            // groupBoxAboutMe_DAA
            // 
            groupBoxAboutMe_DAA.BackColor = Color.FromArgb(255, 192, 192);
            groupBoxAboutMe_DAA.Controls.Add(buttonReminder_DAA);
            groupBoxAboutMe_DAA.Controls.Add(buttonInfo_DAA);
            groupBoxAboutMe_DAA.Dock = DockStyle.Right;
            groupBoxAboutMe_DAA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxAboutMe_DAA.Location = new Point(806, 0);
            groupBoxAboutMe_DAA.Name = "groupBoxAboutMe_DAA";
            groupBoxAboutMe_DAA.Size = new Size(293, 136);
            groupBoxAboutMe_DAA.TabIndex = 7;
            groupBoxAboutMe_DAA.TabStop = false;
            groupBoxAboutMe_DAA.Text = "       ИНФОРМАЦИЯ";
            groupBoxAboutMe_DAA.Enter += groupBoxAboutMe_DAA_Enter;
            // 
            // buttonReminder_DAA
            // 
            buttonReminder_DAA.ForeColor = SystemColors.ControlDark;
            buttonReminder_DAA.Image = Properties.Resources.wand;
            buttonReminder_DAA.Location = new Point(26, 47);
            buttonReminder_DAA.Name = "buttonReminder_DAA";
            buttonReminder_DAA.Size = new Size(113, 72);
            buttonReminder_DAA.TabIndex = 2;
            toolTipLimo_DAA.SetToolTip(buttonReminder_DAA, "Нажмите, и ознакомьтесь со сведениями о приложении");
            buttonReminder_DAA.UseVisualStyleBackColor = true;
            buttonReminder_DAA.MouseEnter += buttonReminder_DAA_MouseEnter;
            // 
            // buttonInfo_DAA
            // 
            buttonInfo_DAA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonInfo_DAA.BackgroundImage = Properties.Resources.information;
            buttonInfo_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonInfo_DAA.Location = new Point(169, 47);
            buttonInfo_DAA.Name = "buttonInfo_DAA";
            buttonInfo_DAA.Size = new Size(112, 72);
            buttonInfo_DAA.TabIndex = 1;
            toolTipLimo_DAA.SetToolTip(buttonInfo_DAA, "Нажмите и ознакомьтесь со сведениями о разработчике");
            buttonInfo_DAA.UseVisualStyleBackColor = true;
            buttonInfo_DAA.Click += buttonInfo_DAA_Click;
            buttonInfo_DAA.MouseEnter += buttonInfo_DAA_MouseEnter;
            // 
            // groupBoxFilter_DAA
            // 
            groupBoxFilter_DAA.BackColor = Color.FromArgb(192, 255, 255);
            groupBoxFilter_DAA.Controls.Add(labelSearch_DAA);
            groupBoxFilter_DAA.Controls.Add(buttonFilter_DAA);
            groupBoxFilter_DAA.Controls.Add(textBoxSearch_DAA);
            groupBoxFilter_DAA.Controls.Add(labelRow_DAA);
            groupBoxFilter_DAA.Controls.Add(labelRows_DAA);
            groupBoxFilter_DAA.Controls.Add(textBoxFilter_DAA);
            groupBoxFilter_DAA.Controls.Add(comboBoxCols_DAA);
            groupBoxFilter_DAA.Dock = DockStyle.Fill;
            groupBoxFilter_DAA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxFilter_DAA.Location = new Point(714, 0);
            groupBoxFilter_DAA.Name = "groupBoxFilter_DAA";
            groupBoxFilter_DAA.Size = new Size(385, 136);
            groupBoxFilter_DAA.TabIndex = 6;
            groupBoxFilter_DAA.TabStop = false;
            groupBoxFilter_DAA.Text = "                        ФИЛЬТРАЦИЯ И ПОИСК";
            // 
            // labelSearch_DAA
            // 
            labelSearch_DAA.AutoSize = true;
            labelSearch_DAA.Location = new Point(50, 37);
            labelSearch_DAA.Name = "labelSearch_DAA";
            labelSearch_DAA.Size = new Size(84, 31);
            labelSearch_DAA.TabIndex = 6;
            labelSearch_DAA.Text = "Поиск";
            // 
            // buttonFilter_DAA
            // 
            buttonFilter_DAA.BackColor = Color.FromArgb(255, 192, 255);
            buttonFilter_DAA.BackgroundImage = (Image)resources.GetObject("buttonFilter_DAA.BackgroundImage");
            buttonFilter_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonFilter_DAA.Location = new Point(782, 42);
            buttonFilter_DAA.Name = "buttonFilter_DAA";
            buttonFilter_DAA.Size = new Size(109, 67);
            buttonFilter_DAA.TabIndex = 2;
            toolTipLimo_DAA.SetToolTip(buttonFilter_DAA, "Отфильтровать данные в таблице");
            buttonFilter_DAA.UseVisualStyleBackColor = false;
            buttonFilter_DAA.Click += buttonFilter_DAA_Click;
            buttonFilter_DAA.MouseEnter += buttonFilter_DAA_MouseEnter;
            // 
            // textBoxSearch_DAA
            // 
            textBoxSearch_DAA.Location = new Point(50, 69);
            textBoxSearch_DAA.Name = "textBoxSearch_DAA";
            textBoxSearch_DAA.Size = new Size(186, 38);
            textBoxSearch_DAA.TabIndex = 5;
            textBoxSearch_DAA.TextChanged += textBoxSearch_DAA_TextChanged;
            // 
            // labelRow_DAA
            // 
            labelRow_DAA.AutoSize = true;
            labelRow_DAA.Location = new Point(531, 34);
            labelRow_DAA.Name = "labelRow_DAA";
            labelRow_DAA.Size = new Size(225, 31);
            labelRow_DAA.TabIndex = 4;
            labelRow_DAA.Text = "Ключ для фильтра";
            // 
            // labelRows_DAA
            // 
            labelRows_DAA.AutoSize = true;
            labelRows_DAA.Location = new Point(279, 30);
            labelRows_DAA.Name = "labelRows_DAA";
            labelRows_DAA.Size = new Size(220, 31);
            labelRows_DAA.TabIndex = 3;
            labelRows_DAA.Text = "Выберите столбец";
            // 
            // textBoxFilter_DAA
            // 
            textBoxFilter_DAA.Location = new Point(531, 69);
            textBoxFilter_DAA.Name = "textBoxFilter_DAA";
            textBoxFilter_DAA.Size = new Size(183, 38);
            textBoxFilter_DAA.TabIndex = 1;
            textBoxFilter_DAA.TextChanged += textBox1_TextChanged;
            // 
            // comboBoxCols_DAA
            // 
            comboBoxCols_DAA.FormattingEnabled = true;
            comboBoxCols_DAA.Items.AddRange(new object[] { "ID лимузина", "Марка", "Модель", "Год выпуска", "Цвет", "Количество мест", "Цена за сутки (руб)" });
            comboBoxCols_DAA.Location = new Point(279, 65);
            comboBoxCols_DAA.Name = "comboBoxCols_DAA";
            comboBoxCols_DAA.Size = new Size(198, 39);
            comboBoxCols_DAA.TabIndex = 0;
            comboBoxCols_DAA.SelectedIndexChanged += comboBoxCols_DAA_SelectedIndexChanged_1;
            // 
            // groupBoxRows_DAA
            // 
            groupBoxRows_DAA.BackColor = Color.FromArgb(255, 255, 192);
            groupBoxRows_DAA.Controls.Add(buttonDelRows_DAA);
            groupBoxRows_DAA.Dock = DockStyle.Left;
            groupBoxRows_DAA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxRows_DAA.Location = new Point(404, 0);
            groupBoxRows_DAA.Name = "groupBoxRows_DAA";
            groupBoxRows_DAA.Size = new Size(310, 136);
            groupBoxRows_DAA.TabIndex = 5;
            groupBoxRows_DAA.TabStop = false;
            groupBoxRows_DAA.Text = "  ИЗМЕНИТЬ ДАННЫЕ";
            // 
            // buttonDelRows_DAA
            // 
            buttonDelRows_DAA.BackColor = Color.PeachPuff;
            buttonDelRows_DAA.BackgroundImage = (Image)resources.GetObject("buttonDelRows_DAA.BackgroundImage");
            buttonDelRows_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonDelRows_DAA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonDelRows_DAA.Location = new Point(90, 37);
            buttonDelRows_DAA.Name = "buttonDelRows_DAA";
            buttonDelRows_DAA.Size = new Size(118, 79);
            buttonDelRows_DAA.TabIndex = 3;
            toolTipLimo_DAA.SetToolTip(buttonDelRows_DAA, "Удаление строк из таблицы");
            buttonDelRows_DAA.UseVisualStyleBackColor = false;
            buttonDelRows_DAA.Click += buttonDelRows_DAA_Click;
            buttonDelRows_DAA.MouseEnter += buttonDelRows_DAA_MouseEnter;
            // 
            // groupBoxFile_DAA
            // 
            groupBoxFile_DAA.BackColor = Color.FromArgb(128, 255, 128);
            groupBoxFile_DAA.Controls.Add(buttonOpenFile_DAA);
            groupBoxFile_DAA.Controls.Add(buttonSaveFile_DAA);
            groupBoxFile_DAA.Dock = DockStyle.Left;
            groupBoxFile_DAA.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxFile_DAA.Location = new Point(0, 0);
            groupBoxFile_DAA.Name = "groupBoxFile_DAA";
            groupBoxFile_DAA.Size = new Size(404, 136);
            groupBoxFile_DAA.TabIndex = 4;
            groupBoxFile_DAA.TabStop = false;
            groupBoxFile_DAA.Text = "ЗАГРУЗКА/СОХРАНЕНИЕ ФАЙЛА";
            // 
            // buttonOpenFile_DAA
            // 
            buttonOpenFile_DAA.BackColor = Color.FromArgb(192, 192, 255);
            buttonOpenFile_DAA.BackgroundImage = (Image)resources.GetObject("buttonOpenFile_DAA.BackgroundImage");
            buttonOpenFile_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_DAA.Location = new Point(76, 35);
            buttonOpenFile_DAA.Name = "buttonOpenFile_DAA";
            buttonOpenFile_DAA.Size = new Size(115, 78);
            buttonOpenFile_DAA.TabIndex = 0;
            toolTipLimo_DAA.SetToolTip(buttonOpenFile_DAA, "Открыть файл для обработки данных в формате CSV");
            buttonOpenFile_DAA.UseVisualStyleBackColor = false;
            buttonOpenFile_DAA.Click += buttonOpenFile_DAA_Click;
            buttonOpenFile_DAA.MouseEnter += buttonOpenFile_DAA_MouseEnter;
            // 
            // buttonSaveFile_DAA
            // 
            buttonSaveFile_DAA.BackColor = Color.FromArgb(192, 192, 255);
            buttonSaveFile_DAA.BackgroundImage = (Image)resources.GetObject("buttonSaveFile_DAA.BackgroundImage");
            buttonSaveFile_DAA.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_DAA.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSaveFile_DAA.Location = new Point(207, 35);
            buttonSaveFile_DAA.Name = "buttonSaveFile_DAA";
            buttonSaveFile_DAA.Size = new Size(115, 79);
            buttonSaveFile_DAA.TabIndex = 2;
            toolTipLimo_DAA.SetToolTip(buttonSaveFile_DAA, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_DAA.UseVisualStyleBackColor = false;
            buttonSaveFile_DAA.Click += buttonSaveFile_DAA_Click;
            buttonSaveFile_DAA.MouseEnter += buttonSaveFile_DAA_MouseEnter;
            // 
            // panelFill_DAA
            // 
            panelFill_DAA.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelFill_DAA.Controls.Add(tabControlBase_DAA);
            panelFill_DAA.Dock = DockStyle.Fill;
            panelFill_DAA.Location = new Point(0, 136);
            panelFill_DAA.Name = "panelFill_DAA";
            panelFill_DAA.Size = new Size(1099, 398);
            panelFill_DAA.TabIndex = 1;
            // 
            // tabControlBase_DAA
            // 
            tabControlBase_DAA.Controls.Add(tabArenda_DAA);
            tabControlBase_DAA.Controls.Add(tabStatic_DAA);
            tabControlBase_DAA.Dock = DockStyle.Fill;
            tabControlBase_DAA.Location = new Point(0, 0);
            tabControlBase_DAA.Name = "tabControlBase_DAA";
            tabControlBase_DAA.SelectedIndex = 0;
            tabControlBase_DAA.Size = new Size(1099, 398);
            tabControlBase_DAA.TabIndex = 0;
            // 
            // tabArenda_DAA
            // 
            tabArenda_DAA.BackColor = Color.FromArgb(255, 192, 192);
            tabArenda_DAA.Controls.Add(dataGridViewLimo_DAA);
            tabArenda_DAA.ForeColor = SystemColors.ActiveCaptionText;
            tabArenda_DAA.Location = new Point(4, 29);
            tabArenda_DAA.Name = "tabArenda_DAA";
            tabArenda_DAA.Padding = new Padding(3);
            tabArenda_DAA.Size = new Size(1091, 365);
            tabArenda_DAA.TabIndex = 0;
            tabArenda_DAA.Text = "Аренда";
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
            dataGridViewLimo_DAA.Size = new Size(1085, 359);
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
            // tabStatic_DAA
            // 
            tabStatic_DAA.BackColor = Color.FromArgb(255, 192, 192);
            tabStatic_DAA.Controls.Add(groupBox_DAA);
            tabStatic_DAA.Location = new Point(4, 29);
            tabStatic_DAA.Name = "tabStatic_DAA";
            tabStatic_DAA.Padding = new Padding(3);
            tabStatic_DAA.Size = new Size(1091, 365);
            tabStatic_DAA.TabIndex = 1;
            tabStatic_DAA.Text = "Статистика";
            // 
            // groupBox_DAA
            // 
            groupBox_DAA.Location = new Point(19, 18);
            groupBox_DAA.Name = "groupBox_DAA";
            groupBox_DAA.Size = new Size(428, 88);
            groupBox_DAA.TabIndex = 0;
            groupBox_DAA.TabStop = false;
            groupBox_DAA.Text = "groupBox1";
            // 
            // openFileDialogLimo_DAA
            // 
            openFileDialogLimo_DAA.FileName = "openFileDialog1";
            // 
            // toolTipLimo_DAA
            // 
            toolTipLimo_DAA.IsBalloon = true;
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
            Text = " LIMOUSINE RENTAL | Выполнила Девятерикова А.А.";
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
            tabArenda_DAA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewLimo_DAA).EndInit();
            tabStatic_DAA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_DAA;
        private Panel panelFill_DAA;
        private TabControl tabControlBase_DAA;
        private TabPage tabArenda_DAA;
        private DataGridView dataGridViewLimo_DAA;
        private TabPage tabStatic_DAA;
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
        private GroupBox groupBox_DAA;
        private GroupBox groupBoxFilter_DAA;
        private ComboBox comboBoxCols_DAA;
        private TextBox textBoxFilter_DAA;
        private Label labelRow_DAA;
        private Label labelRows_DAA;
        private Button buttonFilter_DAA;
        private GroupBox groupBoxAboutMe_DAA;
        private SaveFileDialog saveFileDialogLimo_DAA;
        private TextBox textBoxSearch_DAA;
        private Label labelSearch_DAA;
        private ToolTip toolTipLimo_DAA;
        private Button buttonReminder_DAA;
    }
}
