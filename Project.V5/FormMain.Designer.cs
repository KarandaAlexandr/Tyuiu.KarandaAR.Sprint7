namespace Project.V5
{
    partial class FormMain
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            menuStrip = new MenuStrip();
            FileButton = new ToolStripMenuItem();
            createFileButton = new ToolStripMenuItem();
            openFileButton = new ToolStripMenuItem();
            saveFileButton = new ToolStripMenuItem();
            guideButton = new ToolStripMenuItem();
            aboutButton = new ToolStripMenuItem();
            panel1 = new Panel();
            textBoxSearch = new TextBox();
            panel2 = new Panel();
            currentFilePathLabel = new Label();
            splitContainer = new SplitContainer();
            dataGrid = new DataGridView();
            chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel3 = new Panel();
            networth = new Label();
            averageCount = new Label();
            maxItemCount = new Label();
            minItemCount = new Label();
            menuStrip.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chart).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { FileButton, guideButton, aboutButton });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(813, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // FileButton
            // 
            FileButton.DropDownItems.AddRange(new ToolStripItem[] { createFileButton, openFileButton, saveFileButton });
            FileButton.Name = "FileButton";
            FileButton.Size = new Size(48, 20);
            FileButton.Text = "Файл";
            FileButton.Click += FileButton_Click;
            // 
            // createFileButton
            // 
            createFileButton.Name = "createFileButton";
            createFileButton.Size = new Size(133, 22);
            createFileButton.Text = "Создать";
            createFileButton.Click += createFileButton_Click;
            // 
            // openFileButton
            // 
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(133, 22);
            openFileButton.Text = "Открыть";
            openFileButton.Click += openFileButton_Click;
            // 
            // saveFileButton
            // 
            saveFileButton.Name = "saveFileButton";
            saveFileButton.Size = new Size(133, 22);
            saveFileButton.Text = "Сохранить";
            saveFileButton.Click += saveFileButton_Click;
            // 
            // guideButton
            // 
            guideButton.Name = "guideButton";
            guideButton.Size = new Size(65, 20);
            guideButton.Text = "Справка";
            guideButton.Click += guideButton_Click;
            // 
            // aboutButton
            // 
            aboutButton.Name = "aboutButton";
            aboutButton.Size = new Size(94, 20);
            aboutButton.Text = "О программе";
            aboutButton.Click += aboutButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 24);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 22);
            panel1.TabIndex = 2;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Dock = DockStyle.Fill;
            textBoxSearch.Location = new Point(0, 0);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.PlaceholderText = "Поиск по базе";
            textBoxSearch.Size = new Size(813, 23);
            textBoxSearch.TabIndex = 1;
            textBoxSearch.TextChanged += textBox1_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(currentFilePathLabel);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 463);
            panel2.Name = "panel2";
            panel2.Size = new Size(813, 20);
            panel2.TabIndex = 3;
            // 
            // currentFilePathLabel
            // 
            currentFilePathLabel.AutoSize = true;
            currentFilePathLabel.ForeColor = SystemColors.GrayText;
            currentFilePathLabel.Location = new Point(0, -1);
            currentFilePathLabel.Name = "currentFilePathLabel";
            currentFilePathLabel.Size = new Size(134, 15);
            currentFilePathLabel.TabIndex = 0;
            currentFilePathLabel.Text = "файл не редактируется";
            currentFilePathLabel.Click += currentFilePathLabel_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 46);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dataGrid);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(chart);
            splitContainer.Panel2.Controls.Add(panel3);
            splitContainer.Size = new Size(813, 417);
            splitContainer.SplitterDistance = 438;
            splitContainer.TabIndex = 4;
            // 
            // dataGrid
            // 
            dataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGrid.BackgroundColor = SystemColors.Window;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.Location = new Point(0, 0);
            dataGrid.Name = "dataGrid";
            dataGrid.Size = new Size(438, 417);
            dataGrid.TabIndex = 0;
            dataGrid.CellValueChanged += dataGrid_CellValueChanged;
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            chart.ChartAreas.Add(chartArea1);
            chart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart.Legends.Add(legend1);
            chart.Location = new Point(0, 0);
            chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart.Series.Add(series1);
            chart.Size = new Size(371, 352);
            chart.TabIndex = 1;
            chart.Text = "chart1";
            // 
            // panel3
            // 
            panel3.Controls.Add(networth);
            panel3.Controls.Add(averageCount);
            panel3.Controls.Add(maxItemCount);
            panel3.Controls.Add(minItemCount);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 352);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 65);
            panel3.TabIndex = 0;
            // 
            // networth
            // 
            networth.AutoSize = true;
            networth.Location = new Point(0, 45);
            networth.Name = "networth";
            networth.Size = new Size(110, 15);
            networth.TabIndex = 3;
            networth.Text = "Общая стоимость:";
            networth.Click += label1_Click;
            // 
            // averageCount
            // 
            averageCount.AutoSize = true;
            averageCount.Location = new Point(0, 30);
            averageCount.Name = "averageCount";
            averageCount.Size = new Size(97, 15);
            averageCount.TabIndex = 2;
            averageCount.Text = "Среднее кол-во:";
            // 
            // maxItemCount
            // 
            maxItemCount.AutoSize = true;
            maxItemCount.Location = new Point(0, 15);
            maxItemCount.Name = "maxItemCount";
            maxItemCount.Size = new Size(87, 15);
            maxItemCount.TabIndex = 1;
            maxItemCount.Text = "Больше всего:";
            // 
            // minItemCount
            // 
            minItemCount.AutoSize = true;
            minItemCount.Location = new Point(0, 0);
            minItemCount.Name = "minItemCount";
            minItemCount.Size = new Size(90, 15);
            minItemCount.TabIndex = 0;
            minItemCount.Text = "Меньше всего:";
            minItemCount.Click += minItemCount_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 483);
            Controls.Add(splitContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            Text = "Оптовая база";
            FormClosing += FormMain_FormClosing;
            Load += FormMain_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)chart).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem FileButton;
        private ToolStripMenuItem aboutButton;
        private ToolStripMenuItem openFileButton;
        private ToolStripMenuItem saveFileButton;
        private ToolStripMenuItem guideButton;
        private Panel panel1;
        private ToolStripMenuItem createFileButton;
        private TextBox textBoxSearch;
        private Panel panel2;
        private Label currentFilePathLabel;
        private SplitContainer splitContainer;
        private DataGridView dataGrid;
        private Panel panel3;
        private Label networth;
        private Label averageCount;
        private Label maxItemCount;
        private Label minItemCount;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}