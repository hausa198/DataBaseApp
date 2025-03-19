using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    public partial class ManualAditionForm : Form
    {
        private string MyDataBase { get; set; }
        private MainForm mainForm;
        DataBaseFunctions MyDataBaseFunctions = new DataBaseFunctions();
        public ManualAditionForm(MainForm mf)
        {
            InitializeComponent();
            MyDataBase = "server=localhost;uid=root;pwd=1234;Database=electronics_company";
            mainForm = mf;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            gbProducts.Enabled = false;
            gbCustomers.Enabled = false;
            gbOrders.Enabled = false;   
            gbSuppliers.Enabled = false;

            if (radioButton2.Checked == true){}

            else if (comboBox1.SelectedIndex == 0) 
            {
                gbProducts.Enabled = true;

                MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "products");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                gbCustomers.Enabled = true;

                MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "customers");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                gbOrders.Enabled = true;

                MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "orders");
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                gbSuppliers.Enabled = true;

                MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "suppliers");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            new MySqlConnection(MyDataBase).Open();
            MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "products");

            comboBox1.Items.Add("products");
            comboBox1.Items.Add("customers");
            comboBox1.Items.Add("orders");
            comboBox1.Items.Add("suppliers");
            comboBox1.SelectedItem = "products";

            radioButton1.Enabled = false;
            radioButton2.Enabled = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();

            comboBox1.SelectedIndex = -1;
            comboBox1.Items.Clear();

            new MySqlConnection(MyDataBase).Close();

            radioButton1.Enabled = true;
            radioButton2.Enabled = false;
        }

        private void btRegistrationProducts_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase1 = new MySqlConnection(MyDataBase);
            conDataBase1.Open();
            MySqlCommand cmdDataBase1 = new MySqlCommand("insert into products (Name,Category,Price,QuantityInStock,SupplierID) " +
                "values(@Name,@Category,@Price,@QuantityInStock,@SupplierID)", conDataBase1);

            cmdDataBase1.Parameters.AddWithValue("@Name", (tb_products_Name.Text));
            cmdDataBase1.Parameters.AddWithValue("@Category", (cb_products_Category.SelectedIndex + 1));
            cmdDataBase1.Parameters.AddWithValue("@Price", (tb_products_Price.Text));
            cmdDataBase1.Parameters.AddWithValue("@QuantityInStock", (tb_products_QuantityInStock.Text));
            cmdDataBase1.Parameters.AddWithValue("@SupplierID", (tb_products_SupplierID.Text));

            cmdDataBase1.ExecuteNonQuery();
            conDataBase1.Close();

            MessageBox.Show("Добавихте Успешно!");

            MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "products");
        }

        private void btRegistrationCustomers_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase1 = new MySqlConnection(MyDataBase);
            conDataBase1.Open();
            MySqlCommand cmdDataBase1 = new MySqlCommand
                ("insert into customers (FirstName,LastName,Phone,Email,Address) " +
                "values(@FirstName,@LastName,@Phone,@Email,@Address)", conDataBase1);

            cmdDataBase1.Parameters.AddWithValue("@FirstName", (tb_customers_FirstName.Text));
            cmdDataBase1.Parameters.AddWithValue("@LastName", (tb_customers_LastName.Text));
            cmdDataBase1.Parameters.AddWithValue("@Phone", (tb_customers_Phone.Text));
            cmdDataBase1.Parameters.AddWithValue("@Email", (tb_customers_Email.Text));
            cmdDataBase1.Parameters.AddWithValue("@Address", (tb_customers_Address.Text));

            cmdDataBase1.ExecuteNonQuery();
            conDataBase1.Close();

            MessageBox.Show("Добавихте Успешно!");

            MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "customers");
        }

        private void btRegistrationOrders_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase1 = new MySqlConnection(MyDataBase);
            conDataBase1.Open();
            MySqlCommand cmdDataBase1 = new MySqlCommand("insert into orders (CustomerID,ProductID,Quantity,OrderDate,Status) " +
                "values(@CustomerID,@ProductID,@Quantity,@OrderDate,@Status)", conDataBase1);

            cmdDataBase1.Parameters.AddWithValue("@CustomerID", (tb_orders_CustomerID.Text));
            cmdDataBase1.Parameters.AddWithValue("@ProductID", (tb_orders_ProductID.Text));
            cmdDataBase1.Parameters.AddWithValue("@Quantity", (tb_orders_Quantity.Text));
            cmdDataBase1.Parameters.AddWithValue("@OrderDate", (tb_orders_OrderDate.Text));
            cmdDataBase1.Parameters.AddWithValue("@Status", (cb_orders_Status.SelectedIndex + 1));

            cmdDataBase1.ExecuteNonQuery();
            conDataBase1.Close();

            MessageBox.Show("Добавихте Успешно!");

            MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "orders");
        }

        private void btRegistrationSuppliers_Click(object sender, EventArgs e)
        {
            MySqlConnection conDataBase1 = new MySqlConnection(MyDataBase);
            conDataBase1.Open();
            MySqlCommand cmdDataBase1 = new MySqlCommand("insert into suppliers (Name,ContactEmail,Phone) " +
                "values(@Name,@ContactEmail,@Phone)", conDataBase1);

            cmdDataBase1.Parameters.AddWithValue("@Name", (tb_suppliers_Name.Text));
            cmdDataBase1.Parameters.AddWithValue("@ContactEmail", (tb_suppliers_ContactEmail.Text));
            cmdDataBase1.Parameters.AddWithValue("@Phone", (tb_suppliers_Phone.Text));

            cmdDataBase1.ExecuteNonQuery();
            conDataBase1.Close();

            MessageBox.Show("Добавихте Успешно!");

            MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "suppliers");
        }

        private void btGetCurrentTime_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            tb_orders_OrderDate.Text = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        //TODO: fix memoryleak when going back and forth between forms
        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.Show();
        }

        //TODO: fix event
        private void ManualAditionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            new MySqlConnection(MyDataBase).Close();
            mainForm.Close();
        }
    }
}
