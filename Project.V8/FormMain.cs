using Project.V8.Lib;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace Project.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string openFilePath;
        static int rows;
        static int columns;


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpenFile_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogLimo_DAA.ShowDialog();
                openFilePath = openFileDialogLimo_DAA.FileName;

                string[,] matrix = ds.LoadFromFileData(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewLimo_DAA.RowCount = rows + 1;
                dataGridViewLimo_DAA.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewLimo_DAA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewLimo_DAA.AutoResizeColumns();
                dataGridViewLimo_DAA.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonInfo_DAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void dataGridViewLimo_DAA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSaveFile_DAA_Click(object sender, EventArgs e)
        {
            saveFileDialogLimo_DAA.FileName = "LimoFile.csv";
            saveFileDialogLimo_DAA.InitialDirectory = @"C:\DataSprint5";
            saveFileDialogLimo_DAA.ShowDialog();

            string path = saveFileDialogLimo_DAA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewLimo_DAA.RowCount;
            int columns = dataGridViewLimo_DAA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewLimo_DAA.Rows[i].Cells[j].Value + "; ";
                    }
                    else
                    {
                        str = str + dataGridViewLimo_DAA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonDelRows_DAA_Click(object sender, EventArgs e)
        {
            dataGridViewLimo_DAA.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            if (dataGridViewLimo_DAA.SelectedRows.Count == 0)
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Строка не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить выбранные строки?", "Подтвердить удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            try
            {

                List<int> rowsToDelete = new List<int>();
                foreach (DataGridViewRow selectedRow in dataGridViewLimo_DAA.SelectedRows)
                    rowsToDelete.Add(selectedRow.Index);

                for (int i = rowsToDelete.Count - 1; i >= 0; i--)
                {
                    dataGridViewLimo_DAA.Rows.RemoveAt(rowsToDelete[i]);
                }

                dataGridViewLimo_DAA.ClearSelection();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления строки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (dataGridViewLimo_DAA.Rows.Count == 0)
            {
                buttonDelRows_DAA.Enabled = false;
            }
        }

        private void groupBoxAboutMe_DAA_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFilter_DAA_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridViewLimo_DAA.Rows)
            {
                if ((r.Cells[comboBoxCols_DAA.SelectedIndex].Value?.ToString() ?? "").ToUpper().Contains(textBoxFilter_DAA.Text.ToUpper()))
                {
                    dataGridViewLimo_DAA.Rows[r.Index].Visible = true;
                    dataGridViewLimo_DAA.Rows[r.Index].Selected = true;
                }
                else
                {
                    dataGridViewLimo_DAA.CurrentCell = null;
                    dataGridViewLimo_DAA.Rows[r.Index].Visible = false;
                }
            }
        }



        private void comboBoxCols_DAA_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxCols_DAA.SelectedIndex >= 0)
            {
                textBoxFilter_DAA.Enabled = true;
            }
            else
            {
                textBoxFilter_DAA.Enabled = false;
            }
        }

        private void dataGridViewLimo_DAA_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            string indexStr = (index).ToString();
            object header = this.dataGridViewLimo_DAA.Rows[index].HeaderCell.Value;
            if (header == null || !header.Equals(indexStr))
                this.dataGridViewLimo_DAA.Rows[index].HeaderCell.Value = indexStr;
        }

        private void textBoxSearch_DAA_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxSearch_DAA.Text.ToUpper();
            dataGridViewLimo_DAA.CurrentCell = null;
            foreach (DataGridViewRow r in dataGridViewLimo_DAA.Rows)
            {
                bool foundRow = false;

                for (int i = 0; i < r.Cells.Count; i++)
                {
                    DataGridViewCell cell = r.Cells[i];
                    string cellValue = (cell.Value?.ToString() ?? "").ToUpper();

                    if (!string.IsNullOrEmpty(searchText) && cellValue.Contains(searchText))
                    {
                        cell.Style.BackColor = Color.BlueViolet;
                        foundRow = true;
                    }
                    else
                    {
                        cell.Style.BackColor = Color.Empty;
                    }
                }

                if (string.IsNullOrEmpty(searchText))
                {
                    r.Visible = true;
                }
                else
                {
                    r.Visible = foundRow;
                }
            }
        }

        private void buttonOpenFile_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonSaveFile_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Сохранить файл";
        }

        private void buttonDelRows_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Удаление строки";
        }

        private void buttonInfo_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Информация о разработчике";
        }

        private void buttonReminder_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Информация о приложении";
        }

        private void buttonFilter_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Отфильтровать";
        }

        private void buttonReminder_DAA_Click(object sender, EventArgs e)
        {
            FormReminder formRem = new FormReminder();
            formRem.ShowDialog();
        }

        private void buttonOpenLimoMOdel_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogMarks_DAA.ShowDialog();
                openFilePath = openFileDialogMarks_DAA.FileName;

                string[,] matrix = ds.LoadFromFileData(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewMarks_DAA.RowCount = rows + 1;
                dataGridViewMarks_DAA.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewMarks_DAA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewMarks_DAA.AutoResizeColumns();
                dataGridViewMarks_DAA.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChartModel_DAA_Click(object sender, EventArgs e)
        {
            // Очищаем существующие серии данных в диаграмме перед построением новой
            chartMarks_DAA.Series.Clear();

            // Создаем новую серию для нашей диаграммы (например, круговой/пироговой)
            Series series = new Series("Series1");
            series.ChartType = SeriesChartType.Pie; // Используем круговую диаграмму, как на изображении

            // Проходим по строкам DataGridView и добавляем точки данных
            foreach (DataGridViewRow row in dataGridViewMarks_DAA.Rows)
            {
                // Проверяем, что строка не пустая и содержит данные
                if (row.Cells["ColumnMarka"].Value != null && row.Cells["ColumnProz"].Value != null)
                {
                    string brand = row.Cells["ColumnMarka"].Value.ToString();
                    // Пытаемся преобразовать значение процента в число
                    if (double.TryParse(row.Cells["ColumnProz"].Value.ToString(), out double percentage))
                    {
                        // Добавляем точку на диаграмму: X-значение (метка) и Y-значение (процент)
                        series.Points.AddXY(brand, percentage);
                    }
                }
            }

            // Добавляем созданную серию в компонент Chart
            chartMarks_DAA.Series.Add(series);

            // Опционально: можно добавить подписи данных прямо на диаграмме
            series.IsValueShownAsLabel = true;
            chartMarks_DAA.Titles.Clear();
            chartMarks_DAA.Titles.Add("Процентное соотношение марок лимузинов по частоте заказов");
        }

        private void buttonOpenLimoColor_DAA_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogColors_DAA.ShowDialog();
                openFilePath = openFileDialogColors_DAA.FileName;

                string[,] matrix = ds.LoadFromFileData(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewColors_DAA.RowCount = rows + 1;
                dataGridViewColors_DAA.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewColors_DAA.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewColors_DAA.AutoResizeColumns();
                dataGridViewColors_DAA.ScrollBars = ScrollBars.Both;
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonChartColor_DAA_Click(object sender, EventArgs e)
        {
            // Очищаем существующие серии данных в диаграмме перед построением новой
            chartColors_DAA.Series.Clear();

            // Создаем новую серию для нашей диаграммы (например, круговой/пироговой)
            Series series = new Series("Series1");
            series.ChartType = SeriesChartType.Pie; // Используем круговую диаграмму, как на изображении

            // Проходим по строкам DataGridView и добавляем точки данных
            foreach (DataGridViewRow row in dataGridViewColors_DAA.Rows)
            {
                // Проверяем, что строка не пустая и содержит данные
                if (row.Cells["ColumnColors"].Value != null && row.Cells["ColumnProzz"].Value != null)
                {
                    string brand = row.Cells["ColumnColors"].Value.ToString();
                    // Пытаемся преобразовать значение процента в число
                    if (double.TryParse(row.Cells["ColumnProzz"].Value.ToString(), out double percentage))
                    {
                        // Добавляем точку на диаграмму: X-значение (метка) и Y-значение (процент)
                        series.Points.AddXY(brand, percentage);
                    }
                }
            }

            // Добавляем созданную серию в компонент Chart
            chartColors_DAA.Series.Add(series);

            // Опционально: можно добавить подписи данных прямо на диаграмме
            series.IsValueShownAsLabel = true;
            chartColors_DAA.Titles.Clear();
            chartColors_DAA.Titles.Add("Процентное соотношение цветов лимузинов по частоте заказов");
        }

        private void buttonOpenLimoMOdel_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonOpenLimoColor_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Открыть файл";
        }

        private void buttonChartColor_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Построить диаграмму";
        }

        private void buttonChartModel_DAA_MouseEnter(object sender, EventArgs e)
        {
            toolTipLimo_DAA.ToolTipTitle = "Построить диаграмму";
        }
    }

}
