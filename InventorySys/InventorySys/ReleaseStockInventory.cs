using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventorySys
{
    public partial class ReleaseStockInventory : Form
    {
        public ReleaseStockInventory()
        {
            InitializeComponent();
            DisplayReleaseStock();
        }

        private void ReleaseStckbtn_Click(object sender, EventArgs e)
        {
            AddReleaseStocks addReleaseStocks = new AddReleaseStocks();
            addReleaseStocks.ShowDialog();
        }


        private void DisplayReleaseStock()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";

            // Define the SQL command to retrieve the stocks information
            string sql = "SELECT ItemCodeRS AS [Item Code], ItemNameRS AS [Item Name], CategoryRS AS [Category], UnitMeasureRS AS [Unit Measure], ReleaseQtyRS AS [Release Quantity], AvailableQtyRS AS [Available Quantity], NewAvailabilityRS AS [New Availability] FROM ReleaseStocks";

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

                    // Bind the DataTable to the ReleaseStocksDataGrid control (replace "ReleaseStocksDataGrid" with the actual name of your DataGridView control)
                    ReleaseStocksDataGrid.DataSource = dataTable;
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu sd = new Menu();
            sd.ShowDialog();
        }

        private void ReleaseStocksDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void RefreshView()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";
            string sql = "SELECT ItemCodeRS AS [Item Code], ItemNameRS AS [Item Name], CategoryRS AS [Category], UnitMeasureRS AS [Unit Measure], ReleaseQtyRS AS [Release Quantity], AvailableQtyRS AS [Available Quantity], NewAvailabilityRS AS [New Availability] FROM ReleaseStocks";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand command = new OleDbCommand(sql, connection))
                {
                    using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        ReleaseStocksDataGrid.DataSource = dataTable;
                    }
                }
            }
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void label7_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menu sd = new Menu();
            sd.ShowDialog();    
        }

        private void Refreshbtn_Click_1(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}