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
    public partial class AddStocks : Form
    {
        public AddStocks()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddStocksbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";
            string itemCodeStocks = ItemCodetxt.Text;
            string itemNameStocks = Nametxt.Text;
            string categoryStocks = Categorytxt.Text;
            string unitMStocks = UnitMtxt.Text;
            int availableQtyStocks = int.Parse(AvailableQtytxt.Text);
            string locationStocks = Locationtxt.Text;
            int reorderPStocks = int.Parse(ReorderPtxt.Text);

            string insertStocksQuery = "INSERT INTO Stocks (itemCodeStocks, itemNameStocks, CategoryStocks, UnitMStocks, AvailableQtyStocks, LocationStocks, ReorderPStocks) VALUES (@itemCode, @itemName, @category, @unitM, @availableQty, @location, @reorderP)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand insertStocksCommand = new OleDbCommand(insertStocksQuery, connection))
                {
                    insertStocksCommand.Parameters.AddWithValue("@itemCode", itemCodeStocks);
                    insertStocksCommand.Parameters.AddWithValue("@itemName", itemNameStocks);
                    insertStocksCommand.Parameters.AddWithValue("@category", categoryStocks);
                    insertStocksCommand.Parameters.AddWithValue("@unitM", unitMStocks);
                    insertStocksCommand.Parameters.AddWithValue("@availableQty", availableQtyStocks);
                    insertStocksCommand.Parameters.AddWithValue("@location", locationStocks);
                    insertStocksCommand.Parameters.AddWithValue("@reorderP", reorderPStocks);

                    insertStocksCommand.ExecuteNonQuery();
                }
            }

            // Refresh the StocksGrid to update the data

            MessageBox.Show("Stock added successfully.", "Add Complete");
            this.Close();

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
