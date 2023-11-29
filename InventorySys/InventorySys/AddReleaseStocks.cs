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
    public partial class AddReleaseStocks : Form
    {
        public AddReleaseStocks()
        {
            InitializeComponent();


        }


    private void AddReleaseStockbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Klein\\Desktop\\Inventory System.mdb\"";
            string itemCodeRS = ItemCodetxt.Text;
            string itemNameRS = Nametxt.Text;
            int releaseQtyRS = int.Parse(ReleaseQtytxt.Text);
            DateTime dateTimeRS = dateTimePicker1.Value;
            string categoryStocks = "";
            string unitMStocks = ""; 
            int availableQtyStocks = 0;
            int newAvailabilityRS = 0;

            string selectStocksQuery = "SELECT CategoryStocks, UnitMStocks, AvailableQtyStocks FROM Stocks WHERE itemCodeStocks = @itemCodeRS";
            string insertReleaseStocksQuery = "INSERT INTO ReleaseStocks (ItemCodeRS, ItemNameRS, CategoryRS, UnitMeasureRS, ReleaseQtyRS, DateTimeRS, AvailableQtyRS, NewAvailabilityRS) VALUES (@itemCodeRS, @itemNameRS, @categoryRS, @unitMeasureRS, @releaseQtyRS, @dateTimeRS, @availableQtyStocks, @newAvailabilityRS)";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                using (OleDbCommand selectStocksCommand = new OleDbCommand(selectStocksQuery, connection))
                {
                    selectStocksCommand.Parameters.AddWithValue("@itemCodeRS", itemCodeRS);

                    using (OleDbDataReader reader = selectStocksCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            categoryStocks = reader["CategoryStocks"].ToString();
                            unitMStocks = reader["UnitMStocks"].ToString();
                            availableQtyStocks = int.Parse(reader["AvailableQtyStocks"].ToString());
                        }
                    }
                }

                newAvailabilityRS = availableQtyStocks - releaseQtyRS;

                using (OleDbCommand insertReleaseStocksCommand = new OleDbCommand(insertReleaseStocksQuery, connection))
                {
                    insertReleaseStocksCommand.Parameters.AddWithValue("@itemCodeRS", itemCodeRS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@itemNameRS", itemNameRS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@categoryRS", categoryStocks);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@unitMeasureRS", unitMStocks);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@releaseQtyRS", releaseQtyRS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@dateTimeRS", dateTimeRS);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@availableQtyStocks", availableQtyStocks);
                    insertReleaseStocksCommand.Parameters.AddWithValue("@newAvailabilityRS", newAvailabilityRS);

                    insertReleaseStocksCommand.ExecuteNonQuery();
                }

                // Update the AvailableQtyStocks in the Stocks table

                string updateStocksQuery = "UPDATE Stocks SET AvailableQtyStocks = @newAvailabilityRS WHERE itemCodeStocks = @itemCodeRS";

                using (OleDbCommand updateStocksCommand = new OleDbCommand(updateStocksQuery, connection))
                {
                    updateStocksCommand.Parameters.AddWithValue("@newAvailabilityRS", newAvailabilityRS);
                    updateStocksCommand.Parameters.AddWithValue("@itemCodeRS", itemCodeRS);

                    updateStocksCommand.ExecuteNonQuery();
                }
            }

            // Refresh the StocksGrid to update the data

            MessageBox.Show($"Stock released successfully. Quantity Released: {releaseQtyRS}. Remaining Quantity: {newAvailabilityRS}", "Release Complete");
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
