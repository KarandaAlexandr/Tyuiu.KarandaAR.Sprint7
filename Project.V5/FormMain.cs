using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project.V5
{
    public partial class FormMain : Form
    {
        private DataTable dataTable = new DataTable();
        string currentFilePath = string.Empty; // Изначально нет открытого файла

        public FormMain()
        {
            InitializeComponent();
            InitializeDataTable();
            Debug.WriteLine("penis");
        }

        private void InitializeDataTable()
        {
            dataTable = new DataTable("Products"); // Инициализация DataTable с именем "Products"

            // Добавление столбцов
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Имя", typeof(string));
            dataTable.Columns.Add("Товар", typeof(string));
            dataTable.Columns.Add("Стоимость", typeof(decimal));
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBoxSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchValue))
            {
                try
                {
                    DataView dv = new DataView(dataTable);
                    dv.RowFilter = string.Format("Товар LIKE '%{0}%'", searchValue);
                    dataGrid.DataSource = dv;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error filtering data: " + ex.Message);
                }
            }
            else
            {
                dataGrid.DataSource = dataTable; // Reset to original data
            }
            UpdateChart(dataGrid);
            UpdateStatistics();
        }


        private void UpdateChart(DataGridView dataGrid)
        {
            // Очистить старые данные
            chart.Series["Series1"].Points.Clear();

            // Перебор строк DataGridView
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                // Проверяем, что строка не пустая
                if (row.Cells["Товар"].Value != null && row.Cells["На складе"].Value != null)
                {
                    string name = row.Cells["Товар"].Value.ToString();
                    double value = Convert.ToDouble(row.Cells["На складе"].Value);

                    // Добавляем точку данных в график
                    chart.Series["Series1"].Points.AddXY(name, value);
                }
            }
        }

        private void UpdateStatistics()
        {
            try
            {

                // Инициализация переменных
                int minQuantity = int.MaxValue;
                int maxQuantity = int.MinValue;
                double totalCost = 0;
                int totalQuantity = 0;

                // Итерируем по всем строкам в DataGridView
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    // Пропускаем новую строку, если она есть
                    if (row.IsNewRow) continue;

                    // Получаем количество и стоимость из ячеек
                    if (row.Cells["На складе"].Value != null && row.Cells["Стоимость"].Value != null)
                    {
                        int quantity = Convert.ToInt32(row.Cells["На складе"].Value);
                        double cost = Convert.ToDouble(row.Cells["Стоимость"].Value);

                        // Обновляем минимальное и максимальное количество
                        if (quantity < minQuantity) minQuantity = quantity;
                        if (quantity > maxQuantity) maxQuantity = quantity;

                        // Суммируем общее количество и стоимость
                        totalQuantity += quantity;
                        totalCost += cost;
                    }
                }

                // Вычисляем среднее количество
                double averageQuantity = totalQuantity > 0 ? (double)totalQuantity / (dataGrid.Rows.Count - 1) : 0; // -1 для исключения новой строки

                // Обновляем лейблы
                minItemCount.Text = $"Меньше всего: {minQuantity}";
                maxItemCount.Text = $"Больше всего: {maxQuantity}";
                averageCount.Text = $"Среднее кол-во: {averageQuantity:F2}"; // Форматируем до 2 знаков после запятой
                networth.Text = $"Общая стоимость: {totalCost:F2}"; // Форматируем до 2 знаков после запятой
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при обновлении статистики: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.Title = "Создать CSV файл";

                // Показываем диалоговое окно для выбора места сохранения файла
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = saveFileDialog.FileName; // Получаем путь к файлу
                    currentFilePathLabel.Text = currentFilePath; // Обновляем метку с путем к файлу

                    CreateCsvFile(currentFilePath); // Создаем CSV файл
                    LoadDataFromCsv(currentFilePath);
                }
            }
        }

        private void CreateCsvFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ID,Товар,На складе,Стоимость");
            }
        }

        private void saveFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveDataToCsv(currentFilePath); // Сохраняем данные в CSV файл
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveDataToCsv(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Записываем заголовки
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    writer.Write(dataGrid.Columns[i].HeaderText); // Используем заголовки из DataGridView
                    if (i < dataGrid.Columns.Count - 1)
                        writer.Write(",");
                }
                writer.WriteLine();

                // Записываем строки
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    // Проверяем, что строка не является пустой (например, не является строкой для добавления)
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dataGrid.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value?.ToString() ?? ""); // Записываем значение ячейки
                            if (i < dataGrid.Columns.Count - 1)
                                writer.Write(",");
                        }
                        writer.WriteLine();
                    }
                }
            }
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.Title = "Открыть CSV файл";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    currentFilePath = openFileDialog.FileName; // Сохраняем путь к файлу
                    currentFilePathLabel.Text = currentFilePath; // Обновляем метку с путем к файлу
                    LoadDataFromCsv(currentFilePath);
                    UpdateChart(dataGrid);
                }
            }
        }

        private void LoadDataFromCsv(string filePath)
        {
            //dataTable.Clear(); // Очищаем предыдущие данные (строки)

            // Очищаем столбцы, если они существуют
            dataTable.Columns.Clear(); // Очищаем столбцы

            using (StreamReader reader = new StreamReader(filePath))
            {
                string headerLine = reader.ReadLine(); // Чтение заголовка
                string[] headers = headerLine.Split(',');

                // Добавление столбцов в DataTable
                foreach (string header in headers)
                {
                    dataTable.Columns.Add(header); // Добавление столбцов
                }

                // Чтение строк и добавление их в DataTable
                while (!reader.EndOfStream)
                {
                    string[] rows = reader.ReadLine().Split(','); // Чтение строки
                    dataTable.Rows.Add(rows); // Добавление строки в DataTable
                }
            }

            // Устанавливаем DataSource для DataGridView
            dataGrid.DataSource = dataTable; // Привязываем DataTable к DataGridView
            UpdateChart(dataGrid);
            UpdateStatistics();
        }

        private void currentFilePathLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelTotalItems_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                // Запрос на сохранение изменений
                var result = MessageBox.Show("Хотите сохранить изменения?", "Сохранение",
                                              MessageBoxButtons.YesNoCancel,
                                              MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Логика для сохранения файла
                    SaveDataToCsv(currentFilePath);
                }
                else if (result == DialogResult.Cancel)
                {
                    // Отменяем закрытие формы
                    e.Cancel = true;
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                UpdateChart(dataGrid);
                UpdateStatistics();
            }
            catch
            {

            }
        }

        private void minItemCount_Click(object sender, EventArgs e)
        {

        }

        private void FileButton_Click(object sender, EventArgs e)
        {

        }

        private void guideButton_Click(object sender, EventArgs e)
        {
            using (FormHelpProvider helpForm = new FormHelpProvider())
            {
                helpForm.ShowDialog(); // Показываем форму "Справка" в модальном режиме
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            using (FormAbout aboutForm = new FormAbout())
            {
                aboutForm.ShowDialog(); // Показываем форму "О программе" в модальном режиме
            }
        }
    }
}

