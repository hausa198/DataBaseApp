using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApp
{
    internal class DataBaseFunctions
    {
        public void ShowTable(string dataBase,DataGridView dataGridView, string table)
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
    }
}
