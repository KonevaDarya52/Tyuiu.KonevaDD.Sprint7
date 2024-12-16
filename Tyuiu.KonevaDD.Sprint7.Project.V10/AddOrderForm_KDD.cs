using System;
using System.Windows.Forms;
using Tyuiu.KonevaDD.Sprint7.V10.Lib;
namespace Tyuiu.KonevaDD.Sprint7.Project.V10
{
    public partial class AddOrderForm_KDD : Form
    {
        public Order Order { get; private set; }

        public AddOrderForm_KDD()
        {
            InitializeComponent();
        }

        private void buttonSaveOrder_KDD_Click(object sender, EventArgs e)
        {
            Order = new Order
            {
                OrderNumber = textBoxOrderNumber_KDD.Text,
                LastName = textBoxLastName_KDD.Text,
                FirstName = textBoxFirstName_KDD.Text,
                MiddleName = textBoxMiddleName_KDD.Text,
                Index = textBoxIndex_KDD.Text,
                City = textBoxCity_KDD.Text,
                Address = textBoxAddress_KDD.Text,
                PhoneNumber = textBoxPhoneNumber_KDD.Text,
                OrderDate = dateTimePickerOrderDate_KDD.Value,
                OrderName = textBoxOrderName_KDD.Text,
                Price = decimal.Parse(textBoxPrice_KDD.Text),
                Quantity = int.Parse(textBoxQuantity_KDD.Text),
                AccountNumber = textBoxAccountNumber_KDD.Text
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonCancel_KDD_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxOrderNumber_KDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_KDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxIndex_KDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}