using System;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.KonevaDD.Sprint7.V10.Lib;

namespace Tyuiu.KonevaDD.Sprint7.Project.V10
{
    public partial class MainForm_KDD : Form
    {
        private OrderManager orderManager;
        private CSVManager csvManager;

        public MainForm_KDD()
        {
            InitializeComponent();
            orderManager = new OrderManager();
            csvManager = new CSVManager();
        }

        private void MainForm_KDD_Load(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Select a CSV File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var orders = csvManager.LoadFromCSV(openFileDialog.FileName);
                    foreach (var order in orders)
                    {
                        orderManager.AddOrder(order);
                    }
                    UpdateDataGridView();
                    UpdateChart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonAddOrder_KDD_Click(object sender, EventArgs e)
        {
            var addOrderForm = new AddOrderForm_KDD();
            if (addOrderForm.ShowDialog() == DialogResult.OK)
            {
                orderManager.AddOrder(addOrderForm.Order);
                UpdateDataGridView();
                UpdateChart();
            }
        }

        private void buttonSaveOrders_KDD_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Save CSV File"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    csvManager.SaveToCSV(orderManager.Orders, saveFileDialog.FileName);
                    MessageBox.Show("Данные успешно сохранены.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void UpdateDataGridView()
        {
            dataGridViewOrders_KDD.DataSource = null;
            dataGridViewOrders_KDD.DataSource = orderManager.Orders;
        }

        private void UpdateChart()
        {
            chartOrders_KDD.Series.Clear();
            var series = new Series
            {
                Name = "Сумма заказов",
                Color = System.Drawing.Color.Blue,
                IsVisibleInLegend = false,
                IsXValueIndexed = true,
                ChartType = SeriesChartType.Column
            };

            foreach (var order in orderManager.Orders)
            {
                series.Points.AddXY(order.OrderNumber, order.Price);
            }

            chartOrders_KDD.Series.Add(series);
            chartOrders_KDD.ChartAreas[0].AxisX.Title = "Номер заказа";
            chartOrders_KDD.ChartAreas[0].AxisY.Title = "Сумма";
        }

        private void buttonSortByPrice_KDD_Click_1(object sender, EventArgs e)
        {
            orderManager.SortByPrice();
            Console.WriteLine("Заказы отсортированы по цене.");
            UpdateDataGridView();
            Console.WriteLine("DataGridView обновлен.");
        }
        private void buttonFilterByPrice_KDD_Click_1(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxMinPrice_KDD.Text, out decimal minPrice) &&
                decimal.TryParse(textBoxMaxPrice_KDD.Text, out decimal maxPrice))
            {
                var filteredOrders = orderManager.FilterByPrice(minPrice, maxPrice);
                dataGridViewOrders_KDD.DataSource = filteredOrders;
            }
            else
            {
                MessageBox.Show("Ошибка, пожалуйста, введите корректные значения цены.");
            }
        }

        private void buttonLoadCSV_KDD_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Select a CSV File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var orders = csvManager.LoadFromCSV(openFileDialog.FileName);
                    orderManager.Orders.Clear();
                    foreach (var order in orders)
                    {
                        orderManager.AddOrder(order);
                    }
                    UpdateDataGridView();
                    UpdateChart();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonStatistics_KDD_Click(object sender, EventArgs e)
        {
            var statistics = orderManager.GetStatistics();
            labelStatistics_KDD.Text = $"Общая сумма: {statistics.TotalCost}, Средняя сумма: {statistics.AverageCost}, Мин. сумма: {statistics.MinCost}, Макс. сумма: {statistics.MaxCost}";
        }

        private void buttonSortByDate_KDD_Click_1(object sender, EventArgs e)
        {
            orderManager.SortByOrderDate();
            UpdateDataGridView();
        }

        private void buttonSearch_KDD_Click(object sender, EventArgs e)
        {
            var searchTerm = textBoxSearch_KDD.Text;
            var filteredOrders = orderManager.SearchByClientName(searchTerm);
            dataGridViewOrders_KDD.DataSource = filteredOrders;
        }

        private void toolStripButtonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            FormAboutMe formAbout = new FormAboutMe();
            formAbout.ShowDialog();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}
