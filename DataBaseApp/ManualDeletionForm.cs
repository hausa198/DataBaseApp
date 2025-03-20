using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DataBaseApp
{
    public partial class ManualDeletionForm: Form
    {
        private string MyDataBase { get; set; }
        private MainForm mainForm;
        DataBaseFunctions MyDataBaseFunctions = new DataBaseFunctions();
        MySqlConnection conDataBase1 = new MySqlConnection();

        private bool IsManuallyClosed = true;
        public ManualDeletionForm(MainForm mf)
        {
            InitializeComponent();
            MyDataBase = "server=localhost;uid=root;pwd=1234;Database=electronics_company";
            conDataBase1.ConnectionString = MyDataBase;
            mainForm = mf;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            gbProducts.Enabled = false;
            gbCustomers.Enabled = false;
            gbOrders.Enabled = false;
            gbSuppliers.Enabled = false;

            if (radioButton2.Checked == true) { }

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
            else if (comboBox1.SelectedIndex == 3)
            {
                gbSuppliers.Enabled = true;

                MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "suppliers");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            if (radioButton1.Checked == true)
            {
                conDataBase1.Open();
                MyDataBaseFunctions.ShowTable(MyDataBase, dataGridView1, "products");

                comboBox1.Items.Add("products");
                comboBox1.Items.Add("customers");
                comboBox1.Items.Add("orders");
                comboBox1.Items.Add("suppliers");
                comboBox1.SelectedItem = "products";

                radioButton1.Enabled = false;
                radioButton2.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = false;
            if (radioButton2.Checked == true)
            {
                dataGridView1.DataSource = null;
                this.dataGridView1.Rows.Clear();

                comboBox1.SelectedIndex = -1;
                comboBox1.Items.Clear();

                conDataBase1.Close();

                radioButton1.Enabled = true;
                radioButton2.Enabled = false;
            }
        }
        private void btFindProducts_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdDataBase1 = new MySqlCommand("SELECT Name, Category, Price, QuantityInStock, SupplierID FROM products WHERE ProductID = @ProductID", conDataBase1);
            cmdDataBase1.Parameters.AddWithValue("@ProductID", tb_products_ProductID.Text);

            MySqlDataReader reader = cmdDataBase1.ExecuteReader();

            if (reader.Read())
            {
                tb_products_Name.Text = reader["Name"].ToString();
                cb_products_Category.Text = reader["Category"].ToString();
                tb_products_Price.Text = reader["Price"].ToString();
                tb_products_QuantityInStock.Text = reader["QuantityInStock"].ToString();
                tb_products_SupplierID.Text = reader["SupplierID"].ToString();
                
                MessageBox.Show("Поръчката е намерена!");

                btRemoveProduct.Enabled = true;    
            }
            else
            {
                MessageBox.Show("Поръчката не е намерена!");

                btRemoveProduct.Enabled = false;
            }

            reader.Close();
        }

        private void btFindCustomers_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdDataBase1 = new MySqlCommand("SELECT FirstName, LastName, Email, Phone, Address FROM customers WHERE CustomerID = @CustomerID", conDataBase1);
            cmdDataBase1.Parameters.AddWithValue("@CustomerID", tb_customers_CustomerID.Text);

            MySqlDataReader reader = cmdDataBase1.ExecuteReader();

            if (reader.Read())
            {
                tb_customers_FirstName.Text = reader["FirstName"].ToString();
                tb_customers_LastName.Text = reader["LastName"].ToString();
                tb_customers_Email.Text = reader["Email"].ToString();
                tb_customers_Phone.Text = reader["Phone"].ToString();
                tb_customers_Address.Text = reader["Address"].ToString();

                MessageBox.Show("Поръчката е намерена!");

                btRemoveCustomer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Поръчката не е намерена!");

                btRemoveCustomer.Enabled = false;
            }

            reader.Close();
        }

        private void btFindOrders_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdDataBase1 = new MySqlCommand("SELECT CustomerID, ProductID, Quantity, OrderDate, Status FROM orders WHERE OrderID = @OrderID", conDataBase1);
            cmdDataBase1.Parameters.AddWithValue("@OrderID", tb_orders_OrderID.Text);

            MySqlDataReader reader = cmdDataBase1.ExecuteReader();

            if (reader.Read())
            {
                tb_orders_CustomerID.Text = reader["CustomerID"].ToString();
                tb_orders_ProductID.Text = reader["ProductID"].ToString();
                tb_orders_Quantity.Text = reader["Quantity"].ToString();
                tb_orders_OrderDate.Text = reader["OrderDate"].ToString();
                cb_orders_Status.Text = reader["Status"].ToString();

                MessageBox.Show("Поръчката е намерена!");

                btRemoveOrder.Enabled = true;
            }
            else
            {
                MessageBox.Show("Поръчката не е намерена!");

                btRemoveOrder.Enabled = false;
            }

            reader.Close();
        }

        private void btFindSuppliers_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdDataBase1 = new MySqlCommand("SELECT Name, ContactEmail, Phone FROM suppliers WHERE SupplierID = @SupplierID", conDataBase1);
            cmdDataBase1.Parameters.AddWithValue("@SupplierID", tb_suppliers_SupplierID.Text);

            MySqlDataReader reader = cmdDataBase1.ExecuteReader();

            if (reader.Read())
            {
                tb_suppliers_Name.Text = reader["Name"].ToString();
                tb_suppliers_ContactEmail.Text = reader["ContactEmail"].ToString();
                tb_suppliers_Phone.Text = reader["Phone"].ToString();

                MessageBox.Show("Поръчката е намерена!");

                btRemoveSupplier.Enabled = true;
            }
            else
            {
                MessageBox.Show("Поръчката не е намерена!");

                btRemoveSupplier.Enabled = false;
            }

            reader.Close();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            IsManuallyClosed = false;
            conDataBase1.Close();
            this.Close();
            mainForm.Show();
            IsManuallyClosed = true;
        }

        private void ManualDeletionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsManuallyClosed == true)
            {
                conDataBase1.Close();
                mainForm.Close();
                IsManuallyClosed = false;
            }
        }

        
    }
}
