namespace DataBaseApp
{
    partial class ProcessingForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbProducts = new System.Windows.Forms.GroupBox();
            this.btEditProduct = new System.Windows.Forms.Button();
            this.btFindProducts = new System.Windows.Forms.Button();
            this.btRemoveProduct = new System.Windows.Forms.Button();
            this.cb_products_Category = new System.Windows.Forms.ComboBox();
            this.btRegistrationProducts = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_products_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_products_ProductID = new System.Windows.Forms.TextBox();
            this.tb_products_QuantityInStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_products_SupplierID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_products_Price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_customers_CustomerID = new System.Windows.Forms.TextBox();
            this.gbCustomers = new System.Windows.Forms.GroupBox();
            this.btFindCustomers = new System.Windows.Forms.Button();
            this.btEditCustomer = new System.Windows.Forms.Button();
            this.btRemoveCustomer = new System.Windows.Forms.Button();
            this.btRegistrationCustomers = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_customers_LastName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_customers_Address = new System.Windows.Forms.TextBox();
            this.tb_customers_Email = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tb_customers_FirstName = new System.Windows.Forms.TextBox();
            this.tb_customers_Phone = new System.Windows.Forms.TextBox();
            this.gbOrders = new System.Windows.Forms.GroupBox();
            this.btFindOrders = new System.Windows.Forms.Button();
            this.btEditOrder = new System.Windows.Forms.Button();
            this.btRemoveOrder = new System.Windows.Forms.Button();
            this.btGetCurrentTime = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.cb_orders_Status = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tb_orders_OrderDate = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb_orders_Quantity = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb_orders_ProductID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb_orders_CustomerID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_orders_OrderID = new System.Windows.Forms.TextBox();
            this.btRegistrationOrders = new System.Windows.Forms.Button();
            this.tb_suppliers_SupplierID = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.gbSuppliers = new System.Windows.Forms.GroupBox();
            this.btRemoveSupplier = new System.Windows.Forms.Button();
            this.btEditSupplier = new System.Windows.Forms.Button();
            this.btFindSuppliers = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btRegistrationSuppliers = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_suppliers_Name = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tb_suppliers_ContactEmail = new System.Windows.Forms.TextBox();
            this.tb_suppliers_Phone = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbProducts.SuspendLayout();
            this.gbCustomers.SuspendLayout();
            this.gbOrders.SuspendLayout();
            this.gbSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(999, 828);
            this.dataGridView1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.Enabled = false;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(18, 43);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(997, 37);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Таблица";
            // 
            // gbProducts
            // 
            this.gbProducts.Controls.Add(this.btEditProduct);
            this.gbProducts.Controls.Add(this.btFindProducts);
            this.gbProducts.Controls.Add(this.btRemoveProduct);
            this.gbProducts.Controls.Add(this.cb_products_Category);
            this.gbProducts.Controls.Add(this.btRegistrationProducts);
            this.gbProducts.Controls.Add(this.label4);
            this.gbProducts.Controls.Add(this.label6);
            this.gbProducts.Controls.Add(this.label3);
            this.gbProducts.Controls.Add(this.tb_products_Name);
            this.gbProducts.Controls.Add(this.label2);
            this.gbProducts.Controls.Add(this.tb_products_ProductID);
            this.gbProducts.Controls.Add(this.tb_products_QuantityInStock);
            this.gbProducts.Controls.Add(this.label7);
            this.gbProducts.Controls.Add(this.tb_products_SupplierID);
            this.gbProducts.Controls.Add(this.label5);
            this.gbProducts.Controls.Add(this.tb_products_Price);
            this.gbProducts.Enabled = false;
            this.gbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbProducts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.gbProducts.Location = new System.Drawing.Point(1026, 92);
            this.gbProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProducts.Name = "gbProducts";
            this.gbProducts.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProducts.Size = new System.Drawing.Size(300, 828);
            this.gbProducts.TabIndex = 5;
            this.gbProducts.TabStop = false;
            this.gbProducts.Text = "products";
            // 
            // btEditProduct
            // 
            this.btEditProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btEditProduct.Enabled = false;
            this.btEditProduct.FlatAppearance.BorderSize = 0;
            this.btEditProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditProduct.ForeColor = System.Drawing.Color.White;
            this.btEditProduct.Location = new System.Drawing.Point(8, 731);
            this.btEditProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEditProduct.Name = "btEditProduct";
            this.btEditProduct.Size = new System.Drawing.Size(286, 38);
            this.btEditProduct.TabIndex = 36;
            this.btEditProduct.Text = "Редактиране";
            this.btEditProduct.UseVisualStyleBackColor = false;
            this.btEditProduct.Click += new System.EventHandler(this.btEditProduct_Click);
            // 
            // btFindProducts
            // 
            this.btFindProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btFindProducts.FlatAppearance.BorderSize = 0;
            this.btFindProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFindProducts.ForeColor = System.Drawing.Color.White;
            this.btFindProducts.Location = new System.Drawing.Point(8, 112);
            this.btFindProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFindProducts.Name = "btFindProducts";
            this.btFindProducts.Size = new System.Drawing.Size(284, 38);
            this.btFindProducts.TabIndex = 35;
            this.btFindProducts.Text = "Намери";
            this.btFindProducts.UseVisualStyleBackColor = false;
            this.btFindProducts.Click += new System.EventHandler(this.btFindProducts_Click);
            // 
            // btRemoveProduct
            // 
            this.btRemoveProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btRemoveProduct.Enabled = false;
            this.btRemoveProduct.FlatAppearance.BorderSize = 0;
            this.btRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRemoveProduct.ForeColor = System.Drawing.Color.White;
            this.btRemoveProduct.Location = new System.Drawing.Point(8, 778);
            this.btRemoveProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRemoveProduct.Name = "btRemoveProduct";
            this.btRemoveProduct.Size = new System.Drawing.Size(286, 38);
            this.btRemoveProduct.TabIndex = 32;
            this.btRemoveProduct.Text = "Изтриване";
            this.btRemoveProduct.UseVisualStyleBackColor = false;
            this.btRemoveProduct.Click += new System.EventHandler(this.btRemoveProduct_Click);
            // 
            // cb_products_Category
            // 
            this.cb_products_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_products_Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.cb_products_Category.FormattingEnabled = true;
            this.cb_products_Category.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Server"});
            this.cb_products_Category.Location = new System.Drawing.Point(14, 269);
            this.cb_products_Category.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_products_Category.Name = "cb_products_Category";
            this.cb_products_Category.Size = new System.Drawing.Size(148, 37);
            this.cb_products_Category.TabIndex = 30;
            // 
            // btRegistrationProducts
            // 
            this.btRegistrationProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btRegistrationProducts.FlatAppearance.BorderSize = 0;
            this.btRegistrationProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrationProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegistrationProducts.ForeColor = System.Drawing.Color.White;
            this.btRegistrationProducts.Location = new System.Drawing.Point(8, 683);
            this.btRegistrationProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrationProducts.Name = "btRegistrationProducts";
            this.btRegistrationProducts.Size = new System.Drawing.Size(284, 38);
            this.btRegistrationProducts.TabIndex = 6;
            this.btRegistrationProducts.Text = "Записване";
            this.btRegistrationProducts.UseVisualStyleBackColor = false;
            this.btRegistrationProducts.Click += new System.EventHandler(this.btRegistrationProducts_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(8, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label6.Location = new System.Drawing.Point(8, 398);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "QuantityInStock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(8, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name";
            // 
            // tb_products_Name
            // 
            this.tb_products_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_products_Name.Location = new System.Drawing.Point(14, 189);
            this.tb_products_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_Name.Name = "tb_products_Name";
            this.tb_products_Name.Size = new System.Drawing.Size(278, 35);
            this.tb_products_Name.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(3, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "ProductID";
            // 
            // tb_products_ProductID
            // 
            this.tb_products_ProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_products_ProductID.Location = new System.Drawing.Point(9, 69);
            this.tb_products_ProductID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_ProductID.Name = "tb_products_ProductID";
            this.tb_products_ProductID.Size = new System.Drawing.Size(283, 35);
            this.tb_products_ProductID.TabIndex = 0;
            // 
            // tb_products_QuantityInStock
            // 
            this.tb_products_QuantityInStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_products_QuantityInStock.Location = new System.Drawing.Point(14, 432);
            this.tb_products_QuantityInStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_QuantityInStock.Name = "tb_products_QuantityInStock";
            this.tb_products_QuantityInStock.Size = new System.Drawing.Size(278, 35);
            this.tb_products_QuantityInStock.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label7.Location = new System.Drawing.Point(8, 478);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "SupplierID";
            // 
            // tb_products_SupplierID
            // 
            this.tb_products_SupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_products_SupplierID.Location = new System.Drawing.Point(14, 512);
            this.tb_products_SupplierID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_SupplierID.Name = "tb_products_SupplierID";
            this.tb_products_SupplierID.Size = new System.Drawing.Size(278, 35);
            this.tb_products_SupplierID.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label5.Location = new System.Drawing.Point(8, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Price";
            // 
            // tb_products_Price
            // 
            this.tb_products_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_products_Price.Location = new System.Drawing.Point(14, 349);
            this.tb_products_Price.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_products_Price.Name = "tb_products_Price";
            this.tb_products_Price.Size = new System.Drawing.Size(278, 35);
            this.tb_products_Price.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label8.Location = new System.Drawing.Point(3, 34);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "CustomerID";
            // 
            // tb_customers_CustomerID
            // 
            this.tb_customers_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_customers_CustomerID.Location = new System.Drawing.Point(9, 68);
            this.tb_customers_CustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_CustomerID.Name = "tb_customers_CustomerID";
            this.tb_customers_CustomerID.Size = new System.Drawing.Size(283, 35);
            this.tb_customers_CustomerID.TabIndex = 9;
            // 
            // gbCustomers
            // 
            this.gbCustomers.Controls.Add(this.btFindCustomers);
            this.gbCustomers.Controls.Add(this.btEditCustomer);
            this.gbCustomers.Controls.Add(this.btRemoveCustomer);
            this.gbCustomers.Controls.Add(this.btRegistrationCustomers);
            this.gbCustomers.Controls.Add(this.label8);
            this.gbCustomers.Controls.Add(this.label10);
            this.gbCustomers.Controls.Add(this.tb_customers_LastName);
            this.gbCustomers.Controls.Add(this.label13);
            this.gbCustomers.Controls.Add(this.label11);
            this.gbCustomers.Controls.Add(this.tb_customers_CustomerID);
            this.gbCustomers.Controls.Add(this.tb_customers_Address);
            this.gbCustomers.Controls.Add(this.tb_customers_Email);
            this.gbCustomers.Controls.Add(this.label9);
            this.gbCustomers.Controls.Add(this.label12);
            this.gbCustomers.Controls.Add(this.tb_customers_FirstName);
            this.gbCustomers.Controls.Add(this.tb_customers_Phone);
            this.gbCustomers.Enabled = false;
            this.gbCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbCustomers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.gbCustomers.Location = new System.Drawing.Point(1335, 94);
            this.gbCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCustomers.Name = "gbCustomers";
            this.gbCustomers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbCustomers.Size = new System.Drawing.Size(300, 825);
            this.gbCustomers.TabIndex = 11;
            this.gbCustomers.TabStop = false;
            this.gbCustomers.Text = "customers";
            // 
            // btFindCustomers
            // 
            this.btFindCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btFindCustomers.FlatAppearance.BorderSize = 0;
            this.btFindCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFindCustomers.ForeColor = System.Drawing.Color.White;
            this.btFindCustomers.Location = new System.Drawing.Point(9, 109);
            this.btFindCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFindCustomers.Name = "btFindCustomers";
            this.btFindCustomers.Size = new System.Drawing.Size(284, 38);
            this.btFindCustomers.TabIndex = 36;
            this.btFindCustomers.Text = "Намери";
            this.btFindCustomers.UseVisualStyleBackColor = false;
            this.btFindCustomers.Click += new System.EventHandler(this.btFindCustomers_Click);
            // 
            // btEditCustomer
            // 
            this.btEditCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btEditCustomer.Enabled = false;
            this.btEditCustomer.FlatAppearance.BorderSize = 0;
            this.btEditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditCustomer.ForeColor = System.Drawing.Color.White;
            this.btEditCustomer.Location = new System.Drawing.Point(8, 729);
            this.btEditCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEditCustomer.Name = "btEditCustomer";
            this.btEditCustomer.Size = new System.Drawing.Size(286, 38);
            this.btEditCustomer.TabIndex = 37;
            this.btEditCustomer.Text = "Редактиране";
            this.btEditCustomer.UseVisualStyleBackColor = false;
            this.btEditCustomer.Click += new System.EventHandler(this.btEditCustomer_Click);
            // 
            // btRemoveCustomer
            // 
            this.btRemoveCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btRemoveCustomer.Enabled = false;
            this.btRemoveCustomer.FlatAppearance.BorderSize = 0;
            this.btRemoveCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRemoveCustomer.ForeColor = System.Drawing.Color.White;
            this.btRemoveCustomer.Location = new System.Drawing.Point(8, 777);
            this.btRemoveCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRemoveCustomer.Name = "btRemoveCustomer";
            this.btRemoveCustomer.Size = new System.Drawing.Size(286, 38);
            this.btRemoveCustomer.TabIndex = 33;
            this.btRemoveCustomer.Text = "Изтриване";
            this.btRemoveCustomer.UseVisualStyleBackColor = false;
            this.btRemoveCustomer.Click += new System.EventHandler(this.btRemoveCustomer_Click);
            // 
            // btRegistrationCustomers
            // 
            this.btRegistrationCustomers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btRegistrationCustomers.FlatAppearance.BorderSize = 0;
            this.btRegistrationCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrationCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegistrationCustomers.ForeColor = System.Drawing.Color.White;
            this.btRegistrationCustomers.Location = new System.Drawing.Point(8, 682);
            this.btRegistrationCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrationCustomers.Name = "btRegistrationCustomers";
            this.btRegistrationCustomers.Size = new System.Drawing.Size(286, 38);
            this.btRegistrationCustomers.TabIndex = 6;
            this.btRegistrationCustomers.Text = "Записване";
            this.btRegistrationCustomers.UseVisualStyleBackColor = false;
            this.btRegistrationCustomers.Click += new System.EventHandler(this.btRegistrationCustomers_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label10.Location = new System.Drawing.Point(3, 232);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 6;
            this.label10.Text = "LastName";
            // 
            // tb_customers_LastName
            // 
            this.tb_customers_LastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_customers_LastName.Location = new System.Drawing.Point(9, 269);
            this.tb_customers_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_LastName.Name = "tb_customers_LastName";
            this.tb_customers_LastName.Size = new System.Drawing.Size(283, 35);
            this.tb_customers_LastName.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label13.Location = new System.Drawing.Point(3, 475);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(109, 29);
            this.label13.TabIndex = 16;
            this.label13.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label11.Location = new System.Drawing.Point(3, 312);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 29);
            this.label11.TabIndex = 12;
            this.label11.Text = "Email";
            // 
            // tb_customers_Address
            // 
            this.tb_customers_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_customers_Address.Location = new System.Drawing.Point(9, 512);
            this.tb_customers_Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_Address.Name = "tb_customers_Address";
            this.tb_customers_Address.Size = new System.Drawing.Size(283, 35);
            this.tb_customers_Address.TabIndex = 15;
            // 
            // tb_customers_Email
            // 
            this.tb_customers_Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_customers_Email.Location = new System.Drawing.Point(9, 349);
            this.tb_customers_Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_Email.Name = "tb_customers_Email";
            this.tb_customers_Email.Size = new System.Drawing.Size(283, 35);
            this.tb_customers_Email.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label9.Location = new System.Drawing.Point(3, 152);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 29);
            this.label9.TabIndex = 8;
            this.label9.Text = "FirstName";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label12.Location = new System.Drawing.Point(3, 395);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "Phone";
            // 
            // tb_customers_FirstName
            // 
            this.tb_customers_FirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_customers_FirstName.Location = new System.Drawing.Point(9, 189);
            this.tb_customers_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_FirstName.Name = "tb_customers_FirstName";
            this.tb_customers_FirstName.Size = new System.Drawing.Size(283, 35);
            this.tb_customers_FirstName.TabIndex = 7;
            // 
            // tb_customers_Phone
            // 
            this.tb_customers_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_customers_Phone.Location = new System.Drawing.Point(9, 432);
            this.tb_customers_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_customers_Phone.Name = "tb_customers_Phone";
            this.tb_customers_Phone.Size = new System.Drawing.Size(283, 35);
            this.tb_customers_Phone.TabIndex = 13;
            // 
            // gbOrders
            // 
            this.gbOrders.Controls.Add(this.btFindOrders);
            this.gbOrders.Controls.Add(this.btEditOrder);
            this.gbOrders.Controls.Add(this.btRemoveOrder);
            this.gbOrders.Controls.Add(this.btGetCurrentTime);
            this.gbOrders.Controls.Add(this.label24);
            this.gbOrders.Controls.Add(this.cb_orders_Status);
            this.gbOrders.Controls.Add(this.label19);
            this.gbOrders.Controls.Add(this.label18);
            this.gbOrders.Controls.Add(this.tb_orders_OrderDate);
            this.gbOrders.Controls.Add(this.label17);
            this.gbOrders.Controls.Add(this.tb_orders_Quantity);
            this.gbOrders.Controls.Add(this.label16);
            this.gbOrders.Controls.Add(this.tb_orders_ProductID);
            this.gbOrders.Controls.Add(this.label15);
            this.gbOrders.Controls.Add(this.tb_orders_CustomerID);
            this.gbOrders.Controls.Add(this.label14);
            this.gbOrders.Controls.Add(this.tb_orders_OrderID);
            this.gbOrders.Controls.Add(this.btRegistrationOrders);
            this.gbOrders.Enabled = false;
            this.gbOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.gbOrders.Location = new System.Drawing.Point(1644, 95);
            this.gbOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrders.Name = "gbOrders";
            this.gbOrders.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbOrders.Size = new System.Drawing.Size(300, 825);
            this.gbOrders.TabIndex = 11;
            this.gbOrders.TabStop = false;
            this.gbOrders.Text = "orders";
            // 
            // btFindOrders
            // 
            this.btFindOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btFindOrders.FlatAppearance.BorderSize = 0;
            this.btFindOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFindOrders.ForeColor = System.Drawing.Color.White;
            this.btFindOrders.Location = new System.Drawing.Point(8, 109);
            this.btFindOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFindOrders.Name = "btFindOrders";
            this.btFindOrders.Size = new System.Drawing.Size(284, 38);
            this.btFindOrders.TabIndex = 37;
            this.btFindOrders.Text = "Намери";
            this.btFindOrders.UseVisualStyleBackColor = false;
            this.btFindOrders.Click += new System.EventHandler(this.btFindOrders_Click);
            // 
            // btEditOrder
            // 
            this.btEditOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btEditOrder.Enabled = false;
            this.btEditOrder.FlatAppearance.BorderSize = 0;
            this.btEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditOrder.ForeColor = System.Drawing.Color.White;
            this.btEditOrder.Location = new System.Drawing.Point(8, 728);
            this.btEditOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEditOrder.Name = "btEditOrder";
            this.btEditOrder.Size = new System.Drawing.Size(286, 38);
            this.btEditOrder.TabIndex = 38;
            this.btEditOrder.Text = "Редактиране";
            this.btEditOrder.UseVisualStyleBackColor = false;
            this.btEditOrder.Click += new System.EventHandler(this.btEditOrder_Click);
            // 
            // btRemoveOrder
            // 
            this.btRemoveOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btRemoveOrder.Enabled = false;
            this.btRemoveOrder.FlatAppearance.BorderSize = 0;
            this.btRemoveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRemoveOrder.ForeColor = System.Drawing.Color.White;
            this.btRemoveOrder.Location = new System.Drawing.Point(8, 775);
            this.btRemoveOrder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRemoveOrder.Name = "btRemoveOrder";
            this.btRemoveOrder.Size = new System.Drawing.Size(286, 38);
            this.btRemoveOrder.TabIndex = 34;
            this.btRemoveOrder.Text = "Изтриване";
            this.btRemoveOrder.UseVisualStyleBackColor = false;
            this.btRemoveOrder.Click += new System.EventHandler(this.btRemoveOrder_Click);
            // 
            // btGetCurrentTime
            // 
            this.btGetCurrentTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btGetCurrentTime.FlatAppearance.BorderSize = 0;
            this.btGetCurrentTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGetCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGetCurrentTime.ForeColor = System.Drawing.Color.White;
            this.btGetCurrentTime.Location = new System.Drawing.Point(36, 505);
            this.btGetCurrentTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btGetCurrentTime.Name = "btGetCurrentTime";
            this.btGetCurrentTime.Size = new System.Drawing.Size(222, 78);
            this.btGetCurrentTime.TabIndex = 31;
            this.btGetCurrentTime.Text = "Сегашното време";
            this.btGetCurrentTime.UseVisualStyleBackColor = false;
            this.btGetCurrentTime.Click += new System.EventHandler(this.btGetCurrentTime_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label24.Location = new System.Drawing.Point(18, 474);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(266, 25);
            this.label24.TabIndex = 30;
            this.label24.Text = "YYYY-MM-DD HH:MM:SS";
            // 
            // cb_orders_Status
            // 
            this.cb_orders_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_orders_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.cb_orders_Status.FormattingEnabled = true;
            this.cb_orders_Status.Items.AddRange(new object[] {
            "Pending",
            "In Progress",
            "Delivered",
            "Cancelled"});
            this.cb_orders_Status.Location = new System.Drawing.Point(9, 628);
            this.cb_orders_Status.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_orders_Status.Name = "cb_orders_Status";
            this.cb_orders_Status.Size = new System.Drawing.Size(148, 37);
            this.cb_orders_Status.TabIndex = 29;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label19.Location = new System.Drawing.Point(9, 591);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(85, 29);
            this.label19.TabIndex = 28;
            this.label19.Text = "Status";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label18.Location = new System.Drawing.Point(4, 395);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 29);
            this.label18.TabIndex = 26;
            this.label18.Text = "OrderDate";
            // 
            // tb_orders_OrderDate
            // 
            this.tb_orders_OrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_orders_OrderDate.Location = new System.Drawing.Point(10, 429);
            this.tb_orders_OrderDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_OrderDate.Name = "tb_orders_OrderDate";
            this.tb_orders_OrderDate.Size = new System.Drawing.Size(282, 35);
            this.tb_orders_OrderDate.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label17.Location = new System.Drawing.Point(4, 312);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 29);
            this.label17.TabIndex = 24;
            this.label17.Text = "Quantity";
            // 
            // tb_orders_Quantity
            // 
            this.tb_orders_Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_orders_Quantity.Location = new System.Drawing.Point(10, 348);
            this.tb_orders_Quantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_Quantity.Name = "tb_orders_Quantity";
            this.tb_orders_Quantity.Size = new System.Drawing.Size(282, 35);
            this.tb_orders_Quantity.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label16.Location = new System.Drawing.Point(4, 232);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 29);
            this.label16.TabIndex = 22;
            this.label16.Text = "ProductID";
            // 
            // tb_orders_ProductID
            // 
            this.tb_orders_ProductID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_orders_ProductID.Location = new System.Drawing.Point(10, 268);
            this.tb_orders_ProductID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_ProductID.Name = "tb_orders_ProductID";
            this.tb_orders_ProductID.Size = new System.Drawing.Size(282, 35);
            this.tb_orders_ProductID.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label15.Location = new System.Drawing.Point(4, 152);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(150, 29);
            this.label15.TabIndex = 20;
            this.label15.Text = "CustomerID";
            // 
            // tb_orders_CustomerID
            // 
            this.tb_orders_CustomerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_orders_CustomerID.Location = new System.Drawing.Point(10, 188);
            this.tb_orders_CustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_CustomerID.Name = "tb_orders_CustomerID";
            this.tb_orders_CustomerID.Size = new System.Drawing.Size(282, 35);
            this.tb_orders_CustomerID.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label14.Location = new System.Drawing.Point(3, 31);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 29);
            this.label14.TabIndex = 18;
            this.label14.Text = "OrderID";
            // 
            // tb_orders_OrderID
            // 
            this.tb_orders_OrderID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_orders_OrderID.Location = new System.Drawing.Point(9, 66);
            this.tb_orders_OrderID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_orders_OrderID.Name = "tb_orders_OrderID";
            this.tb_orders_OrderID.Size = new System.Drawing.Size(282, 35);
            this.tb_orders_OrderID.TabIndex = 17;
            // 
            // btRegistrationOrders
            // 
            this.btRegistrationOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btRegistrationOrders.FlatAppearance.BorderSize = 0;
            this.btRegistrationOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrationOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegistrationOrders.ForeColor = System.Drawing.Color.White;
            this.btRegistrationOrders.Location = new System.Drawing.Point(8, 680);
            this.btRegistrationOrders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrationOrders.Name = "btRegistrationOrders";
            this.btRegistrationOrders.Size = new System.Drawing.Size(286, 38);
            this.btRegistrationOrders.TabIndex = 6;
            this.btRegistrationOrders.Text = "Записване";
            this.btRegistrationOrders.UseVisualStyleBackColor = false;
            this.btRegistrationOrders.Click += new System.EventHandler(this.btRegistrationOrders_Click);
            // 
            // tb_suppliers_SupplierID
            // 
            this.tb_suppliers_SupplierID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_suppliers_SupplierID.Location = new System.Drawing.Point(9, 66);
            this.tb_suppliers_SupplierID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_suppliers_SupplierID.Name = "tb_suppliers_SupplierID";
            this.tb_suppliers_SupplierID.Size = new System.Drawing.Size(283, 35);
            this.tb_suppliers_SupplierID.TabIndex = 27;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.radioButton1.Location = new System.Drawing.Point(1026, 49);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(173, 33);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Свързване";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbSuppliers
            // 
            this.gbSuppliers.Controls.Add(this.btRemoveSupplier);
            this.gbSuppliers.Controls.Add(this.btEditSupplier);
            this.gbSuppliers.Controls.Add(this.btFindSuppliers);
            this.gbSuppliers.Controls.Add(this.label23);
            this.gbSuppliers.Controls.Add(this.btRegistrationSuppliers);
            this.gbSuppliers.Controls.Add(this.tb_suppliers_SupplierID);
            this.gbSuppliers.Controls.Add(this.label20);
            this.gbSuppliers.Controls.Add(this.tb_suppliers_Name);
            this.gbSuppliers.Controls.Add(this.label21);
            this.gbSuppliers.Controls.Add(this.label22);
            this.gbSuppliers.Controls.Add(this.tb_suppliers_ContactEmail);
            this.gbSuppliers.Controls.Add(this.tb_suppliers_Phone);
            this.gbSuppliers.Enabled = false;
            this.gbSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSuppliers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.gbSuppliers.Location = new System.Drawing.Point(1953, 95);
            this.gbSuppliers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSuppliers.Name = "gbSuppliers";
            this.gbSuppliers.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbSuppliers.Size = new System.Drawing.Size(300, 825);
            this.gbSuppliers.TabIndex = 17;
            this.gbSuppliers.TabStop = false;
            this.gbSuppliers.Text = "suppliers";
            // 
            // btRemoveSupplier
            // 
            this.btRemoveSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btRemoveSupplier.Enabled = false;
            this.btRemoveSupplier.FlatAppearance.BorderSize = 0;
            this.btRemoveSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRemoveSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRemoveSupplier.ForeColor = System.Drawing.Color.White;
            this.btRemoveSupplier.Location = new System.Drawing.Point(8, 775);
            this.btRemoveSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRemoveSupplier.Name = "btRemoveSupplier";
            this.btRemoveSupplier.Size = new System.Drawing.Size(286, 38);
            this.btRemoveSupplier.TabIndex = 35;
            this.btRemoveSupplier.Text = "Изтриване";
            this.btRemoveSupplier.UseVisualStyleBackColor = false;
            this.btRemoveSupplier.Click += new System.EventHandler(this.btRemoveSupplier_Click);
            // 
            // btEditSupplier
            // 
            this.btEditSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btEditSupplier.Enabled = false;
            this.btEditSupplier.FlatAppearance.BorderSize = 0;
            this.btEditSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEditSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEditSupplier.ForeColor = System.Drawing.Color.White;
            this.btEditSupplier.Location = new System.Drawing.Point(8, 728);
            this.btEditSupplier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btEditSupplier.Name = "btEditSupplier";
            this.btEditSupplier.Size = new System.Drawing.Size(286, 38);
            this.btEditSupplier.TabIndex = 39;
            this.btEditSupplier.Text = "Редактиране";
            this.btEditSupplier.UseVisualStyleBackColor = false;
            this.btEditSupplier.Click += new System.EventHandler(this.btEditSupplier_Click);
            // 
            // btFindSuppliers
            // 
            this.btFindSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btFindSuppliers.FlatAppearance.BorderSize = 0;
            this.btFindSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFindSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btFindSuppliers.ForeColor = System.Drawing.Color.White;
            this.btFindSuppliers.Location = new System.Drawing.Point(9, 109);
            this.btFindSuppliers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFindSuppliers.Name = "btFindSuppliers";
            this.btFindSuppliers.Size = new System.Drawing.Size(284, 38);
            this.btFindSuppliers.TabIndex = 38;
            this.btFindSuppliers.Text = "Намери";
            this.btFindSuppliers.UseVisualStyleBackColor = false;
            this.btFindSuppliers.Click += new System.EventHandler(this.btFindSuppliers_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label23.Location = new System.Drawing.Point(3, 309);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 29);
            this.label23.TabIndex = 18;
            this.label23.Text = "Phone";
            // 
            // btRegistrationSuppliers
            // 
            this.btRegistrationSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btRegistrationSuppliers.FlatAppearance.BorderSize = 0;
            this.btRegistrationSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegistrationSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegistrationSuppliers.ForeColor = System.Drawing.Color.White;
            this.btRegistrationSuppliers.Location = new System.Drawing.Point(8, 680);
            this.btRegistrationSuppliers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRegistrationSuppliers.Name = "btRegistrationSuppliers";
            this.btRegistrationSuppliers.Size = new System.Drawing.Size(286, 38);
            this.btRegistrationSuppliers.TabIndex = 6;
            this.btRegistrationSuppliers.Text = "Записване";
            this.btRegistrationSuppliers.UseVisualStyleBackColor = false;
            this.btRegistrationSuppliers.Click += new System.EventHandler(this.btRegistrationSuppliers_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label20.Location = new System.Drawing.Point(3, 31);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 29);
            this.label20.TabIndex = 6;
            this.label20.Text = "SupplierID";
            // 
            // tb_suppliers_Name
            // 
            this.tb_suppliers_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_suppliers_Name.Location = new System.Drawing.Point(9, 185);
            this.tb_suppliers_Name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_suppliers_Name.Name = "tb_suppliers_Name";
            this.tb_suppliers_Name.Size = new System.Drawing.Size(283, 35);
            this.tb_suppliers_Name.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label21.Location = new System.Drawing.Point(3, 152);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 29);
            this.label21.TabIndex = 12;
            this.label21.Text = "Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.label22.Location = new System.Drawing.Point(3, 229);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(167, 29);
            this.label22.TabIndex = 16;
            this.label22.Text = "ContactEmail";
            // 
            // tb_suppliers_ContactEmail
            // 
            this.tb_suppliers_ContactEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_suppliers_ContactEmail.Location = new System.Drawing.Point(9, 265);
            this.tb_suppliers_ContactEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_suppliers_ContactEmail.Name = "tb_suppliers_ContactEmail";
            this.tb_suppliers_ContactEmail.Size = new System.Drawing.Size(283, 35);
            this.tb_suppliers_ContactEmail.TabIndex = 15;
            // 
            // tb_suppliers_Phone
            // 
            this.tb_suppliers_Phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.tb_suppliers_Phone.Location = new System.Drawing.Point(9, 345);
            this.tb_suppliers_Phone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_suppliers_Phone.Name = "tb_suppliers_Phone";
            this.tb_suppliers_Phone.Size = new System.Drawing.Size(283, 35);
            this.tb_suppliers_Phone.TabIndex = 11;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.radioButton2.Location = new System.Drawing.Point(1215, 49);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(371, 33);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Прекратяване на връзката";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(67)))), ((int)(((byte)(252)))));
            this.btBack.FlatAppearance.BorderSize = 0;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.Color.White;
            this.btBack.Location = new System.Drawing.Point(14, 929);
            this.btBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(150, 66);
            this.btBack.TabIndex = 31;
            this.btBack.Text = "Назад";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2278, 1009);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.gbSuppliers);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.gbCustomers);
            this.Controls.Add(this.gbOrders);
            this.Controls.Add(this.gbProducts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProcessingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManualAditionForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbProducts.ResumeLayout(false);
            this.gbProducts.PerformLayout();
            this.gbCustomers.ResumeLayout(false);
            this.gbCustomers.PerformLayout();
            this.gbOrders.ResumeLayout(false);
            this.gbOrders.PerformLayout();
            this.gbSuppliers.ResumeLayout(false);
            this.gbSuppliers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbProducts;
        private System.Windows.Forms.Button btRegistrationProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_products_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_products_ProductID;
        private System.Windows.Forms.GroupBox gbCustomers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tb_customers_Phone;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_customers_Email;
        private System.Windows.Forms.Button btRegistrationCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_products_QuantityInStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_products_SupplierID;
        private System.Windows.Forms.GroupBox gbOrders;
        private System.Windows.Forms.Button btRegistrationOrders;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_customers_CustomerID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_customers_FirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_customers_LastName;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb_orders_CustomerID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_orders_OrderID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_customers_Address;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tb_suppliers_SupplierID;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_orders_Quantity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb_orders_ProductID;
        private System.Windows.Forms.GroupBox gbSuppliers;
        private System.Windows.Forms.Button btRegistrationSuppliers;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_suppliers_Name;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tb_suppliers_ContactEmail;
        private System.Windows.Forms.TextBox tb_suppliers_Phone;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_products_Price;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cb_orders_Status;
        private System.Windows.Forms.ComboBox cb_products_Category;
        private System.Windows.Forms.TextBox tb_orders_OrderDate;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btGetCurrentTime;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.Button btRemoveProduct;
        private System.Windows.Forms.Button btRemoveCustomer;
        private System.Windows.Forms.Button btRemoveOrder;
        private System.Windows.Forms.Button btRemoveSupplier;
        private System.Windows.Forms.Button btFindProducts;
        private System.Windows.Forms.Button btFindCustomers;
        private System.Windows.Forms.Button btFindOrders;
        private System.Windows.Forms.Button btFindSuppliers;
        private System.Windows.Forms.Button btEditProduct;
        private System.Windows.Forms.Button btEditCustomer;
        private System.Windows.Forms.Button btEditOrder;
        private System.Windows.Forms.Button btEditSupplier;
    }
}

