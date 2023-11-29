using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySys
{
    public partial class StocksInventory : Form
    {
        private OleDbConnection connect;

        public StocksInventory()
        {
            InitializeComponent();
            connect = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"");
            DisplayStocks();
        }

        private void Stocksbtn_Click(object sender, EventArgs e)
        {
            AddStocks addStocks = new AddStocks();
            addStocks.ShowDialog();
        }
        private void DisplayStocks()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";

            // Define the SQL command to retrieve the stocks information
            string sql = "SELECT itemCodeStocks AS [Item Code], itemNameStocks AS [Item Name], CategoryStocks AS [Category], UnitMStocks AS [Unit Measure], AvailableQtyStocks AS [Available Quantity], LocationStocks AS [Location], ReorderPStocks AS [Reorder Point] FROM Stocks";

            // Create a new OleDbConnection object using the connection string
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Open the connection to the database
                connection.Open();

                // Create a new OleDbCommand object using the SQL command and the connection
                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    // Create a new DataTable object to hold the results
                    DataTable dataTable = new DataTable();

                    // Create a new OleDbDataAdapter object using the command
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command))
                    {
                        // Fill the DataTable with the results from the command
                        dataAdapter.Fill(dataTable);
                    }

                    // Bind the DataTable to the StocksDataGrid control (replace "StocksDataGrid" with the actual name of your DataGridView control)
                    StocksDataGrid.DataSource = dataTable;
                }
            }
        }


        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu sd = new Menu();
            sd.ShowDialog();
        }

        private void StocksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void RefreshView()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";
            string sql = "SELECT itemCodeStocks AS [Item Code], itemNameStocks AS [Item Name], CategoryStocks AS [Category], UnitMStocks AS [Unit Measure], AvailableQtyStocks AS [Available Quantity], LocationStocks AS [Location], ReorderPStocks AS [Reorder Point] FROM Stocks";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        StocksDataGrid.DataSource = dataTable;
                    }
                }
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}