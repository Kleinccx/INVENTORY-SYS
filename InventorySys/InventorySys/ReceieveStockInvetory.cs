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
    public partial class ReceieveStockInvetory : Form
    {
        public ReceieveStockInvetory()
        {
            InitializeComponent();
            DisplayReceiveStocks();
        }

        private void Stocksbtn_Click(object sender, EventArgs e)
        {

            AddReceiveStocks addReceiveStocks = new AddReceiveStocks();
            addReceiveStocks.ShowDialog();
        }

        private void Refreshbtn_Click(object sender, EventArgs e)
        {
           RefreshView();
        }

        private void RefreshView()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";
            // Set up the SQL query to retrieve the list of products in the Cart table
            string getCartQuery = "SELECT * FROM ReceieveStocks";

            // Create a new OleDbDataAdapter object with the query and connection
            using (OleDbDataAdapter adapter = new OleDbDataAdapter(getCartQuery, connectionString))
            {
                // Create a new DataTable object to hold the results of the query
                DataTable cartTable = new DataTable();

                // Fill the DataTable with the results of the query
                adapter.Fill(cartTable);

                // Set the DataSource property of the DataGridView to the DataTable
                RecieveStocksDataGrid.DataSource = cartTable;
            }
        }

     
        
            private void DisplayReceiveStocks()
            {
                string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";
                string sql = "SELECT ItemCodeRCS AS [Item Code], ItemNameRCS AS [Item Name], CategoryRCS AS [Category], UnitMeasureRCS AS [Unit Measure], QuantityRCS AS [Quantity], DateTimeRCS AS [Date Time] FROM ReceiveStocks";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    using (OleDbCommand command = new OleDbCommand(sql, connection))
                    {
                        using (OleDbDataAdapter dataAdapter = new OleDbDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);

                            // Bind the DataTable to the RecieveStocksDataGrid control (replace "RecieveStocksDataGrid" with the actual name of your DataGridView control)
                            RecieveStocksDataGrid.DataSource = dataTable;
                        }
                    }
                }
            }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu sd = new Menu();
            sd.ShowDialog();
        }
    }
                }
            
        
