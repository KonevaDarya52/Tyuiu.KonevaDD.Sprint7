using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KonevaDD.Sprint7.V10.Lib;

namespace Tyuiu.KonevaDD.Sprint7.Project.V10
{
    partial class MainForm_KDD
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOrders_KDD;
        private System.Windows.Forms.Button buttonAddOrder_KDD;
        private System.Windows.Forms.Button buttonSaveOrders_KDD;
        private System.Windows.Forms.Button buttonSearch_KDD;
        private System.Windows.Forms.TextBox textBoxSearch_KDD;
        private System.Windows.Forms.Button buttonSortByDate_KDD;
        private System.Windows.Forms.Button buttonSortByPrice_KDD;
        private System.Windows.Forms.Button buttonFilterByPrice_KDD;
        private System.Windows.Forms.TextBox textBoxMinPrice_KDD;
        private System.Windows.Forms.TextBox textBoxMaxPrice_KDD;
        private System.Windows.Forms.Button buttonStatistics_KDD;
        private System.Windows.Forms.Label labelStatistics_KDD;
        private System.Windows.Forms.Button buttonLoadCSV_KDD;

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm_KDD));
            dataGridViewOrders_KDD = new DataGridView();
            buttonAddOrder_KDD = new Button();
            buttonSaveOrders_KDD = new Button();
            buttonSearch_KDD = new Button();
            textBoxSearch_KDD = new TextBox();
            buttonSortByDate_KDD = new Button();
            buttonSortByPrice_KDD = new Button();
            buttonFilterByPrice_KDD = new Button();
            textBoxMinPrice_KDD = new TextBox();
            textBoxMaxPrice_KDD = new TextBox();
            buttonStatistics_KDD = new Button();
            labelStatistics_KDD = new Label();
            buttonLoadCSV_KDD = new Button();
            chartOrders_KDD = new Chart();
            toolStripKDD = new ToolStrip();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders_KDD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartOrders_KDD).BeginInit();
            toolStripKDD.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewOrders_KDD
            // 
            dataGridViewOrders_KDD.BackgroundColor = Color.Gray;
            dataGridViewOrders_KDD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders_KDD.Dock = DockStyle.Fill;
            dataGridViewOrders_KDD.GridColor = Color.Black;
            dataGridViewOrders_KDD.Location = new Point(0, 0);
            dataGridViewOrders_KDD.Name = "dataGridViewOrders_KDD";
            dataGridViewOrders_KDD.Size = new Size(934, 507);
            dataGridViewOrders_KDD.TabIndex = 0;
            // 
            // buttonAddOrder_KDD
            // 
            buttonAddOrder_KDD.Location = new Point(129, 365);
            buttonAddOrder_KDD.Name = "buttonAddOrder_KDD";
            buttonAddOrder_KDD.Size = new Size(75, 23);
            buttonAddOrder_KDD.TabIndex = 1;
            buttonAddOrder_KDD.Text = "Добавить заказ";
            toolTip1.SetToolTip(buttonAddOrder_KDD, "Добавить файл в приложении");
            buttonAddOrder_KDD.UseVisualStyleBackColor = true;
            buttonAddOrder_KDD.Click += buttonAddOrder_KDD_Click;
            // 
            // buttonSaveOrders_KDD
            // 
            buttonSaveOrders_KDD.ForeColor = Color.Green;
            buttonSaveOrders_KDD.Location = new Point(210, 365);
            buttonSaveOrders_KDD.Name = "buttonSaveOrders_KDD";
            buttonSaveOrders_KDD.Size = new Size(89, 23);
            buttonSaveOrders_KDD.TabIndex = 2;
            buttonSaveOrders_KDD.Text = "Сохранить";
            toolTip1.SetToolTip(buttonSaveOrders_KDD, "Сохранить данные");
            buttonSaveOrders_KDD.UseVisualStyleBackColor = true;
            buttonSaveOrders_KDD.Click += buttonSaveOrders_KDD_Click;
            // 
            // buttonSearch_KDD
            // 
            buttonSearch_KDD.ImageAlign = ContentAlignment.MiddleLeft;
            buttonSearch_KDD.Location = new Point(305, 365);
            buttonSearch_KDD.Name = "buttonSearch_KDD";
            buttonSearch_KDD.Size = new Size(75, 23);
            buttonSearch_KDD.TabIndex = 3;
            buttonSearch_KDD.Text = "Найти";
            toolTip1.SetToolTip(buttonSearch_KDD, "Найти заказ по данным");
            buttonSearch_KDD.UseVisualStyleBackColor = true;
            buttonSearch_KDD.Click += buttonSearch_KDD_Click;
            // 
            // textBoxSearch_KDD
            // 
            textBoxSearch_KDD.Location = new Point(386, 365);
            textBoxSearch_KDD.Name = "textBoxSearch_KDD";
            textBoxSearch_KDD.Size = new Size(88, 23);
            textBoxSearch_KDD.TabIndex = 4;
            // 
            // buttonSortByDate_KDD
            // 
            buttonSortByDate_KDD.Location = new Point(480, 368);
            buttonSortByDate_KDD.Name = "buttonSortByDate_KDD";
            buttonSortByDate_KDD.Size = new Size(87, 43);
            buttonSortByDate_KDD.TabIndex = 5;
            buttonSortByDate_KDD.Text = "Сортировать по дате";
            toolTip1.SetToolTip(buttonSortByDate_KDD, "Сортировка по дате ");
            buttonSortByDate_KDD.UseVisualStyleBackColor = true;
            buttonSortByDate_KDD.Click += buttonSortByDate_KDD_Click_1;
            // 
            // buttonSortByPrice_KDD
            // 
            buttonSortByPrice_KDD.Location = new Point(573, 366);
            buttonSortByPrice_KDD.Name = "buttonSortByPrice_KDD";
            buttonSortByPrice_KDD.Size = new Size(96, 43);
            buttonSortByPrice_KDD.TabIndex = 6;
            buttonSortByPrice_KDD.Text = "Сортировать по цене";
            toolTip1.SetToolTip(buttonSortByPrice_KDD, "Сортировка по цене");
            buttonSortByPrice_KDD.UseVisualStyleBackColor = true;
            buttonSortByPrice_KDD.Click += buttonSortByPrice_KDD_Click_1;
            // 
            // buttonFilterByPrice_KDD
            // 
            buttonFilterByPrice_KDD.Location = new Point(675, 365);
            buttonFilterByPrice_KDD.Name = "buttonFilterByPrice_KDD";
            buttonFilterByPrice_KDD.Size = new Size(75, 43);
            buttonFilterByPrice_KDD.TabIndex = 7;
            buttonFilterByPrice_KDD.Text = "Фильтр цены";
            toolTip1.SetToolTip(buttonFilterByPrice_KDD, "Искать от заданной цены");
            buttonFilterByPrice_KDD.UseVisualStyleBackColor = true;
            buttonFilterByPrice_KDD.Click += buttonFilterByPrice_KDD_Click_1;
            // 
            // textBoxMinPrice_KDD
            // 
            textBoxMinPrice_KDD.Location = new Point(756, 369);
            textBoxMinPrice_KDD.Name = "textBoxMinPrice_KDD";
            textBoxMinPrice_KDD.Size = new Size(41, 23);
            textBoxMinPrice_KDD.TabIndex = 8;
            // 
            // textBoxMaxPrice_KDD
            // 
            textBoxMaxPrice_KDD.Location = new Point(803, 369);
            textBoxMaxPrice_KDD.Name = "textBoxMaxPrice_KDD";
            textBoxMaxPrice_KDD.Size = new Size(34, 23);
            textBoxMaxPrice_KDD.TabIndex = 9;
            // 
            // buttonStatistics_KDD
            // 
            buttonStatistics_KDD.Location = new Point(843, 368);
            buttonStatistics_KDD.Name = "buttonStatistics_KDD";
            buttonStatistics_KDD.Size = new Size(91, 23);
            buttonStatistics_KDD.TabIndex = 10;
            buttonStatistics_KDD.Text = "Статистика";
            toolTip1.SetToolTip(buttonStatistics_KDD, "Статистика таблицы");
            buttonStatistics_KDD.UseVisualStyleBackColor = true;
            buttonStatistics_KDD.Click += buttonStatistics_KDD_Click;
            // 
            // labelStatistics_KDD
            // 
            labelStatistics_KDD.Location = new Point(0, 412);
            labelStatistics_KDD.Name = "labelStatistics_KDD";
            labelStatistics_KDD.Size = new Size(776, 33);
            labelStatistics_KDD.TabIndex = 11;
            labelStatistics_KDD.Text = "Статистика расположена тут";
            // 
            // buttonLoadCSV_KDD
            // 
            buttonLoadCSV_KDD.Location = new Point(12, 363);
            buttonLoadCSV_KDD.Name = "buttonLoadCSV_KDD";
            buttonLoadCSV_KDD.Size = new Size(111, 26);
            buttonLoadCSV_KDD.TabIndex = 12;
            buttonLoadCSV_KDD.Text = "Загрузить файл";
            toolTip1.SetToolTip(buttonLoadCSV_KDD, "Выбрать файл и загрузить в приложении");
            buttonLoadCSV_KDD.UseVisualStyleBackColor = true;
            buttonLoadCSV_KDD.Click += buttonLoadCSV_KDD_Click_1;
            // 
            // chartOrders_KDD
            // 
            chartArea1.Name = "ChartArea1";
            chartOrders_KDD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartOrders_KDD.Legends.Add(legend1);
            chartOrders_KDD.Location = new Point(0, 448);
            chartOrders_KDD.Name = "chartOrders_KDD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartOrders_KDD.Series.Add(series1);
            chartOrders_KDD.Size = new Size(425, 159);
            chartOrders_KDD.TabIndex = 13;
            chartOrders_KDD.Text = "chart1";
            // 
            // toolStripKDD
            // 
            toolStripKDD.Dock = DockStyle.Bottom;
            toolStripKDD.GripStyle = ToolStripGripStyle.Hidden;
            toolStripKDD.Items.AddRange(new ToolStripItem[] { toolStripButton2, toolStripButton3 });
            toolStripKDD.Location = new Point(0, 482);
            toolStripKDD.Name = "toolStripKDD";
            toolStripKDD.Size = new Size(934, 25);
            toolStripKDD.TabIndex = 0;
            // 
            // toolStripButton2
            // 
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(126, 22);
            toolStripButton2.Text = "Рук.Пользователя";
            toolStripButton2.ToolTipText = "Краткое руководство пользователя";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(110, 22);
            toolStripButton3.Text = "О приложении";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // MainForm_KDD
            // 
            ClientSize = new Size(934, 507);
            Controls.Add(toolStripKDD);
            Controls.Add(chartOrders_KDD);
            Controls.Add(buttonLoadCSV_KDD);
            Controls.Add(labelStatistics_KDD);
            Controls.Add(buttonStatistics_KDD);
            Controls.Add(textBoxMaxPrice_KDD);
            Controls.Add(textBoxMinPrice_KDD);
            Controls.Add(buttonFilterByPrice_KDD);
            Controls.Add(buttonSortByPrice_KDD);
            Controls.Add(buttonSortByDate_KDD);
            Controls.Add(textBoxSearch_KDD);
            Controls.Add(buttonSearch_KDD);
            Controls.Add(buttonSaveOrders_KDD);
            Controls.Add(buttonAddOrder_KDD);
            Controls.Add(dataGridViewOrders_KDD);
            Name = "MainForm_KDD";
            Text = "Приложение по заказам. Выполнила студентка группы АСОиУБ-24-1. Конева Дарья Денисовна";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_KDD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders_KDD).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartOrders_KDD).EndInit();
            toolStripKDD.ResumeLayout(false);
            toolStripKDD.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrders_KDD;
        private ToolStrip toolStripKDD;
        private ToolStripButton toolStripButton1;
        private ToolTip toolTip1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}
