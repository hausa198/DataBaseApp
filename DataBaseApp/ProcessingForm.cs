﻿using MySql.Data.MySqlClient;
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
    public partial class ProcessingForm : Form
    {
        // Declaration of variables
        private string MyDataBase { get; set; }
        private LogInForm loginForm;
        MySqlConnection conDataBase1 = new MySqlConnection();

        // Flag for checking if the form is closed manually
        private bool IsManuallyClosed = true;

        // Constructor for the ProcessingForm
        public ProcessingForm(LogInForm lf)
        {
            InitializeComponent();

            // Initialization of the connection to the database
            MyDataBase = "server=localhost;uid=root;pwd=1234;Database=electronics_company";
            conDataBase1.ConnectionString = MyDataBase;

            loginForm = lf;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно добавяне!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка: " + ex.Message);
            }





        }

        // Event that shows the selected table in DataGridView and enables the corresponding group
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            gbProducts.Enabled = false;
            gbCustomers.Enabled = false;
            gbOrders.Enabled = false;   
            gbSuppliers.Enabled = false;

            btEditProduct.Enabled = false;
            btEditCustomer.Enabled = false;
            btEditOrder.Enabled = false;
            btEditSupplier.Enabled = false;

            btRemoveProduct.Enabled = false;
            btRemoveCustomer.Enabled = false;
            btRemoveOrder.Enabled = false;
            btRemoveSupplier.Enabled = false;

            ClearProductsGB();
            ClearCustomersGB();
            ClearOrdersGB();
            ClearSuppliersGB();

            if (radioButton2.Checked == true){}

            else if (comboBox1.SelectedIndex == 0) 
            {
                gbProducts.Enabled = true;

                ShowTable(MyDataBase, dataGridView1, "products");

            }
            else if (comboBox1.SelectedIndex == 1)
            {
                gbCustomers.Enabled = true;

                ShowTable(MyDataBase, dataGridView1, "customers");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                gbOrders.Enabled = true;

                ShowTable(MyDataBase, dataGridView1, "orders");
            }
            else if(comboBox1.SelectedIndex == 3)
            {
                gbSuppliers.Enabled = true;

                ShowTable(MyDataBase, dataGridView1, "suppliers");
            }
        }

        // Event that connects to the database and shows the selected table
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = true;
            if (radioButton1.Checked == true)
            {
                conDataBase1.Open();
                ShowTable(MyDataBase, dataGridView1, "products");

                comboBox1.Items.Add("products");
                comboBox1.Items.Add("customers");
                comboBox1.Items.Add("orders");
                comboBox1.Items.Add("suppliers");
                comboBox1.SelectedItem = "products";

                radioButton1.Enabled = false;
                radioButton2.Enabled = true;
            }
        }

        // Event that disconnects from the database and brings back the default state of the form
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

        // <-------------------------->
        // Methods for adding records
        private void btRegistrationProducts_Click(object sender, EventArgs e)
        {
            if (Decimal.Parse(tb_products_Price.Text) < 0 || int.Parse(tb_products_QuantityInStock.Text) < 0)
            {
                MessageBox.Show("Цената и количеството не могат да бъдат отрицателни!");
                return;
            }

            try
            {
                MySqlCommand cmdDataBase1 = new MySqlCommand("insert into products (Name,Category,Price,QuantityInStock,SupplierID) " +
                                "values(@Name,@Category,@Price,@QuantityInStock,@SupplierID)", conDataBase1);

                cmdDataBase1.Parameters.AddWithValue("@Name", (tb_products_Name.Text));
                cmdDataBase1.Parameters.AddWithValue("@Category", (cb_products_Category.SelectedIndex + 1));
                cmdDataBase1.Parameters.AddWithValue("@Price", (tb_products_Price.Text));
                cmdDataBase1.Parameters.AddWithValue("@QuantityInStock", (tb_products_QuantityInStock.Text));
                cmdDataBase1.Parameters.AddWithValue("@SupplierID", (tb_products_SupplierID.Text));

                cmdDataBase1.ExecuteNonQuery();

                MessageBox.Show("Добавихте Успешно!");

                ShowTable(MyDataBase, dataGridView1, "products");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при добавяне на продукта: " + ex.Message);
            }
        }

        private void btRegistrationCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdDataBase1 = new MySqlCommand
                ("insert into customers (FirstName,LastName,Phone,Email,Address) " +
                "values(@FirstName,@LastName,@Phone,@Email,@Address)", conDataBase1);

                cmdDataBase1.Parameters.AddWithValue("@FirstName", (tb_customers_FirstName.Text));
                cmdDataBase1.Parameters.AddWithValue("@LastName", (tb_customers_LastName.Text));
                cmdDataBase1.Parameters.AddWithValue("@Phone", (tb_customers_Phone.Text));
                cmdDataBase1.Parameters.AddWithValue("@Email", (tb_customers_Email.Text));
                cmdDataBase1.Parameters.AddWithValue("@Address", (tb_customers_Address.Text));

                cmdDataBase1.ExecuteNonQuery();

                MessageBox.Show("Добавихте Успешно!");

                ShowTable(MyDataBase, dataGridView1, "customers");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Грешка при добавяне на клиента: " + ex.Message);
            }
        }

        private void btRegistrationOrders_Click(object sender, EventArgs e)
        {
            try
            {
                int productId = int.Parse(tb_orders_ProductID.Text);
                int quantityOrdered = int.Parse(tb_orders_Quantity.Text);

                MySqlCommand checkStock = new MySqlCommand(
                    "SELECT QuantityInStock FROM products WHERE ProductID = @ProductID", conDataBase1);
                checkStock.Parameters.AddWithValue("@ProductID", productId);

                int currentStock = Convert.ToInt32(checkStock.ExecuteScalar());

                if (currentStock < quantityOrdered)
                {
                    MessageBox.Show("Няма достатъчно наличност от този продукт!");
                    return;
                }

                MySqlCommand cmdInsert = new MySqlCommand(
                    "INSERT INTO orders (CustomerID, ProductID, Quantity, OrderDate, Status) " +
                    "VALUES (@CustomerID, @ProductID, @Quantity, @OrderDate, @Status)", conDataBase1);

                cmdInsert.Parameters.AddWithValue("@CustomerID", tb_orders_CustomerID.Text);
                cmdInsert.Parameters.AddWithValue("@ProductID", productId);
                cmdInsert.Parameters.AddWithValue("@Quantity", quantityOrdered);
                cmdInsert.Parameters.AddWithValue("@OrderDate", tb_orders_OrderDate.Text);
                cmdInsert.Parameters.AddWithValue("@Status", cb_orders_Status.SelectedIndex + 1);

                cmdInsert.ExecuteNonQuery();

                MySqlCommand updateStock = new MySqlCommand(
                    "UPDATE products SET QuantityInStock = QuantityInStock - @Qty WHERE ProductID = @ProductID", conDataBase1);
                updateStock.Parameters.AddWithValue("@Qty", quantityOrdered);
                updateStock.Parameters.AddWithValue("@ProductID", productId);

                updateStock.ExecuteNonQuery();

                MessageBox.Show("Поръчката беше добавена успешно и количеството е обновено!");
                ShowTable(MyDataBase, dataGridView1, "orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при добавяне на поръчката: " + ex.Message);
            }
        }


        private void btRegistrationSuppliers_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmdDataBase1 = new MySqlCommand("insert into suppliers (Name,ContactEmail,Phone) " +
                "values(@Name,@ContactEmail,@Phone)", conDataBase1);

                cmdDataBase1.Parameters.AddWithValue("@Name", (tb_suppliers_Name.Text));
                cmdDataBase1.Parameters.AddWithValue("@ContactEmail", (tb_suppliers_ContactEmail.Text));
                cmdDataBase1.Parameters.AddWithValue("@Phone", (tb_suppliers_Phone.Text));

                cmdDataBase1.ExecuteNonQuery();

                MessageBox.Show("Добавихте Успешно!");

                ShowTable(MyDataBase, dataGridView1, "suppliers");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Грешка при добавяне на доставчика: " + ex.Message);
            }
        }
        // <-------------------------->

        // <-------------------------->
        // Methods for finding records
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
                btEditProduct.Enabled = true;
            }
            else
            {
                MessageBox.Show("Поръчката не е намерена!");

                btRemoveProduct.Enabled = false;
                btEditProduct.Enabled = false;
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

                MessageBox.Show("Клиента е намерен!");

                btRemoveCustomer.Enabled = true;
                btEditCustomer.Enabled = true;
            }
            else
            {
                MessageBox.Show("Клиента не е намерен!");

                btRemoveCustomer.Enabled = false;
                btEditCustomer.Enabled = false;
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

                DateTime orderDate = Convert.ToDateTime(reader["OrderDate"]);
                tb_orders_OrderDate.Text = orderDate.ToString("yyyy-MM-dd HH:mm:ss");

                cb_orders_Status.Text = reader["Status"].ToString();

                MessageBox.Show("Поръчката е намерена!");

                btRemoveOrder.Enabled = true;
                btEditOrder.Enabled = true;
            }
            else
            {
                MessageBox.Show("Поръчката не е намерена!");

                btRemoveOrder.Enabled = false;
                btEditOrder.Enabled = false;
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

                MessageBox.Show("Доставчика е намерен!");

                btRemoveSupplier.Enabled = true;
                btEditSupplier.Enabled = true;
            }
            else
            {
                MessageBox.Show("Доставчика не е намерен!");

                btRemoveSupplier.Enabled = false;
                btEditSupplier.Enabled = false;
            }

            reader.Close();
        }
        // <-------------------------->

        // <-------------------------->
        // Methods for editing records
        private void btEditProduct_Click(object sender, EventArgs e)
        {
            if(Decimal.Parse(tb_products_Price.Text) < 0 || int.Parse(tb_products_QuantityInStock.Text) < 0)
            {
                MessageBox.Show("Цената и количеството не могат да бъдат отрицателни!");
                return;
            }

            MySqlCommand cmdDataBase1 = new MySqlCommand("UPDATE products SET Name = @Name, Category = @Category, Price = @Price, QuantityInStock = @QuantityInStock, SupplierID = @SupplierID WHERE ProductID = @ProductID", conDataBase1);

            cmdDataBase1.Parameters.AddWithValue("@ProductID", tb_products_ProductID.Text);
            cmdDataBase1.Parameters.AddWithValue("@Name", tb_products_Name.Text);
            cmdDataBase1.Parameters.AddWithValue("@Category", cb_products_Category.SelectedIndex + 1);
            cmdDataBase1.Parameters.AddWithValue("@Price", tb_products_Price.Text);
            cmdDataBase1.Parameters.AddWithValue("@QuantityInStock", tb_products_QuantityInStock.Text);
            cmdDataBase1.Parameters.AddWithValue("@SupplierID", tb_products_SupplierID.Text);

            int rowsAffected = cmdDataBase1.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Продуктът беше успешно редактиран!");
            }
            else
            {
                MessageBox.Show("Грешка при редактирането на продукта!");
            }

            btRemoveProduct.Enabled = false;
            btEditProduct.Enabled = false;
            ShowTable(MyDataBase, dataGridView1, "products");
        }

        private void btEditCustomer_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdDataBase1 = new MySqlCommand("UPDATE customers SET FirstName = @FirstName, LastName = @LastName, Email = @Email, Phone = @Phone, Address = @Address WHERE CustomerID = @CustomerID", conDataBase1);

            cmdDataBase1.Parameters.AddWithValue("@CustomerID", tb_customers_CustomerID.Text);
            cmdDataBase1.Parameters.AddWithValue("@FirstName", tb_customers_FirstName.Text);
            cmdDataBase1.Parameters.AddWithValue("@LastName", tb_customers_LastName.Text);
            cmdDataBase1.Parameters.AddWithValue("@Email", tb_customers_Email.Text);
            cmdDataBase1.Parameters.AddWithValue("@Phone", tb_customers_Phone.Text);
            cmdDataBase1.Parameters.AddWithValue("@Address", tb_customers_Address.Text);

            int rowsAffected = cmdDataBase1.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Клиентът беше успешно редактиран!");
            }
            else
            {
                MessageBox.Show("Грешка при редактирането на клиента!");
            }

            btRemoveCustomer.Enabled = false;
            btEditCustomer.Enabled = false;
            ShowTable(MyDataBase, dataGridView1, "customers");
        }

        private void btEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                int orderId = int.Parse(tb_orders_OrderID.Text);
                int newQty = int.Parse(tb_orders_Quantity.Text);
                int productId = int.Parse(tb_orders_ProductID.Text);

                MySqlCommand getOldQtyCmd = new MySqlCommand(
                    "SELECT Quantity FROM orders WHERE OrderID = @OrderID", conDataBase1);
                getOldQtyCmd.Parameters.AddWithValue("@OrderID", orderId);

                int oldQty = Convert.ToInt32(getOldQtyCmd.ExecuteScalar());
                int qtyDifference = newQty - oldQty;

                MySqlCommand getStockCmd = new MySqlCommand(
                    "SELECT QuantityInStock FROM products WHERE ProductID = @ProductID", conDataBase1);
                getStockCmd.Parameters.AddWithValue("@ProductID", productId);

                int stock = Convert.ToInt32(getStockCmd.ExecuteScalar());

                if (qtyDifference > stock)
                {
                    MessageBox.Show("Недостатъчна наличност за редактиране на поръчката!");
                    return;
                }

                MySqlCommand updateOrder = new MySqlCommand(
                    "UPDATE orders SET CustomerID = @CustomerID, ProductID = @ProductID, Quantity = @Quantity, " +
                    "OrderDate = @OrderDate, Status = @Status WHERE OrderID = @OrderID", conDataBase1);

                updateOrder.Parameters.AddWithValue("@OrderID", orderId);
                updateOrder.Parameters.AddWithValue("@CustomerID", tb_orders_CustomerID.Text);
                updateOrder.Parameters.AddWithValue("@ProductID", productId);
                updateOrder.Parameters.AddWithValue("@Quantity", newQty);
                updateOrder.Parameters.AddWithValue("@OrderDate", tb_orders_OrderDate.Text);
                updateOrder.Parameters.AddWithValue("@Status", cb_orders_Status.SelectedIndex + 1);

                updateOrder.ExecuteNonQuery();

                MySqlCommand updateStock = new MySqlCommand(
                    "UPDATE products SET QuantityInStock = QuantityInStock - @Diff WHERE ProductID = @ProductID", conDataBase1);
                updateStock.Parameters.AddWithValue("@Diff", qtyDifference);
                updateStock.Parameters.AddWithValue("@ProductID", productId);

                updateStock.ExecuteNonQuery();

                MessageBox.Show("Поръчката беше успешно редактирана и количеството е актуализирано!");
                ShowTable(MyDataBase, dataGridView1, "orders");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при редактиране на поръчката: " + ex.Message);
            }

            btRemoveOrder.Enabled = false;
            btEditOrder.Enabled = false;
        }

        private void btEditSupplier_Click(object sender, EventArgs e)
        {
            MySqlCommand cmdDataBase1 = new MySqlCommand("UPDATE suppliers SET Name = @Name, ContactEmail = @ContactEmail, Phone = @Phone WHERE SupplierID = @SupplierID", conDataBase1);

            cmdDataBase1.Parameters.AddWithValue("@SupplierID", tb_suppliers_SupplierID.Text);
            cmdDataBase1.Parameters.AddWithValue("@Name", tb_suppliers_Name.Text);
            cmdDataBase1.Parameters.AddWithValue("@ContactEmail", tb_suppliers_ContactEmail.Text);
            cmdDataBase1.Parameters.AddWithValue("@Phone", tb_suppliers_Phone.Text);

            int rowsAffected = cmdDataBase1.ExecuteNonQuery();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Доставчикът беше успешно редактиран!");
            }
            else
            {
                MessageBox.Show("Грешка при редактирането на доставчика!");
            }

            btRemoveSupplier.Enabled = false;
            btEditSupplier.Enabled = false;
            ShowTable(MyDataBase, dataGridView1, "suppliers");
        }
        // <-------------------------->

        // <-------------------------->
        // Methods for removing records
        private void btRemoveProduct_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сигурни ли сте че искате да го изтриете?", "Изтриване", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MySqlCommand cmdDataBase1 = new MySqlCommand("DELETE FROM products WHERE ProductID = @ProductID", conDataBase1);
                cmdDataBase1.Parameters.AddWithValue("@ProductID", tb_products_ProductID.Text);

                int rowsAffected = cmdDataBase1.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Успешно изтрихте продукта!");

                }
                else
                {
                    MessageBox.Show("Продуктът не беше намерен за изтриване!");
                }

                ClearProductsGB();
                btRemoveProduct.Enabled = false;
                btEditProduct.Enabled = false;
                ShowTable(MyDataBase, dataGridView1, "products");
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void btRemoveCustomer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сигурни ли сте че искате да го изтриете?", "Изтриване", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MySqlCommand cmdDataBase1 = new MySqlCommand("DELETE FROM customers WHERE CustomerID = @CustomerID", conDataBase1);
                cmdDataBase1.Parameters.AddWithValue("@CustomerID", tb_customers_CustomerID.Text);

                int rowsAffected = cmdDataBase1.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Успешно изтрихте клиента!");

                }
                else
                {
                    MessageBox.Show("Клиентът не беше намерен за изтриване!");
                }

                ClearCustomersGB();
                btRemoveCustomer.Enabled = false;
                btEditCustomer.Enabled = false;
                ShowTable(MyDataBase, dataGridView1, "customers");
            }
            else if (dialogResult == DialogResult.No) { }
        }

        private void btRemoveOrder_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сигурни ли сте че искате да го изтриете?", "Изтриване", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int orderId = int.Parse(tb_orders_OrderID.Text);

                    MySqlCommand getOrderDetails = new MySqlCommand(
                        "SELECT ProductID, Quantity FROM orders WHERE OrderID = @OrderID", conDataBase1);
                    getOrderDetails.Parameters.AddWithValue("@OrderID", orderId);

                    MySqlDataReader reader = getOrderDetails.ExecuteReader();

                    int productId = -1;
                    int quantityToRestore = 0;

                    if (reader.Read())
                    {
                        productId = Convert.ToInt32(reader["ProductID"]);
                        quantityToRestore = Convert.ToInt32(reader["Quantity"]);
                    }
                    else
                    {
                        reader.Close();
                        MessageBox.Show("Поръчката не беше намерена за изтриване!");
                        return;
                    }

                    reader.Close();

                    MySqlCommand restoreQuantity = new MySqlCommand(
                        "UPDATE products SET QuantityInStock = QuantityInStock + @Qty WHERE ProductID = @ProductID", conDataBase1);
                    restoreQuantity.Parameters.AddWithValue("@Qty", quantityToRestore);
                    restoreQuantity.Parameters.AddWithValue("@ProductID", productId);
                    restoreQuantity.ExecuteNonQuery();

                    MySqlCommand deleteOrder = new MySqlCommand("DELETE FROM orders WHERE OrderID = @OrderID", conDataBase1);
                    deleteOrder.Parameters.AddWithValue("@OrderID", orderId);

                    int rowsAffected = deleteOrder.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Успешно изтрихте поръчката и възстановихте количеството на продукта!");
                    }
                    else
                    {
                        MessageBox.Show("Поръчката не беше намерена за изтриване!");
                    }

                    ClearOrdersGB();
                    btRemoveOrder.Enabled = false;
                    btEditOrder.Enabled = false;
                    ShowTable(MyDataBase, dataGridView1, "orders");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Грешка при изтриване на поръчката: " + ex.Message);
                }
            }
        }

        private void btRemoveSupplier_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Сигурни ли сте че искате да го изтриете?", "Изтриване", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                MySqlCommand cmdDataBase1 = new MySqlCommand("DELETE FROM suppliers WHERE SupplierID = @SupplierID", conDataBase1);
                cmdDataBase1.Parameters.AddWithValue("@SupplierID", tb_suppliers_SupplierID.Text);

                int rowsAffected = cmdDataBase1.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Успешно изтрихте доставчика!");

                }
                else
                {
                    MessageBox.Show("Доставчикът не беше намерен за изтриване!");
                }

                ClearSuppliersGB();
                btRemoveSupplier.Enabled = false;
                btEditSupplier.Enabled = false;
                ShowTable(MyDataBase, dataGridView1, "suppliers");
            }
            else if (dialogResult == DialogResult.No) { }
        }
        // <-------------------------->

        // Method for showing the selected table in DataGridView
        public void ShowTable(string dataBase, DataGridView dataGridView, string table)
        {
            MySqlConnection conDataBase = new MySqlConnection(dataBase);
            MySqlCommand cmdDataBase = new MySqlCommand($"Select *from {table} ", conDataBase);

            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = cmdDataBase;

            DataTable dbTable = new DataTable();
            sda.Fill(dbTable);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = dbTable;

            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = bSource;

            conDataBase.Close();
        }

        // <-------------------------->
        // Methods for clearing the group boxes
        private void ClearProductsGB()
        {
            tb_products_ProductID.Clear();
            tb_products_Name.Clear();
            cb_products_Category.SelectedIndex = -1;
            tb_products_Price.Clear();
            tb_products_QuantityInStock.Clear();
            tb_products_SupplierID.Clear();
        }

        private void ClearCustomersGB()
        {
            tb_customers_CustomerID.Clear();
            tb_customers_FirstName.Clear();
            tb_customers_LastName.Clear();
            tb_customers_Email.Clear();
            tb_customers_Phone.Clear();
            tb_customers_Address.Clear();
        }

        private void ClearOrdersGB()
        {
            tb_orders_OrderID.Clear();
            tb_orders_CustomerID.Clear();
            tb_orders_ProductID.Clear();
            tb_orders_Quantity.Clear();
            tb_orders_OrderDate.Clear();
            cb_orders_Status.SelectedIndex = -1;
        }

        private void ClearSuppliersGB()
        {
            tb_suppliers_SupplierID.Clear();
            tb_suppliers_Name.Clear();
            tb_suppliers_ContactEmail.Clear();
            tb_suppliers_Phone.Clear();
        }
        // <-------------------------->

        // Method for getting the current date and time
        private void btGetCurrentTime_Click(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;

            tb_orders_OrderDate.Text = currentDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // Event which checks if the form is closed manually
        private void ManualAditionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (IsManuallyClosed == true)
            {
                conDataBase1.Close();
                loginForm.Close();
            }
        }

        // Event for closing the form and returning to the login form
        private void btBack_Click(object sender, EventArgs e)
        {
            IsManuallyClosed = false;
            conDataBase1.Close();
            this.Close();
            loginForm.Show();
            IsManuallyClosed = true;
        }
    }
}
