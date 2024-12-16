using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Tyuiu.KonevaDD.Sprint7.Project.V10
{
    partial class AddOrderForm_KDD
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxOrderNumber_KDD;
        private System.Windows.Forms.TextBox textBoxLastName_KDD;
        private System.Windows.Forms.TextBox textBoxFirstName_KDD;
        private System.Windows.Forms.TextBox textBoxMiddleName_KDD;
        private System.Windows.Forms.TextBox textBoxIndex_KDD;
        private System.Windows.Forms.TextBox textBoxCity_KDD;
        private System.Windows.Forms.TextBox textBoxAddress_KDD;
        private System.Windows.Forms.TextBox textBoxPhoneNumber_KDD;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate_KDD;
        private System.Windows.Forms.TextBox textBoxOrderName_KDD;
        private System.Windows.Forms.TextBox textBoxPrice_KDD;
        private System.Windows.Forms.TextBox textBoxQuantity_KDD;
        private System.Windows.Forms.TextBox textBoxAccountNumber_KDD;
        private System.Windows.Forms.Button buttonSaveOrder_KDD;

        private void InitializeComponent()
        {
            textBoxOrderNumber_KDD = new TextBox();
            textBoxLastName_KDD = new TextBox();
            textBoxFirstName_KDD = new TextBox();
            textBoxMiddleName_KDD = new TextBox();
            textBoxIndex_KDD = new TextBox();
            textBoxCity_KDD = new TextBox();
            textBoxAddress_KDD = new TextBox();
            textBoxPhoneNumber_KDD = new TextBox();
            dateTimePickerOrderDate_KDD = new DateTimePicker();
            textBoxOrderName_KDD = new TextBox();
            textBoxPrice_KDD = new TextBox();
            textBoxQuantity_KDD = new TextBox();
            textBoxAccountNumber_KDD = new TextBox();
            buttonSaveOrder_KDD = new Button();
            textBoxKDD_Number = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            textBox13 = new TextBox();
            buttonCancel_KDD = new Button();
            SuspendLayout();
            // 
            // textBoxOrderNumber_KDD
            // 
            textBoxOrderNumber_KDD.Location = new Point(169, 24);
            textBoxOrderNumber_KDD.Name = "textBoxOrderNumber_KDD";
            textBoxOrderNumber_KDD.Size = new Size(200, 27);
            textBoxOrderNumber_KDD.TabIndex = 0;
            textBoxOrderNumber_KDD.TextChanged += textBoxOrderNumber_KDD_TextChanged;
            // 
            // textBoxLastName_KDD
            // 
            textBoxLastName_KDD.Location = new Point(169, 57);
            textBoxLastName_KDD.Name = "textBoxLastName_KDD";
            textBoxLastName_KDD.Size = new Size(200, 27);
            textBoxLastName_KDD.TabIndex = 1;
            // 
            // textBoxFirstName_KDD
            // 
            textBoxFirstName_KDD.Location = new Point(169, 90);
            textBoxFirstName_KDD.Name = "textBoxFirstName_KDD";
            textBoxFirstName_KDD.Size = new Size(200, 27);
            textBoxFirstName_KDD.TabIndex = 2;
            textBoxFirstName_KDD.TextChanged += textBoxFirstName_KDD_TextChanged;
            // 
            // textBoxMiddleName_KDD
            // 
            textBoxMiddleName_KDD.Location = new Point(169, 123);
            textBoxMiddleName_KDD.Name = "textBoxMiddleName_KDD";
            textBoxMiddleName_KDD.Size = new Size(200, 27);
            textBoxMiddleName_KDD.TabIndex = 3;
            // 
            // textBoxIndex_KDD
            // 
            textBoxIndex_KDD.Location = new Point(169, 156);
            textBoxIndex_KDD.Name = "textBoxIndex_KDD";
            textBoxIndex_KDD.Size = new Size(200, 27);
            textBoxIndex_KDD.TabIndex = 4;
            textBoxIndex_KDD.TextChanged += textBoxIndex_KDD_TextChanged;
            // 
            // textBoxCity_KDD
            // 
            textBoxCity_KDD.Location = new Point(169, 189);
            textBoxCity_KDD.Name = "textBoxCity_KDD";
            textBoxCity_KDD.Size = new Size(200, 27);
            textBoxCity_KDD.TabIndex = 5;
            // 
            // textBoxAddress_KDD
            // 
            textBoxAddress_KDD.Location = new Point(169, 222);
            textBoxAddress_KDD.Name = "textBoxAddress_KDD";
            textBoxAddress_KDD.Size = new Size(200, 27);
            textBoxAddress_KDD.TabIndex = 6;
            // 
            // textBoxPhoneNumber_KDD
            // 
            textBoxPhoneNumber_KDD.Location = new Point(169, 255);
            textBoxPhoneNumber_KDD.Name = "textBoxPhoneNumber_KDD";
            textBoxPhoneNumber_KDD.Size = new Size(200, 27);
            textBoxPhoneNumber_KDD.TabIndex = 7;
            // 
            // dateTimePickerOrderDate_KDD
            // 
            dateTimePickerOrderDate_KDD.Location = new Point(169, 288);
            dateTimePickerOrderDate_KDD.Name = "dateTimePickerOrderDate_KDD";
            dateTimePickerOrderDate_KDD.Size = new Size(200, 27);
            dateTimePickerOrderDate_KDD.TabIndex = 8;
            // 
            // textBoxOrderName_KDD
            // 
            textBoxOrderName_KDD.Location = new Point(169, 321);
            textBoxOrderName_KDD.Name = "textBoxOrderName_KDD";
            textBoxOrderName_KDD.Size = new Size(200, 27);
            textBoxOrderName_KDD.TabIndex = 9;
            // 
            // textBoxPrice_KDD
            // 
            textBoxPrice_KDD.Location = new Point(169, 354);
            textBoxPrice_KDD.Name = "textBoxPrice_KDD";
            textBoxPrice_KDD.Size = new Size(200, 27);
            textBoxPrice_KDD.TabIndex = 10;
            // 
            // textBoxQuantity_KDD
            // 
            textBoxQuantity_KDD.Location = new Point(169, 387);
            textBoxQuantity_KDD.Name = "textBoxQuantity_KDD";
            textBoxQuantity_KDD.Size = new Size(200, 27);
            textBoxQuantity_KDD.TabIndex = 11;
            // 
            // textBoxAccountNumber_KDD
            // 
            textBoxAccountNumber_KDD.Location = new Point(169, 420);
            textBoxAccountNumber_KDD.Name = "textBoxAccountNumber_KDD";
            textBoxAccountNumber_KDD.Size = new Size(200, 27);
            textBoxAccountNumber_KDD.TabIndex = 12;
            // 
            // buttonSaveOrder_KDD
            // 
            buttonSaveOrder_KDD.BackColor = Color.Green;
            buttonSaveOrder_KDD.ForeColor = Color.Black;
            buttonSaveOrder_KDD.ImageAlign = ContentAlignment.TopCenter;
            buttonSaveOrder_KDD.Location = new Point(48, 453);
            buttonSaveOrder_KDD.Name = "buttonSaveOrder_KDD";
            buttonSaveOrder_KDD.Size = new Size(154, 31);
            buttonSaveOrder_KDD.TabIndex = 13;
            buttonSaveOrder_KDD.Text = "Сохранить заказ";
            buttonSaveOrder_KDD.UseVisualStyleBackColor = false;
            buttonSaveOrder_KDD.Click += buttonSaveOrder_KDD_Click;
            // 
            // textBoxKDD_Number
            // 
            textBoxKDD_Number.Location = new Point(12, 24);
            textBoxKDD_Number.Multiline = true;
            textBoxKDD_Number.Name = "textBoxKDD_Number";
            textBoxKDD_Number.ReadOnly = true;
            textBoxKDD_Number.Size = new Size(130, 27);
            textBoxKDD_Number.TabIndex = 15;
            textBoxKDD_Number.Text = "Номер заказа";
            textBoxKDD_Number.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 57);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(130, 27);
            textBox2.TabIndex = 16;
            textBox2.Text = "Фамилия";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 90);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(130, 27);
            textBox3.TabIndex = 17;
            textBox3.Text = "Имя";
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 123);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(130, 27);
            textBox4.TabIndex = 18;
            textBox4.Text = "Отчество";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 156);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(130, 27);
            textBox5.TabIndex = 19;
            textBox5.Text = "Индекс";
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 189);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(130, 27);
            textBox6.TabIndex = 20;
            textBox6.Text = "Город";
            textBox6.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(12, 222);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(130, 27);
            textBox7.TabIndex = 21;
            textBox7.Text = "Адрес";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(12, 255);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(130, 27);
            textBox8.TabIndex = 22;
            textBox8.Text = "Номер телефона";
            textBox8.TextAlign = HorizontalAlignment.Center;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(12, 288);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.Size = new Size(130, 27);
            textBox9.TabIndex = 23;
            textBox9.Text = "Дата заказа";
            textBox9.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(12, 321);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(130, 27);
            textBox10.TabIndex = 24;
            textBox10.Text = "Название заказа";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(12, 354);
            textBox11.Name = "textBox11";
            textBox11.ReadOnly = true;
            textBox11.Size = new Size(130, 27);
            textBox11.TabIndex = 25;
            textBox11.Text = "Цена";
            textBox11.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(12, 387);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(130, 27);
            textBox12.TabIndex = 26;
            textBox12.Text = "Количество";
            textBox12.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            textBox13.Location = new Point(12, 420);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(130, 27);
            textBox13.TabIndex = 27;
            textBox13.Text = "Счёт";
            textBox13.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCancel_KDD
            // 
            buttonCancel_KDD.BackColor = Color.Red;
            buttonCancel_KDD.ForeColor = Color.Black;
            buttonCancel_KDD.Location = new Point(208, 453);
            buttonCancel_KDD.Name = "buttonCancel_KDD";
            buttonCancel_KDD.Size = new Size(149, 31);
            buttonCancel_KDD.TabIndex = 28;
            buttonCancel_KDD.Text = "Отменить заказ";
            buttonCancel_KDD.UseVisualStyleBackColor = false;
            buttonCancel_KDD.Click += buttonCancel_KDD_Click;
            // 
            // AddOrderForm_KDD
            // 
            ClientSize = new Size(396, 514);
            Controls.Add(buttonCancel_KDD);
            Controls.Add(textBox13);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBoxKDD_Number);
            Controls.Add(buttonSaveOrder_KDD);
            Controls.Add(textBoxAccountNumber_KDD);
            Controls.Add(textBoxQuantity_KDD);
            Controls.Add(textBoxPrice_KDD);
            Controls.Add(textBoxOrderName_KDD);
            Controls.Add(dateTimePickerOrderDate_KDD);
            Controls.Add(textBoxPhoneNumber_KDD);
            Controls.Add(textBoxAddress_KDD);
            Controls.Add(textBoxCity_KDD);
            Controls.Add(textBoxIndex_KDD);
            Controls.Add(textBoxMiddleName_KDD);
            Controls.Add(textBoxFirstName_KDD);
            Controls.Add(textBoxLastName_KDD);
            Controls.Add(textBoxOrderNumber_KDD);
            Name = "AddOrderForm_KDD";
            Text = "Добавить заказ";
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox textBoxKDD_Number;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private Button buttonCancel_KDD;
    }
}
